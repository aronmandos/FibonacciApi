namespace FibonacciApi.Logic;

public interface IFibonacciService
{
	public bool IsInFibonacci(long number);
	
	public bool IsInFibonacci(long number, int limit);
}
