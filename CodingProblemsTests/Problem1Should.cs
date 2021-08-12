using CodingProblems.Problem1;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingProblemsTests
{
	[TestFixture]
	public class Problem1Should
	{
		[Test]
		public void TestNaiveSuccess()
		{
			var numbers = new List<int> { 10, 15, 3, 7 };
			var k = 17;

			var problem = new Problem1();
			var actual = problem.IsExistPairEqualToKNaive(numbers, k);

			Assert.IsTrue(actual);
		}

		[Test]
		public void TestNaiveFailure()
		{
			var numbers = new List<int> { 10, 15, 3, 7 };
			var k = 9;

			var problem = new Problem1();
			var actual = problem.IsExistPairEqualToKNaive(numbers, k);

			Assert.IsFalse(actual);
		}

		[Test]
		public void TestOnePassSuccess()
		{
			var numbers = new List<int> { 10, 15, 3, 7 };
			var k = 17;

			var problem = new Problem1();
			var actual = problem.IsExistPairEqualToKOnePass(numbers, k);

			Assert.IsTrue(actual);
		}

		[Test]
		public void TestOnePassFailure()
		{
			var numbers = new List<int> { 10, 15, 3, 7 };
			var k = 9;

			var problem = new Problem1();
			var actual = problem.IsExistPairEqualToKOnePass(numbers, k);

			Assert.IsFalse(actual);
		}
	}
}