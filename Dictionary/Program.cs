using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                //KeyValuePair 
                { 1, "Aba" },
                { 2, "Ksushi" },
                { 3, "Yana" }
            };

            Console.ReadLine();  
        }
    }
}
