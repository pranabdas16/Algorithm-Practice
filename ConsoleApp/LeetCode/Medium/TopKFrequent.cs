using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
   public class TopKFrequent
    {
        public int[] topKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> valueAndFreq = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (valueAndFreq.ContainsKey(nums[i]))
                {
                    int count;
                    valueAndFreq.TryGetValue(nums[i], out count);
                    valueAndFreq[nums[i]] = count + 1;
                }
                else
                {
                    valueAndFreq.Add(nums[i], 1);
                }
            }
            var val = valueAndFreq.OrderByDescending(x => x.Value);
            List<int> resultList = new List<int>();
            int z = 0;
            foreach (var c in val)
            {
                if (z == k)
                {
                    break;
                }
                resultList.Add(c.Key);
                Console.WriteLine(c.Key);
                z++;
            }
            
            return resultList.ToArray();
        }
    }
}
