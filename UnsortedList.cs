using System;
using System.Collections.Generic;
using System.Text;

namespace LindkedList

{
    internal class UnsortedList
    {
        private Node head;
        public class Node
        {
            public int data;
            public Node Next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public bool Add(int data)
        {
            Node n = new Node(data);
            if(head==null)
            {
                head = n;
                return true;
            }
            n.Next=head;
            head = n;
            return true;
        }
        public bool Append(int data)
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
        public bool insert(int ind,int data)
        {
            Node n=new Node(data);
            if (ind==0)
            {
              n.Next = head;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind>0 && t.Next != null)
            {
                ind--;
                pre = t;
                t = t.Next;
            }
            if(ind==0)
            {
                pre.Next = n;
                n.Next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }

        public int pop()
        {
            int value;
            if(head==null)
                throw new NullReferenceException("empty List");
            if (head.Next == null)
            {
                value= head.data;
                head = null;
                return value;
            }
            value= head.data;
            head = head.Next;
            return value;
        }
        public int PopLast() 
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
            int obj = t.data;
            if (head.Next == null)
            {
                head = null;
            }
            pre.Next = null;
            return obj;
        }
        public bool Search(int data)
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
        public bool insertAfter(int value, int data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node n = new Node(data);
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(value))
                {
                    t.Next = n;
                    n.Next = t.Next;
                    return true;
                }
                t=t.Next;
            }
            throw new NullReferenceException("Given data not present");
        }
        public bool Remove(int input)
        {
            if (head == null)
                return false;
            if (head.Next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
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
