using Factorial.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "The factorial of 18 is " + FactorialService.CalculateFactorial(18) +".");

app.Run();