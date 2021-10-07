using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Walbreak
{
    /// <summary>
    /// 
    /// https://leetcode.com/problems/sort-array-by-parity/
    /// Following code can directly through program just have to uncomment the method name...
    /// </summary>
    class SortArrayByParity
    {
        int[] nums1 = { 3, 1, 2, 4 };
        //sortArrayByParity(nums1);

        public int[] sortArrayByParity(int[] nums)
        {
            int[] reultArray = new int[nums.Length];
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    reultArray[k] = nums[i];

                    k++;
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] % 2 == 1)
                {
                    reultArray[k] = nums[j];

                    k++;
                }
            }

            Console.WriteLine(string.Join(",", reultArray));
            return reultArray;
        }
    }
}
