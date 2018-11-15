// IPCalc.cpp : Defines the entry point for the console application.
//

#include<iostream>
#include<vector>
#include<algorithm>
#include"ipv4calc.hpp"

const size_t g_netsAmount = 6;
const size_t g_filialsAmount = 2;
const uint32_t g_tunnelMask = 0xFFFFFFFC;

namespace
{
    networks::addr_t ResolveMask(std::string mask)
    {
        networks::addr_t ret = 0;
        if (mask[0] == '/')
        {
            mask.erase(0, 1);
            int num = std::stoi(mask);
            ret = networks::NumericMaskToAddr(num);
        }
        else
        {
            ret = networks::StrToAddr(mask);
        }
        return ret;
    }
    uint32_t NearestBigger(uint32_t val)
    {
        size_t pos = 0;
        for (size_t i = 0; i < sizeof(uint32_t) * 8; ++i)
        {
            if ((val >> i) & 1)
                pos = i;
        }
        return pow(2, pos + 1);
    }

    struct lan
    {
        std::string name;
        networks::ipv4calc calc;
        size_t requiredHosts;
    };
}


int main(int argc, char * argv[])
{
    if (argc < 7)
    {
        std::cerr << "Missing ip address"
            << "Usage: NetwCalc.exe 10.30.40.123 255.255.255.0 124 100 1000 433 441 123\n"
            << "       NetwCalc.exe 10.30.40.123 /12 123 100 1000 433 441 123\n";
        return 1;
    }
    using namespace networks;
    ipv4calc ipCalc(StrToAddr(argv[1]), ::ResolveMask(argv[2]));
    std::vector<lan> nets(g_netsAmount);
    for (size_t i = 0; i < g_netsAmount; ++i)
    {
        std::string lanName = "LAN0";
        lanName[3] = i + 1 + '0';
        nets[i].name = lanName;
        nets[i].requiredHosts = atoi(argv[3 + i]);
    }
    std::sort(
        nets.begin(),
        nets.end(),
        [](const lan& l1, const lan& l2) -> bool
    {
        return l1.requiredHosts > l2.requiredHosts;
    }
    );
    addr_t tmp = ipCalc.Address();
    for (size_t i = 0; i < nets.size(); ++i)
    {
        size_t nearBig = NearestBigger(nets[i].requiredHosts);
        nets[i].calc.SetMask(~(nearBig - 1));
        nets[i].calc.Address(tmp);
        tmp += nearBig;
    }
    std::sort(
        nets.begin(),
        nets.end(),
        [](const lan& l1, const lan& l2) -> bool
    {
        return l1.name < l2.name;
    }
    );
    std::cout << "Name\tClaim\tAllot\tSubnet\t\tMask\t\tPref.\tHostMin\t\tHostMax\t\tBroadcast" << std::endl;
    for (auto net : nets)
    {
        std::cout << net.name << '\t'
            << net.requiredHosts << '\t'
            << net.calc.HostPerNet() << '\t'
            << AddrToStr(net.calc.Address()) << '\t'
            << AddrToStr(net.calc.Mask()) << '\t'
            << '/' << net.calc.MaskNumeric() << '\t'
            << AddrToStr(net.calc.HostMin()) << "\t"
            << AddrToStr(net.calc.HostMax()) << '\t'
            << AddrToStr(net.calc.Broadcast()) << std::endl;
    }
    std::cout << std::endl << "Name\tSubnet\t\tMask\t\tPref.\tHostMin\t\tHostMax\t\tBroadcast" << std::endl;
    ipv4calc filials[g_filialsAmount];
    for (size_t i = 0; i < g_filialsAmount; ++i)
    {
        filials[i].Address(tmp);
        filials[i].SetMask(g_tunnelMask);
        tmp += filials[i].HostPerNet() + 2;

        std::cout << "WAN_N" << i+1 << '\t'
            << AddrToStr(filials[i].Address()) << '\t'
            << AddrToStr(filials[i].Mask()) << '\t'
            << '/' << filials[i].MaskNumeric() << '\t'
            << AddrToStr(filials[i].HostMin()) << '\t'
            << AddrToStr(filials[i].HostMax()) << '\t'
            << AddrToStr(filials[i].Broadcast()) << '\t'
            << std::endl;
    }
#ifdef _DEBUG
    system("pause");
#endif
    return 0;
}