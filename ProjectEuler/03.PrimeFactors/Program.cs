using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimeFactors
{
    class Program
    {
        static void Main()
        {
            List<long> factors = GetAllFactors(600851475143);
            List<long> primeFactors = GetPrimeFactors(factors);
            Print(primeFactors);

            
        }

        private static List<long> GetPrimeFactors(List<long> factors)
        {
            List<long> primeFactors = new List<long>();

            for (int i = 0; i < factors.Count; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(factors[i]); j++)
                {
                    if (factors[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeFactors.Add(factors[i]);
                }
            }

            return primeFactors;
        }

        private static void Print(List<long> collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }
        private static List<long> GetAllFactors(long num)
        {
            List<long> factors = new List<long>();

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0 && i * i != num)
                {
                    factors.Add(i);
                    factors.Add(num / i);
                }
                else if (num % i == 0 && i * i == num)
                {
                    factors.Add((int)i);
                }
            }

            return factors;
        }
    }
}
