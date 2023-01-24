using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element
    /// </summary>
    public class MajorityElement
    {
        public int Majorityelement(int[] nums)
        {
            Dictionary<int, int> numsDic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsDic.ContainsKey(nums[i]))
                {
                    numsDic.Add(nums[i], 1);
                }
                else
                {
                    numsDic[nums[i]]++;
                }
            }
            int val = 0, ansVal;
            foreach (var c in numsDic)
            {
                if (val < c.Value)
                {
                    val = c.Value;
                    ansVal = c.Key;
                }

            }
            //Console.WriteLine($"Majority Element value: {ansVal}");
            return val;
        }

    }
}
