using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-two-integers/description/
    /// </summary>
    public class GetSum
    {
        public int getSum1(int a, int b)
        {
            int x = Math.Abs(a), y = Math.Abs(b);
            // ensure that abs(a) >= abs(b)
            if (x < y) return getSum1(b, a);

            // abs(a) >= abs(b) --> 
            // a determines the sign
            int sign = a > 0 ? 1 : -1;

            if (a * b >= 0)
            {
                // sum of two positive integers x + y
                // where x > y
                while (y != 0)
                {
                    int answer = x ^ y;
                    int carry = (x & y) << 1;
                    x = answer;
                    y = carry;
                }
                // TODO  
            }
            else
            {
                // difference of two positive integers x - y
                // where x > y
                while (y != 0)
                {
                    int answer = x ^ y;
                    int borrow = ((~x) & y) << 1;
                    x = answer;
                    y = borrow;
                }
                // TODO  
            }
            return x * sign;
        }

        public int getSum2(int a, int b)
        {
            while (b != 0)
            {
                int answer = a ^ b;
                int carry = (a & b) << 1;
                a = answer;
                b = carry;
            }

            return a;
        }
    }
}
