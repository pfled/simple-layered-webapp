using Xunit;
using Factorial.Services;

namespace Factorial.UnitTests.Services
{
    public class FactorialService_CalcFact
    {
        [Fact] // Test for negative integer (invalid input)
        public void TestCalculateFactorial_InputNegative()
        {
            Assert.Throws<ArgumentException>(() => FactorialService.CalculateFactorial(-1));
        }

        [Fact] // Test for 0
        public void TestCalculateFactorial_Input0()
        {
            Assert.Equal(1, FactorialService.CalculateFactorial(0));
        }

        [Fact] // Test for 1
        public void TestCalculateFactorial_Input1()
        {
            Assert.Equal(1, FactorialService.CalculateFactorial(1));
        }

        [Fact] // Test a small number
        public void TestCalculateFactorial_Input3()
        {
            Assert.Equal(6, FactorialService.CalculateFactorial(3));
        }

        [Fact] // Test a large number
        public void TestCalculateFactorial_Input10()
        {
            Assert.Equal(3628800, FactorialService.CalculateFactorial(10));
        }

        [Fact] // Test a very large number (scientific notation required)
        public void TestCalculateFactorial_Input100()
        {
            Assert.Equal(9.33262154439441E+157, FactorialService.CalculateFactorial(100));
        }
    }
}