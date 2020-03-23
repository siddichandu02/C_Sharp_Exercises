using Moq;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Calculator;

namespace TDD.xUnit.net.Client
{
   
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            var calculator = new FakeCalculator();
            Assert.Equal(5, calculator.Add(2, 3));
        }

        [Fact]
        public void MultiplyTest()
        {
            var calculator = new Mock<FakeCalculator>();
            calculator.Setup(x => x.Multiply(2, 3)).Returns(6);
            Assert.Equal(6, calculator.Object.Multiply(2, 3));
        }
        [Fact]
        public void AddTest1()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));

        }
    }
}
