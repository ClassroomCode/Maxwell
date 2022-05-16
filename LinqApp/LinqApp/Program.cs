using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var evens = nums.Where(n => n > 5);  
            int c = evens.Count();

            foreach (var num in evens) {             
                Console.WriteLine(num);
            }

            Console.WriteLine("----------");

            nums.Add(12);

            foreach (var num in evens) {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
