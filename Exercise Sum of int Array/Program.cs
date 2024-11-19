using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Sum_of_int_Array
{
    internal class Program
    {
        /*
         * Create and initialise int array of numbers
         * Create function SumOfNumbers with with int return type
         * int array param
         * function should return total of all numbers
         * call in main and output the total
         * extra: check array length
             * return -1 if array empty
             * check return in main and output message
             * do we need to return -1, how else can we make this?
         */
        static void Main(string[] args)
        {

            int[] numbers = new int[] 
            { 
                0, 1, 2, 3, 4, 5 
            };

            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }

            Console.WriteLine();

            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is: {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }

            Console.ReadLine();
        }
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }
                return total;
            }

            return -1;


        }
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {
                foreach (var item in numbers)
                {
                    total += item;
                }
                return true;
            }

            return false;
        }
    }
}
