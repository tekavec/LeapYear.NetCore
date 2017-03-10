namespace LeapYear.NetCore
{
    public class Year
    {
        private readonly int value;

        public Year(int value)
        {
            this.value = value;
        }

        public bool IsLeapYear()
        {
            return IsDivisibleBy(4) && (!IsDivisibleBy(100) || IsDivisibleBy(400));
        }

        private bool IsDivisibleBy(int divisor)
        {
            return value % divisor == 0;
        }
    }
}
