using Factorial.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "The factorial of 10 is " + FactorialService.CalculateFactorial(10) + ".");

app.Run();