#include<iostream>
#include<functional>
#include<random>
#include<time.h>
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
    friend ostream& operator<<(ostream& os, const Temperature& temp)
    {
        os << "Day : " << temp.m_day << " Temp : " << temp.m_temp;
        return os;
    }
};

void Help()
{
    std::cout << "h - help" << std::endl
        << "a - add new temperature" << std::endl
        << "m - get max temperature" << std::endl
        << "s - get sorted by temperature descending " << std::endl
        << "q - get days with equal temp" << std::endl<<
     "e - exit" << std::endl;
}

int main()
{
    srand(time(NULL));
    typedef Temperature temp_t;
    DoubleList<temp_t> dl;
    char ch = 0;
    Help();
    while (ch != 'q')
    {
        cout << "Enter your choice : ";
        std::cin >> ch;
        temp_t temp;
        switch (ch)
        {
        case 'h':
            Help();
            break;
        case 'a':
            cout << "Enter day : ";
            cin >> temp.m_day;
            cout << "Enter temp : ";
            cin >> temp.m_temp;
            dl.push_back(temp);
            dl.Sort(
                [](const temp_t& a, const temp_t& b)->bool {return a.m_temp > b.m_temp; }
            );
            break;
        case 'm':
            std::cout << dl.GetTailVal() << std::endl;
            break;
        case 's':
            std::cout << dl << std::endl;
            break;
        case 'q':
            dl.ShowSame(
                [](const temp_t& a, const temp_t& b)->bool {return a.m_temp == b.m_temp; }
            );
            break;
        case 'e':
            return 0;
            break;
        }
    }
#ifdef _DEBUG
        system("pause");
#endif
    return 0;
}