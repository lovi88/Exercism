// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

namespace Leap
{
    public class LeapTest
    {
        [Fact]
        public void Year_not_divisible_by_4_is_common_year()
        {
            Assert.False(global::Leap.Leap.IsLeapYear(2015));
        }

        [Fact]
        public void Year_divisible_by_4_not_divisible_by_100_is_leap_year()
        {
            Assert.True(global::Leap.Leap.IsLeapYear(2016));
        }

        [Fact]
        public void Year_divisible_by_100_not_divisible_by_400_is_common_year()
        {
            Assert.False(global::Leap.Leap.IsLeapYear(2100));
        }

        [Fact]
        public void Year_divisible_by_400_is_leap_year()
        {
            Assert.True(global::Leap.Leap.IsLeapYear(2000));
        }
    }
}