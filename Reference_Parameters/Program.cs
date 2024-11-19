using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            string name = "Abraham";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);

            Console.WriteLine();

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
              Console.WriteLine($"Your new name is {name}");
            }
            else
            {
                Console.WriteLine("New name can not be empty");
            }
            Console.ReadLine();
        }

        static bool ChangeName(ref string name, string newName)
        { 
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
            
        }

        static void Assign(ref int num, ref string name)
        {
            name = "Joel";
            num = 20;
        }
    }
}
