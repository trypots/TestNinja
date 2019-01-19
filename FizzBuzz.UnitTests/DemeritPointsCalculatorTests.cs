using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class DemeritPointsCalculatorTests
	{

		[Test]
		[TestCase(-1)]
		[TestCase(301)]
		public void DemeritPointsCalculator_LessThanZeroOrMoreThan300_ReturnsArgumentOutOfRangeException(int a)
		{
			DemeritPointsCalculator calculator = new DemeritPointsCalculator();

			Assert.That(() => calculator.CalculateDemeritPoints(a), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
		}

		[Test]
		[TestCase(0, 0)]
		[TestCase(64, 0)]
		[TestCase(65, 0)]
		public void DemeritPointsCalculator_ZeroTo65_ReturnsZero(int a, int expected)
		{

			DemeritPointsCalculator calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(a);

			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(66, 0)]
		[TestCase(69, 0)]
		public void DemeritPointsCalculator_66To69_ReturnsZero(int a, int expected)
		{

			DemeritPointsCalculator calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(a);

			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(70, 1)]
		[TestCase(74, 1)]
		public void DemeritPointsCalculator_70To74_ReturnsOne(int a, int expected)
		{

			DemeritPointsCalculator calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(a);

			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(75, 2)]
		[TestCase(79, 2)]
		public void DemeritPointsCalculator_75To79_ReturnsTwo(int a, int expected)
		{

			DemeritPointsCalculator calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(a);

			Assert.That(result, Is.EqualTo(expected));
		}

	}
}
