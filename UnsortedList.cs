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
            if(head==null)
            {
                head = n;
                return true;
            }
            n.Next=head;
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
        

    }
}
