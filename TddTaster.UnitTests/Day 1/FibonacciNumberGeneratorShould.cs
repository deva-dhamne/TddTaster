using TddTaster.Core.Day1;
using FluentAssertions;

namespace TddTaster.UnitTests.Day1
{
    public class FibonacciNumberGeneratorShould
    {
        [Fact]
        public void Return0_WhenRequestedPosition_Is0()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(0);

            generatedNumber.Should().Be(0);
        }

        [Fact]
        public void Return1_WhenRequestedPosition_Is1()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(1);

            generatedNumber.Should().Be(1);
        }

        [Fact]
        public void Return1_WhenRequestedPosition_Is2()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(2);

            generatedNumber.Should().Be(1);
        }

        [Fact]
        public void Return2_WhenRequestedPosition_Is3()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(3);

            generatedNumber.Should().Be(2);
        }

        [Fact]
        public void Return3_WhenRequestedPosition_Is4()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(4);

            generatedNumber.Should().Be(3);
        }

        [Fact]
        public void Return5_WhenRequestedPosition_Is5()
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(5);

            generatedNumber.Should().Be(5);
        }

        [Theory]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        [InlineData(11, 89)]
        public void ReturnexpectedNumber_ForRequestedPosition(int postion, int expectedNumber)
        {
            var generatedNumber = FibonacciNumberGenerator.GetNumberFor(postion);

            generatedNumber.Should().Be(expectedNumber);
        }
    }

}