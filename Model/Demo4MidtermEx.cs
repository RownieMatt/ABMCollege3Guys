using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Prime1to100();
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
    public static void Pyramid()
    {
        int LayerNum = 6;
        int Space;
        int Number;
        for (int i = 1; i <= LayerNum; i++)
        {
            for (Space = 0; Space <= (LayerNum - i); Space++)
                Console.Write(" ");
            for (Number = 1; Number <= i; Number++)
                Console.Write(Number);
            for (Number = (i - 1); Number >= 1; Number--)
                Console.Write(Number);
            Console.WriteLine();
        }
    }
}