// IPCalc.cpp : Defines the entry point for the console application.
//

#include<iostream>
#include"ipv4calc.hpp"


int main(int argc, char * argv[])
{
    if (argc < 3)
    {
        std::cerr << "Missing ip address"
            << "Usage: IPCalc.exe 10.30.40.123 255.255.255.0\n"
            << "       IPCalc.exe 10.30.40.123 /12\n";
        return 1;
    }
    using namespace networks;
    ipv4calc ipCalc;
    ipCalc.Address(StrToAddr(argv[1]));

    if (argv[2][0] == '/')
    {
        argv[2] = &argv[2][1];
        uint8_t numericMask = atoi(argv[2]);
        ipCalc.SetNumericMask(numericMask);
    }
    else
    {
        ipCalc.SetMask(StrToAddr(argv[2]));
    }
        
    std::cout << "Address:\t"   << AddrToStr(ipCalc.Address()) << std::endl;
    std::cout << "Netmask:\t"   << AddrToStr(ipCalc.Mask()) << " = " << ipCalc.MaskNumeric() << std::endl;
    std::cout << "Wildcard:\t"  << AddrToStr(ipCalc.Wildcard()) << std::endl;
    std::cout << "Network:\t"   << AddrToStr(ipCalc.Network()) << " /" << ipCalc.MaskNumeric() << std::endl;
    std::cout << "Broadcast:\t" << AddrToStr(ipCalc.Broadcast()) << std::endl;
    std::cout << "HostMin:\t"   << AddrToStr(ipCalc.HostMin()) << std::endl;
    std::cout << "HostMax:\t"   << AddrToStr(ipCalc.HostMax()) << std::endl;
    std::cout << "Hosts/Net:\t" << ipCalc.HostPerNet() << std::endl;
    return 0;
}