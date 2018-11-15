#pragma once
#ifndef IPV4CALC_HPP
#define IPV4CALC_HPP

#include<string>
#include"ipv4types.h"
#include"ipv4helpers.hpp"
namespace networks
{
    class ipv4calc
    {
    public:
        ipv4calc() :addr(0), mask(0) {}
        explicit ipv4calc(const addr_t &addr, const addr_t &mask) :addr(addr), mask(mask) {}
        ipv4calc(const addr_t &addr, const uint8_t &numericMask);
        ~ipv4calc() {}
        addr_t Network()const
        {
            return this->mask & this->addr;
        }
        addr_t Broadcast()const
        {
            return this->Network() | ~this->mask;
        }
        addr_t HostMin()const
        {
            return this->Network() + 1;
        }
        addr_t HostMax()const
        {
            return this->Network() + ~this->mask - 1;
        }
        addr_t Wildcard()const
        {
            return ~this->mask;
        }
        size_t HostPerNet()const
        {
            return this->Wildcard() - 1;
        }

        addr_t Address()const
        {
            return this->addr;
        }
        addr_t Mask()const
        {
            return this->mask;
        }
        size_t MaskNumeric()const
        {
            return CountSetBits(mask);
        }

        void Address(const addr_t &addr)
        {
            this->addr = addr;
        }
        void SetMask(const addr_t &mask)
        {
            this->mask = mask;
        }
        void SetNumericMask(const size_t &numericMask)
        {
            this->mask = NumericMaskToAddr(numericMask);
        }
    private:
        addr_t addr;
        addr_t mask;
    };
}

#endif // !IPV4CALC_H
