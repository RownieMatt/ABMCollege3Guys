﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Average();
        }
        public static void Average()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            int Num1 = Convert.ToInt32(num1);
            int Num2 = Convert.ToInt32(num2);
            int Num3 = Convert.ToInt32(num3);

            int Step1 = Num1 + Num2 + Num3;
            int Step2 = Step1 / 3;

            Console.WriteLine(Step2);
        }
    }
}