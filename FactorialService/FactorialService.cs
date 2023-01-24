namespace Factorial.Services
{
    public class FactorialService
    {
        public static double CalculateFactorial(int n)
        {
            if (n < 0) {
                throw new ArgumentException("It is not possible to find the factorial of a negative integer. Please try again using a positive integer.");
            }
            double result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i;
            }
            return result;
        }
    }
}

