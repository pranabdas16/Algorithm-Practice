using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class PlusMinus
    {
        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
        /// 
        /// </summary>
        public void plusMinus()
        {
            int[] arr = { 1, 1, 0, -1, -1 };
            int n = arr.Length;
            int countPlus = 0, countNegative = 0, countZero = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    countPlus += 1;
                else if (arr[i] < 0)
                    countNegative += 1;
                else if (arr[i] == 0)
                    countZero += 1;
            }

            Decimal dplus = countPlus / 5;
            Console.WriteLine("Count of Plus:" + countPlus + " Count of Negative: " + countNegative + "  Count of Zero: " + countZero );
            Console.WriteLine(dplus);
            Console.ReadLine();
        }

    }
}
