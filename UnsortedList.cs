using System;
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
            while (t.Next != null)
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
        public bool Search(T data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.Next;
            }
            return false;
        }
        public bool insertAfter(T value, T data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node n = new Node(value);
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    n.Next = t.Next;
                    t.Next = n;
                    return true;
                }
                t = t.Next;
            }
            throw new NullReferenceException("Given data not present");
        }
        public bool Remove( T input)
        {
            if (head == null)
                return false;
            if (head.Next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data.Equals(input))
                {
                    if (pre == null)
                    {
                        head = t.Next;
                        return true;
                    }
                    pre.Next = t.Next;
                    return true;
                }
                pre = t;
                t = t.Next;
            }
            return false;
        }
        public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.Next;
            }
            return count;
        }
    
    }
}







