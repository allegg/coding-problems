using CodingProblems.Problem2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingProblemsTests
{
    [TestFixture]
    public class Problem2Should
    {
        private readonly List<int> _numbers = new List<int> { 1, 2, 3, 4, 5 };
        private readonly List<int> _expectedProducts = new List<int> { 120, 60, 40, 30, 24 };

        [Test]
        public void SucceedWithDivision()
        {
            var problem2 = new Problem2();
            var actualProducts = problem2.ProductOfAllButOneWithDivision(_numbers);

            CollectionAssert.AreEqual(_expectedProducts, actualProducts);
        }

        [Test]
        public void SucceedWithoutDivision()
        {
            var problem2 = new Problem2();
            var actualProducts = problem2.ProductOfAllButOneWithoutDivision(_numbers);

            CollectionAssert.AreEqual(_expectedProducts, actualProducts);
        }
    }
}
