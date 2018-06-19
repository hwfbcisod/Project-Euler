using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FibonacciSum
{
    class Program
    {
        static void Main()
        {
            int first = 1;
            int second = 1;
            int third = 0;
            int sum = 0;

            while (true)
            {
                third = first + second;
                first = second;
                second = third;

                if (third <= 4000000)
                {
                    if (third % 2 == 0)
                    {
                        sum += third;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
