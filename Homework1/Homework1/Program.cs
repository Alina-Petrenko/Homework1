﻿using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(5);
            myList.Add(3);
            myList.Add(7);
            myList.AddRange(new [] { 1, 4, 5, 3 });
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            myList.RemoveAt(3);
            myList.Sort();
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(myList[0]);
            //Console.WriteLine(myList[1]);
        }
    }
}
