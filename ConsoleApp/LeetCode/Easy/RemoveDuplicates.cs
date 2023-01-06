using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class RemoveDuplicates
    {
        public int removeDuplicates(int[] nums)
        {
            List<int> numList = nums.ToList();
            for (int i = 0; i < numList.Count; i++)
            {
                try
                {
                    if (numList[i] == numList[i + 1])
                    {
                        numList.RemoveAt(i + 1);
                        i--;
                    }
                }
                catch
                { }
             }
            nums = numList.ToArray();
            return nums.Length;
        }

        public int removeDuplicates1(int[] nums)
        {
            List<int> numList = nums.ToList();
            for (int i = 1; i < numList.Count; i++)
            {
                    if (numList[i] == numList[i - 1])
                    {
                        numList.RemoveAt(i);
                        i--;
                    }
            }
            nums = numList.ToArray();
            return nums.Length;
        }

        public int removeDuplicates2(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j++] = nums[i];
                }
            }
            Array.Resize(ref nums, j);
            return nums.Length;
        }
    }
}
