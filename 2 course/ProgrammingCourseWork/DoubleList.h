#pragma once
#ifndef DOUBLELIST_H
#define DOUBLELIST_H

#include<exception>

template<class T>
class DoubleList
{
public:
    DoubleList() : m_head(nullptr), m_tail(nullptr), m_size(0)
    {}
    ~DoubleList();
    void push_back(const T & val);
    T pop_back();
    size_t size() const { return m_size; }
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
        Node * tmp = m_tail;
        m_tail = new Node(tmp, nullptr, val);
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

#endif