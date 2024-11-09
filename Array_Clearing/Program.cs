using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Clearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberz = new int[]
            {
                10, 2, 6, 11, 5, 3, 13, 12, 9, 1, 4, 8, 7
            };

            Array.Clear(numberz, 0, numberz.Length);

            foreach (var item in numberz)
            {
                Console.Write($"{item} ");
            }

            Array.Clear(numberz, 5, 5);

            for (int i = 5; i < 10; i++)
            {
                numberz[i] = default;
            }

            Console.ReadLine();
        }
    }
}
