﻿using System;
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

            Console.ReadLine();
        }

        static void test(out int num) 
        {
           num = 5;

           //return true;
        }
    }
}
