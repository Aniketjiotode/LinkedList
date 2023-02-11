using System;
using System.Collections.Generic;

namespace LindkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnsortedList<int> list= new UnsortedList<int>();
            list.Append(56);
            list.Append(76);
            list.insert(1, 30);
            list.pop(); 
            Console.WriteLine(list.pop());
        }
    }
}
