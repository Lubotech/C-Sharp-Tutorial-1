using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(9);
            Console.WriteLine(result);

            PrintName("Mary");

            Console.ReadLine();
        }

        static void PrintName(string name = "Joe") 
        {
            Console.WriteLine($"My name is {name}");
        }

        static int Add(int a, [Optional]int b) 
        { 
            return a + b;
        }
    }
}
