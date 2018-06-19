using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestPalindromeProduct
{
    class Program
    {
        static void Main()
        {
            List<int> palindromes = GetPalindromes();
            Console.WriteLine(string.Join(" ", palindromes.Max()));
        }

        private static List<int> GetPalindromes()
        {
            List<int> palindromes = new List<int>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (IsPalindrome(i * j))
                    {
                        palindromes.Add(i * j);
                    }
                }
            }

            return palindromes;
        }

        private static bool IsPalindrome(int product)
        {
            string productAsString = product.ToString();

            for (int i = 0, j = productAsString.Length - 1; i < productAsString.Length; i++, j--)
            {
                if (productAsString[i] != productAsString[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
