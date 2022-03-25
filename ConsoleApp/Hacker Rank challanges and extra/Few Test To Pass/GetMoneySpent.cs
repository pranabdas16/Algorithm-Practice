using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/electronics-shop/problem
    /// </summary>
    class GetMoneySpent
    {
        public static int getMoneySpent()//int[] keyboards, int[] drives, int b)
        {
            int[] keyboards = { 3, 1 };
            int[] drives = { 5, 2, 8 };
            int b = 10;
            int maxVal = 0, sum;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    sum = keyboards[i] + drives[j];
                    if (sum > maxVal && b >= sum)
                    {
                        maxVal = sum;
                    }
                }
            }
            if (maxVal > 0)
            {
                Console.WriteLine($"Here is the max sum: {maxVal}");
                return maxVal;
            }
            else
                Console.WriteLine("sum not posible"); return -1;
        }
    }
}
