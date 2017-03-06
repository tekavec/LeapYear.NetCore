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
            if (value % 4 == 0)
            {
                if (value % 100 == 0)
                {
                    if (value % 400 == 0)
                        return true;
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
