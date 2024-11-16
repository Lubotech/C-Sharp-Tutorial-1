using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ReturnNameAgePair();
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {  
                numbers[i] = ReadNumberFromConsole();
            }

            Console.WriteLine();

            foreach (int item in numbers) 
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] newNumbers = CreateRandomArray();
            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        static int[] CreateRandomArray()
        {
            /*int[] numbers = new int[3]
            {
                9, 8, 7
            };
            return numbers;
            */

            return new int[3] { 11, 12, 13 };
        }
        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName() 
        {
            return "Joel";
        }

        static int ReturnAge()
        {
            return 28;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
        static void PrintIntroduction()
        {
            Console.WriteLine($"I am {ReturnName()} and my age is {ReturnAge()}.");
        }
    }
}
