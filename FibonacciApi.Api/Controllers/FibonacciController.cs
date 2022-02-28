using FibonacciApi.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{
	
	private readonly ILogger<FibonacciController> _logger;

	private readonly IFibonacciService _fibonacciService;
	
	public FibonacciController(ILogger<FibonacciController> logger, IFibonacciService fibonacciService)
	{
		_logger = logger;
		_fibonacciService = fibonacciService;
	}
	
	
	[HttpGet("IsInFibonacci/{number:long}")]
	public IActionResult IsInFibonacci(long number)
	{
		return Ok(_fibonacciService.IsInFibonacci(number));
	}
}