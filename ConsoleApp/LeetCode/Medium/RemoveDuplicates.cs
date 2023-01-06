using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/
    /// </summary>
    public class RemoveDuplicates1
    {
        //{1, 1, 1, 2, 2, 3}
        //{1, 1, 2, 2, 3, _ , }
        public int removeDuplicates(int[] nums)
        {
            int counter = 0,j=0, temp, val=0;
            for (int i = 0; i < nums.Length; i++)
            {
                //int j;
                j = i + 1;
                while (j < nums.Length)
                {
                    if (nums[i] == nums[j])
                    {
                        if (counter > 0)
                        {
                            nums[j] = -95;
                            val++;
                        }
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }
                    j++;
                }
                i = j - 1;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                j = i + 1;
                if (nums[i] == -95)
                {
                    while (nums[j] == -95 && j < nums.Length)
                    {
                        j++;
                        if (j == nums.Length)
                            break;
                    }
                    if (j < nums.Length)
                    {
                        temp = nums[j];
                        nums[i] = temp;
                        nums[j] = -95;
                    }
                }
            }
            int num1 = nums.Length -val;
            return 0;
        }
    }
}
