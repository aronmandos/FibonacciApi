
using FibonacciApi.Logic;

var webAppBuilder = WebApplication.CreateBuilder(args);

ConfigureConfiguration(webAppBuilder.Configuration);
ConfigureServices(webAppBuilder.Services);

var webApp = webAppBuilder.Build();

ConfigureMiddleware(webApp, webApp.Services);
ConfigureEndpoints(webApp, webApp.Services);

webApp.Run();


void ConfigureConfiguration(ConfigurationManager configuration)
{
	
}

void ConfigureServices(IServiceCollection services)
{
	services.AddTransient<IFibonacciService, FibonacciService>();
	services.AddTransient<IPrimeService, PrimeService>();
	
	services.AddControllers();
	services.AddEndpointsApiExplorer();
	services.AddSwaggerGen();
}

void ConfigureMiddleware(WebApplication app, IServiceProvider services)
{
	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseHttpsRedirection();
	app.UseAuthorization();
}

void ConfigureEndpoints(IEndpointRouteBuilder app, IServiceProvider services)
{
	app.MapControllers();
}