using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberz = new int[]
            {
                10, 2, 6, 11, 5, 3, 13, 12, 9, 1, 4, 8, 7
            };

            /*string test1 = "";
            test1.Replace(" ", " ");*/


            Array.Sort(numberz);

            foreach (int numz in numberz)
            {
                Console.Write($"{numz} ");
            }

            Console.WriteLine();

            Array.Reverse(numberz);
            foreach (var item in numberz)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
