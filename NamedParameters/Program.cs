using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Aba";
            int ageInput = 23;
            string addressInput = "1 Something Road";

            PrintDetails( age: ageInput, 
                          address: addressInput, 
                          name: nameInput);

            Console.ReadLine();

        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Address:{address}");
        }
    }
}
