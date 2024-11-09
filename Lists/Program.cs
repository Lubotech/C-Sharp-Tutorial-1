using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberzz = new int[7]
            {
                1,2, 3, 4, 5, 6, 7,
            };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            };

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            listNumbers.RemoveAt(0);

            Console.ReadLine();
        }
    }
}
