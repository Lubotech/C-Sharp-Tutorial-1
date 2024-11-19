using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Area_of_a_Triangle
{
    internal class Program
    {
        /*
         * Ask a user for base and height, store them
         * Create function to calculate the area
         * Function should calculate the area using: (base x height) / 2
         * Call in main and print out the area of the triangle
         */
        static void Main(string[] args)
        {
            
            int width = ReadInt("Enter base: ");
            int height = ReadInt("Enter height: ");

            int result = calcArea(width, height);
            Console.WriteLine($"The area is {result}");

            Console.ReadLine();
        }

        static int calcArea(int width, int height)
        {
            return (width * height) / 2;
        }
        static int ReadInt(string message) 
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
            


        }
    }
}
