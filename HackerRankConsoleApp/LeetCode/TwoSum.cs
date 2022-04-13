using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        public int [] twoSum(int[] nums, int target)
        {
            int[] returnIndices = new int[2]; int k = 0;
            while (k < nums.Length - 1)
            {
                for (int i = k + 1; i < nums.Length; i++)
                {
                    if ((nums[k] + nums[i]) == target)
                    {
                        returnIndices[0] = k;
                        returnIndices[1] = i;
                        Console.WriteLine($"[{k}, {i}]");
                        return returnIndices;
                    }
                }
                k++;
            }
            return returnIndices;

        }
    }
}
