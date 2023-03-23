using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo9ArraysAndArithmetics
    {
    }
    public static void Median(int[] Array)
    {
        int sum = 0;
        for (int Num1 = 0; Num1 < Array.Length; Num1++)
        {
            sum = sum + Array[Num1];

        }
        int Result = sum / Array.Length + 1;
        Console.WriteLine("Median of this array is:" + Result);
    }
    public static void Mode(int[] Array)
    {
        for (int Num1 = 0; Num1 < Array.Length; Num1++)
        {
            for (int Num2 = Array.Length - 1; Num1 < Num2; Num2--)
            {
                if (Array[Num1] == Array[Num2])
                {
                    Console.WriteLine("Mode of this array : " + Array[Num1]);
                }
            }
        }
    }
    public static void Mean(int[] Array)
    {
        double sum = 0;
        for (int Num1 = 0; Num1 < Array.Length; Num1++)
        {
            sum = sum + Convert.ToDouble(Array[Num1]);

        }
        double Result = Convert.ToDouble(sum / Array.Length);
        Console.WriteLine("Mean of this array is: " + Result);
    }
}
