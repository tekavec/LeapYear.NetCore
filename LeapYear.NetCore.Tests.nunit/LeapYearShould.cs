using FluentAssertions;
using NUnit.Framework;

namespace LeapYear.NetCore.Tests.nunit
{
    [TestFixture]
    public class LeapYearShould
    {
        [TestCase(1996, true)]
        [TestCase(1997, false)]
        [TestCase(1900, false)]
        [TestCase(1600, true)]
        public void be_a_leap_year_if_divisible_by(int value, bool expected)
        {
            var year = new Year(value);

            year.IsLeapYear().Should().Be(expected);
        }
    }
}
