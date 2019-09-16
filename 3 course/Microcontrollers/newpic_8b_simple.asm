; TODO INSERT CONFIG CODE HERE USING CONFIG BITS GENERATOR
#INCLUDE <P16F84A.INC>
RES_VECT  CODE    0x0000            ; processor reset vector
    GOTO    START                   ; go to beginning of program

INT_VECT  CODE	  0x0004	    ; timer interrupt handler 
    GOTO    TMR_INTERRUPT_HANDLER   ; go to TMR_INTERRUPT_HANDLER
    
VARIANT EQU 0x12		    ; your variant 0x12 = 18
TENMS	EQU 0x0A		    ; just a number representing 10ms 0x0A = 10
ONEMS	EQU 0x8A		    ; out timer has 8bit, so maximum value is 255
				    ; -> 256 values at all (counting 0)
				    ; our chip is running 1Mhz thus 1 command will run
				    ; 4/1Mhz = 4us/command
				    ; to make 1ms delay (1ms = 1000us) we have to run timer several times
				    ; so, default prescaler for out timer is 2 
				    ; this means it will tick not each 4us, but each 8us
				    ; so how many ticks should we have o achive 1ms?
				    ; 1000us / 8us = 125 ticks
				    ; ONEMS equals 0x8A = 138, yes it should be 125
				    ; but code for countig and gotos takes time, so this number
				    ; is taken just by trying) untill best result
				    ; btw, timer triggers on overflow, so it will tick from 138 till 255
CBLOCK 0x0C			    ; ?????
    MSCOUNTER			    ; variable for counting ten ms
    MSCOUNTER1			    ; variable for counting variant ms
ENDC
    
MAIN_PROG CODE                      ; let linker place main program

 START
    BSF	    STATUS, RP0		    ; ?????
    CLRF    TRISB		    ; set whole port B to output CLRF = clear = set to zero
    MOVLW   b'10100000'		    ; checkout datasheet for INTCON register
    MOVWF   INTCON		    ; enable timer-overflow interrupt
    MOVLW   0x00		    ; checkout datasheet for OPTION_REG
    MOVWF   OPTION_REG		    ; setting up prescaler to 2, and selecting internal osc for ticks
    BCF	    STATUS, RP0		    ; ?????
    MOVLW   TENMS		    ; save to tmp 10
    MOVWF   MSCOUNTER		    ; set value from tmp to MSCOUNTER var
    MOVLW   VARIANT		    ; save to tmp your variant
    MOVWF   MSCOUNTER1		    ; set value from tnp to MSCOUNTER1
    MOVLW   ONEMS		    ; save to tmp our calculated value for timer
    MOVWF   TMR0		    ; reset timer to our calculated value
    MOVLW   0			    ; save value to tmp, 0 - all pins on portb are zero (no signal like)
    MOVWF   PORTB		    ; set valu to PORTB (if there was sth, now its empty)
    
 MAIN
    NOP				    ; lol, just doing sth in the main routine
    GOTO MAIN			    ; just forever loop	    

TMR_INTERRUPT_HANDLER 
    BCF INTCON, GIE		    ; disable all interrupts inside interrupt service routine
    BCF INTCON, T0IF		    ; disable timer-overflow interrupt flag bit
    BSF INTCON, GIE		    ; re-enable all interrupts
    MOVLW ONEMS			    ; reset timer
    MOVWF TMR0			    ; reset timer
    DECFSZ MSCOUNTER, 1		    ; DECrement F, skip next line if F zero
    GOTO MAIN			    ; so we will decrement it 10 times and then go to the next line
    GOTO ONTENMS		    ; here
    GOTO MAIN			    ; just return to main

ONTENMS
    MOVLW TENMS			    ; if we are here, we have to reset our timer, so it can go on a on
    MOVWF MSCOUNTER		    ; if we are here, we have to reset our timer, so it can go on a on
    DECFSZ MSCOUNTER1, 1	    ; old story, checkout line 58
    RETURN			    ; return from function
    GOTO ONVARIANTMS
    RETURN
    
ONVARIANTMS
    MOVLW VARIANT		    ; reset second counter
    MOVWF MSCOUNTER1		    ; reset second counter
    COMF PORTB, 1		    ; finally, yes, toggling values on portb, yahooo
    RETURN
END