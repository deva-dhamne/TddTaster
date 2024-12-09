using TddTaster.Core.Day1;

namespace TddTaster.UnitTests.Day1
{
    public class LeapYearCalculatorShould
    {
        [Theory]
        [InlineData(2024)]
        [InlineData(2020)]
        [InlineData(2028)]
        public void ReturnTrue_WhenYearIsDivisibleBy4(int year)
        {
            var isLeapYear = LeapYearCalculator.IsLeapYear(year);

            Assert.True(isLeapYear);
        }

        [Theory]
        [InlineData(1998)]
        [InlineData(2017)]
        [InlineData(2026)]
        public void ReturnFalse_WhenYearIs_NotDivisibleBy4(int year)
        {
            var isLeapYear = LeapYearCalculator.IsLeapYear(year);

            Assert.False(isLeapYear);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void ReturnFalse_WhenYearIs_DivisibleBy4And100_ButNotBy400(int year)
        {
            var isLeapYear = LeapYearCalculator.IsLeapYear(year);

            Assert.False(isLeapYear);
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(4000)]
        [InlineData(6000)]
        public void ReturnTrue_WhenYearIs_DivisibleBy4And100_ButAlsoBy400(int year)
        {
            var isLeapYear = LeapYearCalculator.IsLeapYear(year);

            Assert.True(isLeapYear);
        }
    }
}
