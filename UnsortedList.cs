﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LindkedList

{
    internal class UnsortedList<T>
    {
        private Node head;
        public class Node
        {
            public T data;
            public Node Next;
            public Node(T data)
            {
                this.data = data;
            }
        }

        public bool Add(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.Next = head;
            head = n;
            return true;
        }
        public override string ToString()
        {
            if (head == null)
            {

                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.Next;
            }
            return s;
        }
        public bool Append(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.Next != null)
            {
                t = t.Next;
            }
            t.Next = n;
            return true;
        }
        public bool insert(int ind, T data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.Next = head;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t.Next != null)
            {
                ind--;
                pre = t;
                t = t.Next;
            }
            if (ind == 0)
            {
                pre.Next = n;
                n.Next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }

        public T pop()
        {
            T value;
            if (head == null)
                throw new NullReferenceException("empty List");
            if (head.Next == null)
            {
                value = head.data;
                head = null;
                return value;
            }
            value = head.data;
            head = head.Next;
            return value;
        }
        public T PopLast() 
        {
            if (head == null)
            {
                throw new NullReferenceException("List is Empty");
            }
            Node t = head, pre = head;
            while (t.Next!= null)
            {
                pre = t;
                t = t.Next;
            }
            T obj = t.data;
            if (head.Next == null)
            {
                head = null;
            }
            pre.Next = null;
            return obj;
        }
    }
}

    

