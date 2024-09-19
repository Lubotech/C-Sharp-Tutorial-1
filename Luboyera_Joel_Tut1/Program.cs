using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luboyera_Joel_Tut1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            //int x = 10;
            //int y = 20; 
            //int z = 30;

            int x = 10, 
                y = 20, 
                z = 30;

            int age = -28;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = -9000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negative = -58.56D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 6.768570F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();


        }
    }
}
