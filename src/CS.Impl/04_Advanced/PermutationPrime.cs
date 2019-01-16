using System;
using System.Collections.Generic;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {
            List<int> permutationPrimes = new List<int>();

            for (int i = 1; i < upperBound; i++)
            {
                if (IsPrime(i))
                {
                    bool areAllPermutationPrime = true;
                    foreach (var permutation in GetPermutations(i.ToString()))
                    {
                        if (!IsPrime(int.Parse(permutation)))
                        {
                            areAllPermutationPrime = false;
                            break;
                        }
                    }

                    if (areAllPermutationPrime)
                    {
                        permutationPrimes.Add(i);
                    }
                }
            }

            return permutationPrimes.ToArray();
        }

        private IEnumerable<string> GetPermutations(string set)
        {
            var output = new List<string>();
            if (set.Length == 1)
            {
                output.Add(set);
            }
            else
            {
                foreach (var c in set)
                {
                    // Remove one occurrence of the char (not all)
                    var tail = set.Remove(set.IndexOf(c), 1);
                    foreach (var tailPerms in GetPermutations(tail))
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }
            return output;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}