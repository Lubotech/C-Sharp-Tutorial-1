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

            string textAge = "-27";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            string textbigNumber = "-9000000000";
            long bigNumber = Convert.ToInt64(textbigNumber);
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negative = -58.56D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            string textPrecision = "6.768570";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();

            Console.WriteLine("What is Your Name");
            string name = Console.ReadLine();
            Console.WriteLine(name + " Welcome to our lesson");
            Console.ReadKey();

            string name1 = "Aba";
            char letter = 'A';

            Console.Write("Your name is ");
            Console.WriteLine(name1);
            Console.WriteLine(letter);


            double num = 24;
            num /= 3;
            Console.WriteLine(num);

            string name2 = "Yana";
            name2 += "is a programmer";
            Console.WriteLine(name2);

            char letter2 = 'a';
            letter2 += 'b';
            Console.WriteLine(letter2);

            float i = 2; i /= 3;
            Console.WriteLine(++i);


            Console.ReadLine();

        }
    }
}
