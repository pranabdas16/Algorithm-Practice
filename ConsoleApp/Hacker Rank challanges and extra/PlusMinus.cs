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
        /// PlusMinus objPlusMinus = new PlusMinus();
        /// objPlusMinus.plusMinus();
        /// </summary>
        public void plusMinus()
        {
            int[] arr = { 1, 1, 1, 0, -1, -1 };
            int n = arr.Length;
            double countPlus = 0, countNegative = 0, countZero = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    countPlus += 1;
                else if (arr[i] < 0)
                    countNegative += 1;
                else if (arr[i] == 0)
                    countZero += 1;
            }

           // double temp = Convert.ToDouble(countPlus);
            double dplus = Math.Round(countPlus / n, 6);//Math.Round(countPlus / (double)50000, 2);
            double dminus = Math.Round(countNegative / n, 6);
            double dZero = Math.Round(countZero / n, 6);
            //double dPlus1 = countPlus / 6;
            Console.WriteLine("Count of Plus:" + countPlus + " Count of Negative: " + countNegative + "  Count of Zero: " + countZero );
            Console.WriteLine(dplus);
            Console.WriteLine(dminus);
            Console.WriteLine(dZero);
            Console.ReadLine();
        }

    }
}
