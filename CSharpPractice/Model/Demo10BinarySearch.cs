using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo10BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            BinarySearch(Numbers, 3);
            BinarySearch(Numbers, 9);
            BinarySearch(Numbers, 8);



        }
        public static void BinarySearch(int[] Array, int Search)
        {
            int Middle = (Array.Length / 2);
            Console.WriteLine($"Middle is : {Array[Middle]}");
            Console.WriteLine($"Search Number is : {Search}");
            if (Middle > Search)
            {
                for (int Count = 0; Count < Array[Middle] - 1; Count++)
                {
                    Console.WriteLine(Array[Count]);

                }
            }
            else if (Middle < Search - 1)
            {
                for (int Mcount = Array[Middle]; Mcount < Array.Length; Mcount++)
                {
                    Console.WriteLine(Array[Mcount]);

                }

            }
            else if (Array[Middle] == Search)
            {
                Console.WriteLine($"Number {Search} is already found,");

            }
        }
    }
}
