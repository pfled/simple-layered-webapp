using Xunit;
using Factorial.Services;
using System.Numerics;

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
            BigInteger expectedResult = 1;
            Assert.Equal(expectedResult, FactorialService.CalculateFactorial(0));
        }

        [Fact] // Test for 1
        public void TestCalculateFactorial_Input1()
        {
            BigInteger expectedResult = 1;
            Assert.Equal(expectedResult, FactorialService.CalculateFactorial(1));
        }

        [Fact] // Test a small number
        public void TestCalculateFactorial_Input3()
        {
            BigInteger expectedResult = 6;
            Assert.Equal(expectedResult, FactorialService.CalculateFactorial(3));
        }

        [Fact] // Test a large number
        public void TestCalculateFactorial_Input10()
        {
            BigInteger expectedResult = 3628800;
            Assert.Equal(expectedResult, FactorialService.CalculateFactorial(10));
        }

        [Fact] // Test a very large number
        public void TestCalculateFactorial_Input100()
        {
            BigInteger expectedResult = BigInteger.Parse("93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000");
            Assert.Equal(expectedResult, FactorialService.CalculateFactorial(100));
        }
    }
}