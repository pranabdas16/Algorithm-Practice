using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
   public class LongestPalindrome
    {
        public string longestPalindrome(string s)
        {
            string str = s;
            for (int i = 0; i < str.Length; i++)
            {
                isPalindrome(s);
            }
            return str;
        }

        bool isPalindrome(string s)
        {
            string gvnStr = s;
            bool result = false;
            int n = s.Length - 1;
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (gvnStr[1] == gvnStr[n])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }

    }
}
