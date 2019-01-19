using System;
using NUnit.Framework;
using static TestNinja.Fundamentals.FizzBuzz;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		[TestCase(3,"Fizz")]
		[TestCase(6,"Fizz")]
		public void FizzBuzz_MultipleOfThree_ReturnsFizz(int a, string expected)
		{
			var result = GetOutput(a);
			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(5, "Buzz")]
		[TestCase(10, "Buzz")]
		public void FizzBuzz_MultipleOfFive_ReturnsBuzz(int a, string expected)
		{
			var result = GetOutput(a);
			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(15, "FizzBuzz")]
		[TestCase(30, "FizzBuzz")]
		public void FizzBuzz_MultipleOfThreeandFive_ReturnsFizzBuzz(int a, string expected)
		{
			var result = GetOutput(a);
			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(1, "1")]
		[TestCase(4, "4")]
		[TestCase(22, "22")]
		public void FizzBuzz_NonMultipleOfThreeandFive_ReturnsNumberAsString(int a, string expected)
		{
			var result = GetOutput(a);
			Assert.That(result, Is.EqualTo(expected));
		}

	}

}
