using Factorial.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "The factorial of 100 is " + FactorialService.CalculateFactorial(100) +".");

app.Run();