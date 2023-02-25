using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo7ArithmeticPractice
    {
        public static void Main(string[] args)
        {
            fnc();
        }
        public static void fnc()
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int Answer = i * Num;
                Console.WriteLine($"{Num} * {i} = " + Answer);
            }
        }
        public static void Prime1to100()
        {
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i + "  ");
                    }
                }
            }
        }
    }
}
