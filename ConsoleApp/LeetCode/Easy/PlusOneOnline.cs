using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    class PlusOneOnline
    {
        /// <summary>
        /// https://leetcode.com/problems/plus-one/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            var stack = new Stack<int>();
            int carry = 1;
            int _base = 10;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                stack.Push((digits[i] + carry) % _base);
                carry = (digits[i] + carry) / _base;
            }
            if (carry == 1)
                stack.Push(carry);
            return stack.ToArray();
        }
    }
}
