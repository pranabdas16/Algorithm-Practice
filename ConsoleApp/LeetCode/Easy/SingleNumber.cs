using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    public class SingleNumber
    {
        public int singleNumber(int[] nums)
        {
            Dictionary<int, int> numsdic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsdic.ContainsKey(nums[i]))
                {
                    numsdic[nums[i]]++;
                }
                else
                {
                    numsdic.Add(nums[i], 1);
                }
            }
            int val = numsdic.SingleOrDefault(x => x.Value == 1).Key;
            return val;
        }
    }
}
