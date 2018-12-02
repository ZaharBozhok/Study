#pragma once
#ifndef DOUBLELIST_H
#define DOUBLELIST_H

#include<iostream>
#include<exception>
#include<functional>

template<class T>
class DoubleList
{
    struct Node;
public:
    DoubleList() : m_head(nullptr), m_tail(nullptr), m_size(0)
    {}
    ~DoubleList();
    void push_back(const T & val);
    T pop_back();
    size_t size() const { return m_size; }
    DoubleList(const DoubleList<T> &list);
    void Sort(std::function<bool(const T&, const T&)> comparator);
    void Swap(Node *n1, Node *n2);
    void ShowSame(std::function<bool(const T&, const T&)> comparator)
    {
        if (!m_size)
            throw std::runtime_error("Emtpy list");
        Node * showTmp = m_head;
        size_t count = 0;
        for (Node * it = m_head; it != m_tail->m_next; it = it->m_next)
        {
            if (it->m_next && comparator(it->m_val,it->m_next->m_val))
            {
                count++;
            }
            else
            {
                if (count != 0)
                    for (showTmp; showTmp != it->m_next; showTmp = showTmp->m_next)
                    {
                        std::cout << showTmp->m_val<<std::endl;
                    }
                showTmp = it->m_next;
                count = 0;
            }
        }
        
    }
    friend ostream& operator<<(ostream& os, const DoubleList<T>& dt)
    {
        for (DoubleList<T>::Node *it = dt.m_head; it != dt.m_tail->m_next; it = it->m_next)
        {
            os << it->m_val << std::endl;
        }
        return os;
    }
    T GetTailVal()
    {
        return m_tail->m_val;
    }
private:
    struct Node
    {
        Node() : m_prev(nullptr), m_next(nullptr)
        {}
        Node(Node * prev, Node * next, const T & val) : m_prev(prev), m_next(next), m_val(val)
        {}
        Node * m_prev;
        Node * m_next;
        T m_val;
    };
    Node * m_head;
    Node * m_tail;
    size_t m_size;

    

};

template<class T>
void DoubleList<T>::push_back(const T & val)
{
    if (m_head == nullptr)
    {
        m_head = new Node(nullptr, nullptr, val);
        m_tail = m_head;
    }
    else
    {
        DoubleList<T>::Node * tmp = m_tail;
        m_tail = new DoubleList<T>::Node(tmp, nullptr, val);
        tmp->m_next = m_tail;
    }
    m_size++;
}

template<class T>
T DoubleList<T>::pop_back()
{
    if (m_tail == nullptr || m_size == 0)
    {
        throw std::runtime_error("Popping back from empty list");
    }
    T ret = m_tail->m_val;
    Node * tmp = m_tail;
    m_tail = m_tail->m_prev;
    delete tmp;
    m_size--;
    return ret;
}

template<class T>
DoubleList<T>::~DoubleList()
{
    while (m_size)
        this->pop_back();
}

template<class T>
DoubleList<T>::DoubleList(const DoubleList<T> &list) : m_head(nullptr), m_tail(nullptr), m_size(0)
{
    if (!list.size())
        throw std::runtime_error("Empty list");
    DoubleList<T>::Node *itSrc = list.m_head;
    while (itSrc)
    {
        push_back(itSrc->m_val);
        itSrc = itSrc->m_next;
    }
}

template<class T>
void DoubleList<T>::Swap(DoubleList<T>::Node *n1, DoubleList<T>::Node *n2)
{
    if (n1 == n2 || n1 == nullptr || n2 == nullptr)
        return;
    if (n1->m_prev == n2)
    {
        DoubleList<T>::Node *tmp = n1;
        n1 = n2;
        n2 = tmp;
    }
    if (m_head == n1)
    {
        m_head = n2;
    }
    else if (m_head == n2)
    {
        m_head = n1;
    }

    if (m_tail == n1)
    {
        m_tail = n2;
    }
    else if (m_tail == n2)
    {
        m_tail = n1;
    }
    if (n1->m_next == n2)
    {
        if (n1->m_prev)
            n1->m_prev->m_next = n2;
        if (n2->m_next)
            n2->m_next->m_prev = n1;
        n1->m_next = n2->m_next;
        n2->m_prev = n1->m_prev;
        n2->m_next = n1;
        n1->m_prev = n2;
    }
    else
    {
        DoubleList<T>::Node * tmpNext = n2->m_next;
        DoubleList<T>::Node * tmpPrev = n2->m_prev;

        n2->m_next->m_prev = n1;
        n2->m_prev->m_next = n1;
        n2->m_next = n1->m_next;        
        n2->m_prev = n1->m_prev;

        n1->m_next->m_prev = n2;
        n1->m_prev->m_next = n2;
        n1->m_next = tmpNext;
        n1->m_prev = tmpPrev;
    }
}
template<class T>
void DoubleList<T>::Sort(std::function<bool(const T&, const T&)> comparator)
{
    for(int i=0; i<m_size; i++)
    {
        for (DoubleList<T>::Node *jt = m_head; jt != m_tail; jt = jt->m_next)
        {
            if (comparator(jt->m_val, jt->m_next->m_val))
            {
                Swap(jt, jt->m_next);
                jt = jt->m_prev;
            }
        }
    }
    return;
}
#endif