﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter your dream number here : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even!");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }
    }
}
