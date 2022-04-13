using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class MinSubArrayLength
    {
        /// <summary>
        /// https://leetcode.com/problems/minimum-size-subarray-sum/
        /// </summary>
        /// <param name="target"></param>
        /// <param name="nums"></param>
        /// <returns></returns>   //2, 3, 1, 2, 4, 3
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLencounter = 0, currentCounter=0, val =0;
            List<int> indexList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int k = i;
                val = 0; 
                while (k < nums.Length)
                {
                    val += nums[k];
                    currentCounter++;
                    if (val >= target)
                    {
                        if (minLencounter == 0)
                        {
                            minLencounter = currentCounter;
                        }
                        if (minLencounter > currentCounter)
                        {
                            minLencounter = currentCounter;
                        }
                        break;
                    }
                    k++;
                }
                currentCounter = 0;
            }
            Console.WriteLine($"Minimum length:{minLencounter}");
            return minLencounter;
        }
    }
}
