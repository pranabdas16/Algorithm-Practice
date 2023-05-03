using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    //https://leetcode.com/problems/valid-palindrome/
    public class IsPalindrome1
    {
        // givenStr = "A man, a plan, a canal: Panama";
        public bool IsPalindrome(string s)
        {
            string givenval;// = s.ToCharArray();
            givenval = covertToChar(s);
            bool val = false;
            char[] givenStrArr = givenval.ToCharArray();
            int length = givenStrArr.Length / 2;

            if (s.Length == 1)
            {
                val = true;
                return val;
            }
            if (givenStrArr.Length == 1)
            {
                val = true;
                return val;
            }
            for (int i = 0, j = givenStrArr.Length - 1; i < length; i++, j--)
            {
                if (givenStrArr[i] == givenStrArr[j])
                    val = true;
                else
                {
                    val = false;
                        return val;
                }
            }

            return val;
        }

        string covertToChar(string s)
        {
            StringBuilder sbStr = new StringBuilder();
            foreach (char c in s.ToLower())
            {
                if (((int)c >= 97 && (int)c <= 122) || (int)c >= 48 && (int)c <= 57)
                {
                    sbStr.Append(c);
                }
            }
            return sbStr.ToString();

        }
    }
}
