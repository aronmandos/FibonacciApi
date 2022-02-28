using NUnit.Framework;

namespace FibonacciApi.Logic.Unittests;

public class PrimeServiceTests
{
	[Test]
	[TestCase(-1, false)]
	[TestCase(0, false)]
	[TestCase(1, false)]
	[TestCase(4, false)]
	[TestCase(2, true)]
	[TestCase(3, true)]
	[TestCase(5, true)]
	[TestCase(7, true)]
	[TestCase(5639, true)]
	public void IsPrimeNumber(int number, bool resultTrue)
	{
		//arrange
		var service = new PrimeService();

		//act
		var result = service.IsPrimeNumber(number);

		//assert
		Assert.AreEqual(resultTrue, result);
	}
}