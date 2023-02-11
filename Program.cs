using System;
using System.Collections.Generic;

namespace LindkedList

{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnsortedList<int> list= new UnsortedList<int>();
            list.Add(23);
            list.Add(34);
            list.Add(67);
            list.Append(56);
            list.Append(76);
            list.insert(1, 30);
            Console.WriteLine(list.ToString());
        }
    }
}
