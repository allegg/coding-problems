using System;
using System.Collections.Generic;

namespace CodingProblems.Problem1
{
    /// <summary>
    /// This problem was recently asked by Google.
    ///
    /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
    ///
    /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
    ///
    /// Bonus: Can you do this in one pass?
    /// </summary>
    public class Problem1
    {
        public bool IsExistPairEqualToKNaive(List<int> numbers, int k)
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] + numbers[j] == k)
                        return true;
                }
            }

            return false;
        }

        public bool IsExistPairEqualToKOnePass(List<int> numbers, int k)
        {
            throw new NotImplementedException();
        }
    }
}