using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int angleCount = 3;
            int[] angles = new int[3];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }
            Console.WriteLine(angleSum);

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");

            Console.ReadLine();
        }
    }
}
