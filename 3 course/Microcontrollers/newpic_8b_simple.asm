; TODO INSERT CONFIG CODE HERE USING CONFIG BITS GENERATOR
#INCLUDE <P16F84A.INC>
RES_VECT  CODE    0x0000            ; processor reset vector
    GOTO    START                   ; go to beginning of program

INT_VECT  CODE	  0x0004	    ; timer interrupt handler 
    GOTO    TMR_INTERRUPT_HANDLER   ; go to TMR_INTERRUPT_HANDLER
    
VARIANT EQU 0x12		    ; your variant 0x12 = 18
TENMS	EQU 0x0A		    ; just a number representing 10ms 0x0A = 10
ONEMS	EQU 0x8A
CBLOCK 0x0C
    MSCOUNTER
    MSCOUNTER1
ENDC
    
MAIN_PROG CODE                      ; let linker place main program

 START
    BSF STATUS, RP0
    CLRF TRISB ;PORTB all output
    MOVLW b'10100000'
    MOVWF INTCON ;enable timer-overflow interrupt
    MOVLW 0x00
    MOVWF OPTION_REG
    BCF STATUS, RP0
    MOVLW TENMS
    MOVWF MSCOUNTER
    MOVLW VARIANT
    MOVWF MSCOUNTER1
    MOVLW ONEMS
    MOVWF TMR0
    MOVLW 0
    MOVWF PORTB
    
 MAIN
    NOP
    GOTO MAIN ;Loop

TMR_INTERRUPT_HANDLER 
    BCF INTCON, GIE ;Disable all interrupts inside interrupt service routine
    BCF INTCON, T0IF ;disable timer-overflow interrupt flag bit
    BSF INTCON, GIE ;re-enable all interrupts
    MOVLW ONEMS	;reset timer
    MOVWF TMR0	;reset timer
    DECFSZ MSCOUNTER, 1
    GOTO MAIN
    GOTO ONTENMS
    GOTO MAIN

ONTENMS
    MOVLW TENMS	    ;reset first counter
    MOVWF MSCOUNTER ;reset first counter
    DECFSZ MSCOUNTER1, 1
    RETURN
    GOTO ONVARIANTMS
    RETURN
    
ONVARIANTMS
    MOVLW VARIANT   ;reset second counter
    MOVWF MSCOUNTER1;reset second counter
    COMF PORTB, 1
    ;BCF PORTB,	0; clear RB.0
    RETURN
END