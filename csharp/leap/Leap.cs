namespace Leap
{
    public static class Leap
    {
        /// <summary>
        /// There is a leap year on every year that is evenly divisible by 4.
        /// Except every year that is evenly divisible by 100.
        /// Unless the year is also evenly divisible by 400.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>If the provided year is a leap year.</returns>
        public static bool IsLeapYear(int year)
        {
            var isDivisibleBy4 = year % 4 == 0;
            var isDivisibleBy100 = year % 100 == 0;
            var isDivisibleBy400 = year % 400 == 0;

            return isDivisibleBy4 && (!isDivisibleBy100 || isDivisibleBy400);
        }
    }
}