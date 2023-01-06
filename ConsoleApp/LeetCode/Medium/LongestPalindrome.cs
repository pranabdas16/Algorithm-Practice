using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindrome
    {
        public string longestPalindrom(string s)
        {
            if (s.Length <= 1)
                return s;

            int max_len = 1;
            int n = s.Length;
            int st = 0, end = 0;

            //odd length
            for (int i = 0; i < n - 1; ++i)
            {
                int l = i, r = i;
                while (l >= 0 && r < n) {
                    if (s[l] == s[r])
                    {
                        l--; r++;
                    }
                    else
                        break;
                }
                int len = r - l - 1;
                if (len > max_len) {
                    max_len = len;
                    st = l + 1;
                    end = r - 1;
                }
            }
            //even length
            for (int i = 0; i < n - 1; ++i)
            {
                int l = i, r = i+1;
                while (l >= 0 && r < n)
                {
                    if (s[l] == s[r])
                    {
                        l--; r++;
                    }
                    else
                        break;
                }
                int len = r - l - 1;
                if (len > max_len)
                {
                    max_len = len;
                    st = l + 1;
                    end = r - 1;
                }
            }
            return s.Substring(st, max_len);
        }
    }
    
}
