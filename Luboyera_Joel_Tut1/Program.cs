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
            var age = Convert.ToInt32(textAge);
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

            Console.WriteLine("Here we are");
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

            const int vat = 20;
            const double percentVAT = (20 / 100D);

            int balance = 1000;

            Console.WriteLine(balance * (20 / 100D));
            Console.WriteLine(balance * percentVAT);

            Console.Write("Enter your name: ");
            string name3 = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age1Input = Console.ReadLine();
            int age1 = Convert.ToInt32(age1Input);

            Console.WriteLine("Your name is " + name3 + " and your age " + age1);

            // ==  >  >=  <  <=  !=


            if (age1 < 0 || age1 > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age1 >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age1 >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
                
            }

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " X " + numberB + ": ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong!");
            }

            Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thur");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default: Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {

            }
            Console.ReadLine();

        }
    }
}
