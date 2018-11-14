#pragma once
#ifndef IPV4HELPERS
#define IPV4HELPERS

#include<sstream>
#include"ipv4types.h"
namespace networks
{
    addr_t StrToAddr(const std::string &addr)
    {
        std::stringstream ss(addr);
        addr_t ret = 0;
        for (size_t i = 0; i < g_bytesInAddr; ++i)
        {
            addr_t byte = 0;
            ss >> byte;
            ret |= byte << ((g_bytesInAddr - i - 1) * 8);
            ss.get();
        }
        return ret;
    }

    std::string AddrToStr(const addr_t &addr)
    {
        std::stringstream ss;
        for (size_t i = 0; i < g_bytesInAddr; ++i)
        {
            uint8_t byte = addr >> ((g_bytesInAddr - i - 1) * 8);
            ss << (int)byte;
            if (i != g_bytesInAddr - 1)
            {
                ss << '.';
            }
        }
        return ss.str();
    }

    size_t CountSetBits(uint32_t val)
    {
        size_t count = 0;
        while (val)
        {
            count += val & 1;
            val >>= 1;
        }
        return count;
    }

    networks::addr_t NumericToAddr(const uint8_t &numericMask)
    {
        networks::addr_t ret = 0;
        for (size_t i = 0; i < numericMask; ++i)
        {
            ret |= 1 << (sizeof(networks::addr_t) * 8 - i - 1);
        }
        return ret;
    }
}

#endif // !IPV4HELPERS

