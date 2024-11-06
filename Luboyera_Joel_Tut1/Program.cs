using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

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

            Console.WriteLine();

            double num = 24;
            num /= 3;
            Console.WriteLine(num);

            Console.WriteLine();

            string name2 = "Yana";
            name2 += " is a programmer. ";
            Console.WriteLine(name2);

            Console.WriteLine();

            char letter2 = 'a';
            letter2 += 'b';
            Console.WriteLine(letter2);

            float n = 2; n /= 3;
            Console.WriteLine(++n);

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
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Whats the value of " + numberA + " X " + numberB + " ? ");
            Console.WriteLine();

            /*
            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer == actualAnswer)
                {
                    Console.WriteLine("Well done!");
                }
                else if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }
            */
           
            do
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer == actualAnswer)
                {
                    Console.WriteLine("Well done!");
                }
                else if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    
                }
            } while (answer != actualAnswer);

            Console.WriteLine();

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

            Console.WriteLine();

            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.Write("And how many times do you want to repeat it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int j = 0; j < loopCounter; j++)
                {
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine();

            // condition ? true : false

            for (int k = 0; k <= 10; k += 3)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();

            var l = 0;
            while ( l < 10)
            {
                l++;
                Console.WriteLine(l);
            }
            Console.WriteLine();

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            var value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0} {1}", value, 1000));

            double cash = 10D / 3D;

            Console.WriteLine(cash);
            Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}", cash));
            Console.WriteLine(cash.ToString("C"));
            Console.WriteLine(cash.ToString("C0"));
            Console.WriteLine(cash.ToString("C1"));
            Console.WriteLine(cash.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

            bool success = true;

            while (success)
            {

                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine(); // 10h

                if (int.TryParse(numInput, out int num1))
                {
                    success = false;
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }

            }

            /*
               Ask the user for a number for the table
               Write a for loop to print X times table
            */

            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, number, i * number);
            }   

            /*
             Create a for loop from 1 to X (15)
             3 and 5 = FizzBuzz
             3 = Fizz
             5 = Buzz
             else = number
             */ 

            bool threeDiv = false;
            bool fiveDiv = false;

            for ( int i = 0; i < 15; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                //9 % 3 = 0
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // \t \n \" \\ = \
            var speech = "He said \"something\"";
            Console.WriteLine(speech);

            //$ +
            //$ "Your name is {name}"
            //"Your name is " + name

            string path = @"C:\users\desktop\C#";
            Console.WriteLine(path);

            var someone = @"Hello ""Someone""";
            Console.WriteLine(someone);

            string surname = "Sashulya";
            var age2 = 25;
            Console.WriteLine("Surname: " + surname + "\nAge: " + age2);
            Console.WriteLine("Your surname is {0}, and your age is {1}", surname, age2);
            Console.WriteLine($"Your surname is {surname}, and your age is {age2}");

            string test = string.Concat("Your name is ", surname, " and your age is", age2);
            Console.WriteLine(test);
            Console.WriteLine(string.Concat("Your name is ", surname, " and your age is", age2));

            string[] names = new string[] { "Joel", " Ksushi", " Angie" };

            Console.WriteLine(names);

            Console.WriteLine(string.Concat(names));

            string name4 = string.Empty;
            Console.WriteLine(name4);

            string message1 = "Hello";
            string compare = "Hello";

            if (message1 == compare)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.WriteLine("Enter your name: ");
            string name5 = Console.ReadLine();

            //if (name5 != "")
            if (!name5.Equals(""))
            {
                Console.WriteLine("Your name is " + name5);
            }
            else
            {
                Console.WriteLine("Invalid name input ");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'i', 'o' };
            object newCompare = new string(chars);

            //if (message1.Equals(newCompare))
            if (newCompare == message1)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            string message2 = "C# is awesome ";

            /*
            Console.WriteLine(message2[0]);
            Console.WriteLine(message2[1]);
            Console.WriteLine(message2[2]);
            Console.WriteLine(message2[3]);
            */

            for (int i = 0; i < message2.Length; i++)
            {
                Console.Write(message2[i]);
                Thread.Sleep(1000);
            }


            Console.WriteLine();
            Console.WriteLine(message2.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message2.Length; i++)
            {
                if (message2[i].Equals("C"))
                {
                    contains = true;
                }
            }

            /*
             Ask user to input message
             Print in order
             Print in reverse
             */

            Console.Write("Enter your message: ");
            string message3 = Console.ReadLine();

            Console.WriteLine(message3[0]);
            Console.WriteLine(message3.Length);

            for (int i = 0; i < message3.Length; i++)
            {
                Console.Write(message3[i]);
            }

            Console.WriteLine();

            for (int i = message3.Length - 1; i >= 0; i--)
            {
                Console.Write(message3[i]);
            }

            Console.WriteLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string passwordC = Console.ReadLine();  

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            int num2 = 5;
            int num3 = 10;
            int num4 = 15;
            int num5 = 20;

            int total = num2 + num3 + num4;

            int[] numbers = new int[4];
            /*
            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            */

            //Console.WriteLine($"{num2} {num3} {num4}");
            //Console.Write($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            const int angleCount = 3;
            int[] angles = new int[3]; 

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }
            Console.WriteLine(angleSum);
            
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");

            int[] numberz = new int[]
            {
                10, 2, 6, 11, 5, 3, 13, 12, 9, 1, 4, 8, 7
            };

            /*string test1 = "";
            test1.Replace(" ", " ");*/
            

            Array.Sort(numberz);

            foreach (int numz in numberz)
            {
                Console.Write($"{numz} ");
            }
         
            Array.Reverse(numberz);
            foreach (var item in numberz)
            {
                Console.Write($"{item} ");
            }

            Array.Clear(numberz, 0, numberz.Length);

            foreach (var item in numberz)

            Console.ReadLine();

        }
    }
} 
