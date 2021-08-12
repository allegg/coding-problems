using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Problem2
{
    /// <summary>
    /// This problem was asked by Uber.
    ///
    /// Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
    ///
    /// For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
    ///
    /// Follow-up: what if you can't use division?
    /// </summary>
    public class Problem2
    {
        public List<int> ProductOfAllButOneWithDivision(List<int> numbers)
        {
            var productOfAllButOne = new List<int>();
            var productOfAll = numbers.Aggregate((result, element) => result * element);

            foreach (int number in numbers)
            {
                productOfAllButOne.Add(productOfAll / number);
            }

            return productOfAllButOne;
        }

        public List<int> ProductOfAllButOneWithoutDivision(List<int> numbers)
        {
            var productOfAllButOne = new List<int>();

            for (var i = 0; i < numbers.Count; i++)
            {
                productOfAllButOne.Add(1);

                for(var j = 0; j < numbers.Count; j++)
                {
                    if(i != j)
                        productOfAllButOne[i] *= numbers[j];
                }
            }

            return productOfAllButOne;
        }
    }
}