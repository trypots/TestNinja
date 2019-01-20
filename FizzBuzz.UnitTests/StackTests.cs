using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace FizzBuzz.UnitTests
{
	[TestFixture]
	public class StackTests
	{

		Stack<string> _stack;
		
		[SetUp]
		public void Setup()
		{
			_stack = new Stack<string>();
		}

		[TearDown]
		public void TearDown()
		{
			_stack = null;
		}

		[Test]
		public void Stack_PushNull_ReturnsArgumentNullException()
		{
			Assert.That(() => _stack.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
		}

		[Test]
		public void Stack_PopEmptyStack_ReturnsInvalidOperationException()
		{
			Assert.That(() => _stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
		}

		[Test]
		public void Stack_PeekEmptyStack_ReturnsInvalidOperationException()
		{
			Assert.That(() => _stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
		}

		[Test]
		public void Stack_PushPeekAndPopValidValues_StackBehavesCorrectly()
		{
			Assert.That(_stack.Count, Is.EqualTo(0));
			_stack.Push("a");
			_stack.Push("b");
			Assert.That(_stack.Peek(), Is.EqualTo("b"));
			Assert.That(_stack.Count, Is.EqualTo(2));
			Assert.That(_stack.Pop(), Is.EqualTo("b"));
			Assert.That(_stack.Count, Is.EqualTo(1));
			Assert.That(_stack.Pop(), Is.EqualTo("a"));
			Assert.That(_stack.Count, Is.EqualTo(0));
		}

	}
}
