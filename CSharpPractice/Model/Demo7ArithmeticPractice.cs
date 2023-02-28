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

        }
        public static void MultipllicationTable()
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
            
            for (int First = 1; First < 101; First++)
            {
                int count = 0;
                if (First > 1)
                {
                    for (int Second = 2; Second < First; Second++)
                    {
                        if (First % Second == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(First);
                    }
                }
            }
        }
        public static void StringAdd()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0, remainder = 0;

            while (num != 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
        public static void SumNNumbers()
        {
            int Count = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= Count; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        public static void Factorial()
        {
            int Count = Int32.Parse(Console.ReadLine()), Result = 1;

            for (int i = 1; i <= Count; i++)
            {
                Result = Result * i;
            }
            Console.WriteLine(Result);

        }
    }
}
