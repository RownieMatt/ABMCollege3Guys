using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class Demo5Filtering
    {
        public static void Main(string[] args)
        {
            string[] Names = { "My name is Rownie", "My name is Rakeesh", "My name is Basant" };
            LetterFinder(Names);
        }   
        public static void LetterFinder(string[] Array)
        {



            for (int i = 0; i < Array.Length; i++)
            {
                string ArrayCon = Array[i].ToLower();
                if (ArrayCon.Contains('r'))
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }
        public static void NameFinder(string[] Array)
        {



            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].EndsWith('e'))
                {
                    Console.WriteLine(Array[i]);
                }

            }
        }
        public static void ArraySorterLowtoHigh(int[] List)
        {
            Array.Sort(List);

            Console.WriteLine("Ascending :");
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ArraySorterHightoLow(int[] List)
        {
            Array.Sort(List);
            Array.Reverse(List);
            Console.WriteLine("Descending :");


            for (int i = 0; i < List.Length; i++)
            {

                Console.WriteLine(List[i]);
            }
        }
        public static void ArraySorterLetters(string[] List)
        {
            Console.WriteLine("Ascending :");
            for (int i = 0; i < List.Length; i++)
            {
                Array.Sort(List);
                Console.WriteLine(List[i]);
            }
            Console.WriteLine("Descending :");
            for (int i = 0; i < List.Length; i++)
            {
                Array.Sort(List);
                Array.Reverse(List);
                Console.WriteLine(List[i]);
            }
        }
    }
}
}
}
}
