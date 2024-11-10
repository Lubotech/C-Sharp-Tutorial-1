using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ask user to input message
            Print in order
            Print in reverse
            */

            Console.Write("Enter your message: ");
            string message3 = Console.ReadLine();

            Console.WriteLine(message3[0]);
            Console.WriteLine(message3.Length);

            for (int i = 0; i < message3.Length; i++)
            {
                Console.Write(message3[i]);
            }

            Console.WriteLine();

            for (int i = message3.Length - 1; i >= 0; i--)
            {
                Console.Write(message3[i]);
            }
        }
    }
}
