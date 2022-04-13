using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class MaxProfit
    {
        /// <summary>
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        /// https://www.youtube.com/watch?v=1pkOgXD63yU
        /// Resolved 208/211
        /// </summary>
        public void stockV2()
        {
            int l = 0, r = 1;
            int MaxP = 0, profit = 0;
            int[] stockPrices = { 3, 2, 6, 5, 0, 3 };

            while (r < stockPrices.Length)
            {
                if (stockPrices[l] < stockPrices[r])
                {
                    profit = stockPrices[r] - stockPrices[l];

                    if (profit > MaxP)
                    {
                        MaxP = profit;
                    }
                    l = r;
                    r++;
                }
                else
                {
                    l = r;
                    r++;
                }

            }
            Console.WriteLine($"Maxium profit is: {MaxP}");
            //return MaxP;
        }
        public void stock2()
        {
            // Stock buy and sell
            // int[] stockPrices = { 7, 1, 5, 3, 6, 4 };//{ 3, 2, 6, 5, 0, 3 };// answer 4//
            //int[] stockPrices = { 3, 2, 6, 5, 0, 3 };//{ 2, 1, 2, 1, 0, 1, 2 };  // 2
                                                     //int[] stockPrices = { 7, 6, 5, 3, 1 };
                                                     //int[] stockPrices = { 2, 4, 1 };
            int[] stockPrices = { 3, 2, 6, 5, 0, 3 };//{ 2, 1, 2, 1, 0, 1, 2 };  // 2
            int highestPrice = 0, lowestPrice = 0;
            int profit = 0, count =0;
            for (int i = 0; i < stockPrices.Length; i++)
            {
                try
                {
                    for (int j = i + 1; i < stockPrices.Length; j++)
                    {
                        if ((stockPrices[i] > stockPrices[j]))
                        {
                            //i = j-1;
                            break;
                        }
                        //if (count == 1)
                        //{
                        //    if (lowestPrice < stockPrices[i] || highestPrice > stockPrices[j])
                        //        break;
                        //}
                        if (stockPrices[i] < stockPrices[j])
                        {
                            //lowestPrice = stockPrices[i];
                            //highestPrice = stockPrices[j];
                            int val = stockPrices[j] - stockPrices[i];
                            if (profit < val)
                            {
                                profit = val;
                               // count++;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            Console.WriteLine($" Here is max Profit: {profit}");

        }

        
    }
}
