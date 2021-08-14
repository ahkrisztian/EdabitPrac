using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.Schwer
{
    public static class LeastCommonMultiple
    {
        //Create a function that takes an array of more than three numbers and returns the Least Common Multiple (LCM).

        //LcmOfArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) ➞ 2520
        //LcmOfArray(new int[] { 13, 6, 17, 18, 19, 20, 37 }) ➞ 27965340
        //LcmOfArray(new int[] { 44, 64, 12, 17, 65 }) ➞ 2333760

        public static string LCM(params int[] integers)
        {
            int defaultvalue = 0;
            var maxInteger = integers.Max();

            for (int multiple = maxInteger; multiple < multiple+1; multiple++)
            {
                var IsMultiple = true;

                foreach (var intiger in integers)
                {
                    if (multiple % intiger != 0)
                    {
                        IsMultiple = false;
                    }
                }
                if (IsMultiple)
                {
                   return $"The Least Common Multiple of {String.Join(",", integers)} is {multiple}";
                }
            }

            return $"{defaultvalue}";

        }

    }
    
}
