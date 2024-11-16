using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calc = Add(50, 70);
            Console.WriteLine(calc);

            int num = ReadInt("Enter a number");
            Console.WriteLine(num);

            int angle = ReadInt("Enter an angle");
            Console.WriteLine(angle);

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");
            int result = Add(firstNum, secondNum);

            Console.WriteLine(result);

            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");

            string details = UserDetails(name, age);
            Console.WriteLine(details);

            Console.ReadLine();
        }

        static string UserDetails(string name, int age) 
        {
            return $"Hello my name is {name} and my age is {age}!";
        }

        static string ReadString(string message) 
        { 
            Console.Write($"{message}: ", Console.ForegroundColor);
            return Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32( Console.ReadLine() );
        }

        static int Add(int x, int y) 
        {
            return x + y;   
        }
    }
}
