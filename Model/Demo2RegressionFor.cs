using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RegressionUsingFactorial
{
    public static void Main(string[] args)
    {
        Factorial(5);
    }
    public static void Factorial(int number)
    {
        int start = 1;
        int factor = 1;
        for (int i = 1; i <= number; i++)
        {
            factor = factor * i;
        }
        Console.WriteLine(factor);
    }
}
