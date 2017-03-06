using System;

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
            return (value % 4 == 0);
        }
    }
}
