using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/description/
    /// </summary>
    public class MySqrt
    {
        public int mySqrt(int x)
        {
            if (x < 2) return x;

            long num;
            int pivot, left = 2, right = x / 2;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                num = (long)pivot * pivot;
                if (num > x) right = pivot - 1;
                else if (num < x) left = pivot + 1;
                else {
                    Console.WriteLine($"Here is the SQRT val: {pivot}");
                    return pivot; 
                }
            }
            Console.WriteLine($"Here is the SQRT val: {right}");
            return right;
        }

        public int mySqrt1(int x)
        {
            if (x < 2) return x;

            int left = mySqrt1(x >> 2) << 1;
            int right = left + 1;
            return (long)right * right > x ? left : right;
        }
    }
}
