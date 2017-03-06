using FluentAssertions;
using Xunit;

namespace LeapYear.NetCore.Tests
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(1996, true)]
        [InlineData(1997, false)]
        public void be_a_leap_year_if_divisible_by_4(int value, bool expected)
        {
            var year = new Year(value);

            year.IsLeapYear().Should().Be(expected);
        }
    }
}
