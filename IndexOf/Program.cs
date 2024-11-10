using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array indexOf method used to search through an array to get a position

            int[] numbers = new int[]
            {
                90, 199, 34, 78, 50, 20, 199, 34
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            
            //int position = Array.IndexOf(numbers, search); // method for searching through everything
            //int position = Array.IndexOf(numbers, search, 4); // method for searching upto a certain position 
            int position = Array.IndexOf(numbers, search, 1, 5); // method for searching in a certain range

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }

            /*
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }

            */

            Console.ReadLine();
        }
    }
}
