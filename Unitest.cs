using Xunit;
using Moq;
using CalculatorLibrary;

namespace XUnitTest
{
    public class Unitest
    {
        //Testing interfaces
            [Fact]
            public void CalculatorAddFunctionTest()
        { 
            var calculator = new Mock<ICalculator>();
            calculator.Setup(obj => obj.Add(3, 5)).Returns(8);
            Assert.Equal(8, calculator.Object.Add(3, 5));
        }

        [Fact]
        public void CalculatorSubstractFunctionTest()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(obj => obj.Substract(7, 30)).Returns(23);
            Assert.Equal(23, calculator.Object.Substract(7, 30));
        }

        //Testing a static method
        [Fact]
        public static void CalculatorModFunctionTest()
        {
            int Number1 = 12;
            int Number2 = 55
            var result = Calculator.mod(Number1, Number2);
            Assert.Equal(1, result);

        }

    }
}