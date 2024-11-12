using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Multiples_Exercise
{
    internal class Program
    {
        /*
         * Define and initialise two integers (num, length)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Create int array with size length
         * loop through and insert the (loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            int num = 7;
            int length = 10;
            int[] result = new int[length];

            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = num * i ;
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }
    }
}
