using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);
            //Console.WriteLine(success);
            
            //int.TryParse("123", out int result);

            List<string> shoppinglist = new List<string>
            {
                "Coffee", "Milk"
            };

            Console.WriteLine(shoppinglist.IndexOf("Milk"));
            //Console.WriteLine(FindInList("Milk", shoppinglist, out int index));
            //Console.Write(index);

            Console.Write("Enter an item to search: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppinglist, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            /*
            int index = -1; // 0

            for (int i = 0; i < shoppinglist.Count; i++)
            {
                if (shoppinglist[i].ToLower().Equals("coffee"))
                {
                    index = i; 
                }
            }
            bool found = index > -1;
            Console.WriteLine(found  ? "Found" : "Not found");
            */
            Console.ReadLine();
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1; // 0

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static void test(out int num) 
        {
           num = 5;

           //return true;
        }
    }
}
