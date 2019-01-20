﻿using NUnit.Framework;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
		{
			var result = TestNinja.Fundamentals.FizzBuzz.GetOutput(15);

			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
		{
			var result = TestNinja.Fundamentals.FizzBuzz.GetOutput(3);

			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
		{
			var result = TestNinja.Fundamentals.FizzBuzz.GetOutput(5);

			Assert.That(result, Is.EqualTo("Buzz"));
		}

		[Test]
		public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
		{
			var result = TestNinja.Fundamentals.FizzBuzz.GetOutput(1);

			Assert.That(result, Is.EqualTo("1"));
		}

	}
}