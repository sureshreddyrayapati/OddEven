using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class OddEven
    {
        static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        public static void OddNumber()
        {
            foreach (int i in numbers)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void EvenNumber()
        {
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
