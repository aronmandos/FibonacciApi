using FibonacciApi.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PrimeController : ControllerBase
{
	
	private readonly ILogger<PrimeController> _logger;

	private readonly IPrimeService _primeService;
	
	public PrimeController(ILogger<PrimeController> logger, IPrimeService primeService)
	{
		_logger = logger;
		_primeService = primeService;
	}
	
	[HttpGet("IsPrimeNumber/{number:int}")]
	public IActionResult IsPrimeNumber(int number)
	{
		return Ok(_primeService.IsPrimeNumber(number));
	}
}