using FluentAssertions;
using Xunit;

namespace LeapYear.NetCore.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void be_a_leap_year_if_divisible_by_4()
        {
            var year = new Year(1996);

            year.IsLeapYear().Should().Be(true);
        }
    }
}
