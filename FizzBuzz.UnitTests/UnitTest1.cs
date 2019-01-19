using System;
using NUnit.Framework;
using static TestNinja.Fundamentals.FizzBuzz;

namespace FizzBuzz.UnitTests
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			var result = GetOutput(5);
		}
	}
}
