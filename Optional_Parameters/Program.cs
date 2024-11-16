using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);

            PrintName("Joe");

            Console.ReadLine();
        }

        static void PrintName(string name = "Aba") 
        {
            Console.WriteLine($"My name is {name}");
        }

        static int Add(int a, int b = default) 
        {
            Console.WriteLine($"b = {b}");
            return a + b;        
        }
    }
}
