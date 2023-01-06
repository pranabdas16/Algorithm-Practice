using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    public class SearchInsert
    {
        public int searchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (target == nums[i])
                    {
                        Console.WriteLine($"Here is place:{i}");
                        return i;
                    }
                    else if (target < nums[i] && target > nums[i - 1])
                    {
                        Console.WriteLine($"Here is place:{i}");
                        return i;
                    }
                    else if (target > nums[i] && i == nums.Length - 1)
                    {
                        Console.WriteLine($"Here is place:{i+1}");
                        return i + 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Here is place:{0}");
                    return 0;
                }
                //Console.WriteLine("Here is place:{0}");
                //return 0;
            }
            Console.WriteLine("Here is place:{0}");
            return 0;
        }
    }
}
