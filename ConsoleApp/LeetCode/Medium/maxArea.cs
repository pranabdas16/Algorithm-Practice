using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
   public class maxArea
    {
        public int MaxArea(int[] height)
        {
            //height = { 1, 8, 6, 2, 5, 4, 8, 3, 7};
            int max = 0;
            int lftPntr = 0; //left pointer
            int rghtPntr = height.Length - 1; // right pointer
            while (lftPntr < rghtPntr)
            {
                int currentArea = Math.Min(height[lftPntr], height[rghtPntr]) * (rghtPntr - lftPntr);

                max = Math.Max(max, currentArea);

                if (height[lftPntr] < height[rghtPntr])
                    lftPntr++;
                else
                    rghtPntr--;
            
            }
            return max;
        }
    }
}
