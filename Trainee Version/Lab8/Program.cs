﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Number = 0.0;
        
            Number = double.Parse(Console.ReadLine());

            Console.WriteLine("Number entered is : " + Number);
            Console.WriteLine("Whole part of the given number is : " + DecimalSplitter.GetWhole(Number));
            Console.WriteLine("Fractional part of the given number is : " + DecimalSplitter.GetFraction(Number));

            Console.ReadLine();
        }
    }
}
