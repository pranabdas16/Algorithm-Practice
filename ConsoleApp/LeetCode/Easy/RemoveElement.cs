using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
   public class RemoveElement
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-element/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int removeElement(int[] nums, int val)
        {
            List<int> resltnums = new List<int>();
            resltnums = nums.ToList();
            int count = 0, resultval;
            for (int i = 0; i < resltnums.Count; i++)
            {
                if (resltnums[i] == val)
                {
                    resltnums.RemoveAt(i);
                    i--;
                    count++;
                }
            }
            List<int> seconndList = new List<int>();
            for (int i = 0; i < resltnums.Count; i++)
            {
                int val1 = resltnums[i];
                seconndList.Add(val1);
            }
            // for (int i = 0; i < count; i++)
            // {
            //     seconndList.Add('_');
            // }
            int[] nums1 = resltnums.ToArray();
            resultval = resltnums.Count;
            return resultval;
        }
        public int removeElement1(int[] nums, int val)
        {
            int j = nums.Length-1, temp, counter =0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = -1;
                    //j--;
                    counter++;
                }
            }
            for (int i = 0; i < nums.Length-1; i++)
            {
                j = i + 1;
               if (nums[i] == -1)
                 {
                    while (nums[j] == -1 && j < nums.Length)
                    {
                        j++;
                        if (j == nums.Length)
                            break;
                    }
                    if (j < nums.Length)
                    {
                        temp = nums[j];
                        nums[i] = temp;
                        nums[j] = -1;
                    }
                 }
            }

            
            return nums.Length-counter;
        }
   }
}
