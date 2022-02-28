namespace FibonacciApi.Logic;

public class PrimeService : IPrimeService
{
	public bool IsPrimeNumber(int number)
	{
		//this method logic is based on https://stackoverflow.com/a/15743238
		
		if (number <= 1) return false;
		if (number == 2) return true;
		if (number % 2 == 0) return false;

		var boundary = (int)Math.Floor(Math.Sqrt(number));
          
		for (var i = 3; i <= boundary; i += 2)
			if (number % i == 0)
				return false;
    
		return true;  
	}
}