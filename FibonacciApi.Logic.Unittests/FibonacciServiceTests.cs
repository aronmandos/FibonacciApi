using System;
using NUnit.Framework;

namespace FibonacciApi.Logic.Unittests;

public class FibonacciServiceTests
{
	[Test]
	[TestCase(-1, false)]
	[TestCase(4, false)]
	[TestCase(0, true)]
	[TestCase(1, true)]
	[TestCase(20365011074, true)]
	public void IsInFibonacci(long number, bool resultTrue)
	{
		//arrange
		var service = new FibonacciService();

		//act
		var result = service.IsInFibonacci(number);

		//assert
		Assert.AreEqual(resultTrue, result);
	}
}