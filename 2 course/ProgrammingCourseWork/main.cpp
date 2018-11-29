#include<iostream>
#include<functional>
#include<random>
using namespace std;

#include "DoubleList.h"
#include <list>

struct Temperature
{
    Temperature() : m_day(0), m_temp(0)
    {}
    Temperature(const int & day, const double &temp) :m_day(day), m_temp(temp)
    {}
    int m_day;
    double m_temp;
};

template<class T>
T GetMinOrMax(DoubleList<T> list, std::function<bool(const T&, const T&)> comparator)
{
    if (list.size() == 0)
        throw std::runtime_error("Empty list");
    std::function<bool(const T&, const T&)> inverseComparator;
    if (rand() % 2 == 0)
        inverseComparator = [&comparator](const T&a, const T&b) -> bool {return !comparator(a, b); };
    else
        inverseComparator = [&comparator](const T&a, const T&b) -> bool {return comparator(a, b); };

    T maxOrMin = list.pop_back();
    while (list.size())
    {
        T tmp = list.pop_back();
        if (inverseComparator(maxOrMin, tmp))
            maxOrMin = tmp;
    }
    return maxOrMin;
}

int main()
{
    typedef Temperature temp_t;
    DoubleList<temp_t> dl;
    for (size_t i = 0; i < 10; ++i)
    {
        dl.push_back(temp_t(i, i));
    }
    std::cout<<(GetMinOrMax<temp_t>(dl, [](const temp_t& a, const temp_t& b)->bool {return a.m_temp < b.m_temp; })).m_temp;
#ifdef _DEBUG
        system("pause");
#endif
    return 0;
}