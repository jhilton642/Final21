using System;
using System.Collections.Generic;
using System.Linq;

namespace Final21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 0, 1, 3, 77, 137, 343, 7, 13, 21, 37, 73 };
            string[] flavors = { "lemon", "lime", "vanilla", "rocky road", "chocolate", "butter pecan" };
            int max = 0;
            var over100 = new List<int>();
            int sum = 0;
            foreach (var item in luckyNumbers)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item > 100)
                {
                    over100.Add(item);
                }
                sum += item;
            }
            Console.WriteLine("The max is " + max);
            Console.Write("Lucky numbers over 100: ");
            foreach (var item in over100)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The average lucky number is: " + sum/luckyNumbers.Length);
            Array.Sort(luckyNumbers);
            foreach (var item in luckyNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Items that contain 'l': ");
            foreach (var item in flavors)
            {
                if (item.Contains('l') == true)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Items that start with 'l': ");
            foreach (var item in flavors)
            {
                if (item.StartsWith('l') == true)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.Write("The flavors soreted by length: ");
            IOrderedEnumerable<string> orderedFlavors = flavors.OrderBy(s => s.Length);
            foreach (var item in orderedFlavors)
            {
                Console.Write(item + " ");
            }
            bool mocoa = flavors.Contains("mocoa");
            Console.WriteLine();
            Console.WriteLine("The list of flavors contains mocoa: " + mocoa);
        }
    }
}
