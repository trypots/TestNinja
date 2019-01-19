using NUnit.Framework;

namespace UnitTests.Fundamentals
{
	public class FizzBuzzTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[TestCase(3,"Fizz")]
		[TestCase(6, "Fizz")]
		public void FizzBuzz_MultipleOfThreeProvided_ReturnsFizz()
		{
			
			//var result = 
			Assert.Pass();
		}
	}
}