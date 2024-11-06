using FluentAssertions;
using TddTaster.Core.Day_2;

namespace TddTaster.UnitTests.Day_2
{
    public class StringCalculatorShould
    {
        [Theory]
        [InlineData(null)]
        public void ThrowException_WhenNumbersIsNull(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }

        [Fact]
        public void ReturnZero_WhenNumbersAreEmpty()
        {
            var addition = StringCalculator.Add(string.Empty);

            addition.Should().Be(0);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("9", 9)]
        public void ReturnNumber_WhenSingleNumberInNumbers(string numbers, int expectedAddition)
        {
            var addition = StringCalculator.Add(numbers);

            addition.Should().Be(expectedAddition);
        }

        [Theory]
        [InlineData("0,1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("8,9", 17)]
        [InlineData("0,5,9", 14)]
        [InlineData("0,7,8,9", 24)]
        [InlineData("0,1,2,3,4", 10)]
        public void ReturnSumGivenMoreThanOneNumberSplitByCommas(string numbers, int expectedAddition)
        {
            var addition = StringCalculator.Add(numbers);

            addition.Should().Be(expectedAddition);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("1,-2")]
        [InlineData("-1,-2")]
        [InlineData("1\n-2")]
        [InlineData("-2\n1")]
        [InlineData("//.\n-1.2.-3")]
        public void ThrowException_WhenNegativeNumberInNumbers(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }

        [Theory]
        [InlineData("//.\n1.2", 3)]
        [InlineData("///\n1/2", 3)]
        [InlineData("//x\n1x2", 3)]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//.\n1.2,3", 6)]
        public void ReturnAddition_WhenMultipleNumbers_SplitByCustomDelimiter(string numbers, int expected)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expected);
        }
    }

    
}
