namespace FibonacciApi.Logic;

public class FibonacciService : IFibonacciService
{
	public bool IsInFibonacci(long number)
	{
		return IsInFibonacci(number, 52);
	}

	public bool IsInFibonacci(long number, int limit)
	{
		//the regular fibonacci sequence is all positive
		if (number < 0) return false;
		// 0, 1, 2, and 3 are all in fibonacci.
		if (number < 4) return true;
		
		long first = 2;
		long second = 3;
		for (var i = 0; i < limit-4; i++)
		{
			if (second == number) return true;
			//fibonacci always goes up.
			if (second > number) return false;
			
			var sum = first + second;
			first = second;
			second = sum;
		}

		return false;
	}
	
}