using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = int.TryParse("123", out int result);
            Console.WriteLine(success);

            Console.WriteLine();

            if (int.TryParse("123", out int results))
            {
                Console.WriteLine(results);
            }

            Console.WriteLine();

            

            WelcomeMessage();

            CreateAndPrintArray();

            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[4] { 1, 2, 3, 4 };

            foreach (var item in numbers) 
            {
                Console.Write($"{item} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program!");
        }
    }
}
