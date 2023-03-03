using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo11Returning
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(Name("Rownie"));
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(CharOrNot('C'));
            Console.WriteLine(Multiply(10.10, 10.10));
            Console.WriteLine(AreYou18(18));

        }
        public static string Name(string name)
        {
            return name;
        }
        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }
        public static char CharOrNot(char Character)
        {
            return Character;
        }
        public static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public static bool AreYou18(int Age)
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}