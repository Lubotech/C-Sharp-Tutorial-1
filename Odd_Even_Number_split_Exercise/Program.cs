using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Number_split_Exercise
{
    internal class Program
    {
        /*
         * Create two lists with integer data type, one for even numbers, one for odd
         * Loop for 0-20
             * If number is even, add to even list
             * If number is odd, add to the odd list
         * Print even  list
         * Print odd list
         */
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing odd numbers:");

            foreach (var item in odd) 
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine + "Printing even numbers:");

            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
