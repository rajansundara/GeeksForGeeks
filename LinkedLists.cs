using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class LinkedLists
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(2);
            list.AddLast(4);
            list.AddLast(6);
            list.AddLast(8);

            Console.WriteLine("Total nodes in list are : " + list.Count);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            list.Remove(list.First);

            Console.WriteLine("Total nodes in list are : " + list.Count);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
