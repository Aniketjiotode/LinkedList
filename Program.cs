using System;
using System.Collections.Generic;

namespace LindkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnsortedList<int> list= new UnsortedList<int>();
            list.Add(56);
            list.Add(30);
            list.Add(76);
           Console.WriteLine(list.Search(30));
        }
    }
}
