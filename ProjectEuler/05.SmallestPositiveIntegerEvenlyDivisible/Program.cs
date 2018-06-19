using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SmallestPositiveIntegerEvenlyDivisible
{
    class Program
    {
        static void Main()
        {
            int[] divisors = { 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 14, 16, 17, 18, 19 };

            for (long i = 2520; i < long.MaxValue; i++)
            {
                bool isDivisible = true;

                for (int j = 0; j < divisors.Length; j++)
                {
                    if (i % divisors[j] != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
