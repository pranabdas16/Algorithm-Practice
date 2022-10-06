using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    //https://leetcode.com/problems/sign-of-the-product-of-an-array/
    class ArraySign
    {
        public int arraySign(int[] nums)
        {
            int negativeCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    negativeCount++;

                if (nums[i] == 0)
                {
                    Console.WriteLine("It is : 0");
                    return 0;
                }
            }

            if (negativeCount % 2 == 0)
            {
                Console.WriteLine("It is : 1");
                return 1;
            }
            else
            {
                Console.WriteLine("It is : -1");
                return -1;
            }
        }
    }
}
