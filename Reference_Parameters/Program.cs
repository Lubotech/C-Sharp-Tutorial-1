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
            Assign(out num);
            Console.WriteLine("num");

            Console.ReadLine();
        }

        static void Assign(out int num)
        {
            num = 20;
        }
    }
}
