using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    class ReverseStringleetCode
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-string/
        /// </summary>
        /// <param name="s"></param>
        public void reverseString(char[] s)
        {
            char[] r = new char[(s.Length)];
            int j = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r[j] = s[i];
                j++;
            }
            s = r;
            for (int i = 0; i < s.Length; i++)
            {

                Console.Write(s[i]);
            }
            Console.ReadLine();
        }
    }
}
