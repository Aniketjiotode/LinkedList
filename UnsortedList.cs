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

    }
}
