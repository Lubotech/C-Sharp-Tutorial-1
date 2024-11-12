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
            /*Dictionary<int, string> names = new Dictionary<int, string>
            {
                //KeyValuePair 
                { 1, "Aba" },
                { 2, "Ksushi" },
                { 3, "Yana" }
            };

            for (int i = 0; i < names.Count; i++) 
            {
               KeyValuePair<int, string> pair = names.ElementAt(i);

                Console.WriteLine( $"{pair.Key} - {pair.Value}");
            }

            Console.WriteLine();

            foreach ( KeyValuePair<int, string> item in names)
            {
                Console.WriteLine( $"{item.Key} - {item.Value}" );
            }
            */

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Aba" },
                {"Science", "Test" }
            };

            //Console.WriteLine(teachers["math"]); //int.TryParse Convert

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Gambler";
            }
            else 
            {
                Console.WriteLine("Math teacher not found");
            }

            //teachers.Remove("Math");
            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else 
            {
                Console.WriteLine("Math not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
