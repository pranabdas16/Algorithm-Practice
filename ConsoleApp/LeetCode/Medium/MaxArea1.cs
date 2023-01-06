using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    public class MaxArea1
    {
        //height = { 1, 8, 6, 2, 5, 4, 8, 3, 7};
        public int maxArea(int[] height)
        {
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int currentArea = Math.Min(height[i], height[j])* (j-i);

                    max = Math.Max(max, currentArea);
                }
            }

            return max;
        }
    }
}
