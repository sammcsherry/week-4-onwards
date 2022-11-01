using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_week_4
{
    public static class Mathematic_Functions
    {
        public static bool check_if_power_of_2(int number)
        {
            if (number == 2)
                return true;
            else if (number % 2 == 0)
            {
                return check_if_power_of_2(number / 2);
            }
            else
                return false;
        }

        public static Complex_Number i()
        {
            return new Complex_Number(0, 1);
        }
    }
}
