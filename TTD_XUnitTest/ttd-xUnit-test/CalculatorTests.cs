using Calculator;
using System;
using Xunit;

namespace ttd_xUnit_test
{
    public class CalculatorTests
    {
        [Fact]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert   
            Assert.Equal(104000, annualSalary);
        }

        [Fact]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert   
            Assert.NotEqual(15, hourlyWage);
        }
        [Theory]
        [InlineData(15,31200)]
        [InlineData(125,260000)]
        [InlineData(48,99840)]
        [InlineData(19,39520)]
        [InlineData(27,56160)]
        [InlineData(36,74880)]
        [InlineData(100,208000)]
        public void AnnualSalaryTests(decimal hourlyWage,decimal expected)
        {
            SalaryCalculator sc = new SalaryCalculator();
            Assert.Equal(expected, sc.GetAnnualSalary(hourlyWage));
        }

    }
}
