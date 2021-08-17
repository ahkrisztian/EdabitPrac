using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    //Write a function that calculates overtime and pay associated with overtime.
    //Working 9 to 5: regular hours
    //After 5pm is overtime
    //Your function gets an array with 4 values:
    //Start of working day, in decimal format, (24 - hour day notation)
    //End of working day. (Same format
    //Hourly rate
    //Overtime multiplier
    //Your function should spit out:
    //$ + earned that day(rounded to the nearest hundreth)

    //OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

    //OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

    //OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
    //edabit - mqqqqqx

    public static class Working

    {
        public static double Overtime(double[] arr)
        {
            if(arr[1] <= 17)
            {

                double WithoutOverTime = (arr[1] - arr[0]) * arr[2];

                return WithoutOverTime;
            }


            double WithOvertime = (17 - arr[0]) * arr[2] + ((arr[1] - 17) * (arr[3]*arr[2]));

            return WithOvertime;
        }
    }
}
