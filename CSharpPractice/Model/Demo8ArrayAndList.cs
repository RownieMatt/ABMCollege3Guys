using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo8ArrayAndList
    {
    }
    public static void ArrayCommonN(int num)
    {
        int[] Array1 = { 1, 2, 3 };
        int[] Array2 = { 3, 4, 5 };
        int[] Array3 = { 5, 3, 7 };
        for (int A1 = 0; A1 < Array1.Length; A1++)
        {
            for (int A2 = 0; A2 < Array2.Length; A2++)
            {
                for (int A3 = 0; A3 < Array3.Length; A3++)
                {
                    if (Array1[A1] == num && Array2[A2] == num && Array3[A3] == num)
                    {
                        Console.WriteLine($"All 3 Arrays have {num} in them");
                    }
                }
            }
        }

    }
    public static void ArraySort(int[] IArray)
    {
        Array.Sort(IArray);
        Console.WriteLine("In Ascending Order:");
        foreach (int x in IArray)
        {
            Console.WriteLine(x);
        }

        Array.Reverse(IArray);
        Console.WriteLine("In Descending Order:");
        foreach (int x in IArray)
        {
            Console.WriteLine(x);
        }
    }
    public static void DuplicateRemover(int[] Array)
    {
        for (int Num = 0; Num < Array.Length; Num++)
        {
            bool isDifferent = false;
            for (int Num2 = Array.Length - 1; Num < Num2; Num2--)
            {
                if (Array[Num] == Array[Num2])
                {
                    isDifferent = true;
                    break;
                }
            }
            if (!isDifferent)
            {
                Console.WriteLine(Array[Num]);
            }
        }
    }
    public static void ArrayAdd(int[] Array)
    {
        int sum = 0;

        for (int IndexCount = 0; IndexCount < Array.Length; IndexCount++)
        {
            sum += Array[IndexCount];
        }
        Console.WriteLine(sum);
    }
}
