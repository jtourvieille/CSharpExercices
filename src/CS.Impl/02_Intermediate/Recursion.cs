using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            return GetNaturalNumbers(new List<int>(), 1, n);
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            if (current > max)
            {
                return naturalNumbers;
            }

            naturalNumbers.Add(current);

            return GetNaturalNumbers(naturalNumbers, current + 1, max);
        }

        public int SumNaturalNumbers(int n)
        {
            return ComputeSum(1, n);
        }

        private int ComputeSum(int min, int current)
        {
            if (current == min)
            {
                return min;
            }

            return current + ComputeSum(min, current - 1);
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, n - 1);
        }

        private bool IsPrime(int n, int current)
        {
            if (current == 1)
            {
                return true;
            }

            if (n % current == 0)
            {
                return false;
            }

            return IsPrime(n, current - 1);
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }

            if (text[0] == text[text.Length - 1])
            {
                return IsPalindrome(text.Substring(1, text.Length - 2));
            }

            return false;
        }
    }
}
