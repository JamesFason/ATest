using System;
using System.Collections.Generic;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // implement Where without using System.Linq
            var evenNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.Where(x => x%2 == 0);
            Console.WriteLine("Hello World!");
        }
    }
}
