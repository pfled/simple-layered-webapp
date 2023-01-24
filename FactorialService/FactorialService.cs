using System.Numerics;

namespace Factorial.Services
{
    public class FactorialService
    {
        public static string CalculateFactorial(int n)
        {
            if (n < 0) {
                throw new ArgumentException("It is not possible to find the factorial of a negative integer. Please try again using a positive integer.");
            }
            BigInteger result = 1;
            for (int i = 1; i <= n; i++) {
                result = BigInteger.Multiply(result, i);
            }
            return result.ToString("N0");
        }
    }
}

