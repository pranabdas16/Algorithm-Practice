using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{

    /// <summary>
    /// Longest Common Prefix
    /// //https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefix
    {
        string Text = "clow, clue, clumsy";

        public string longestCommonPrefix()
        {
            string[] strs = { "clow", "clue", "clumsy" };
            if (strs.Length == 0) return String.Empty;

            var strbuilder = new StringBuilder();
            for (int index = 0; index < strs[0].Length; index++)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (index >= strs[i].Length || strs[i][index] != strs[0][index])
                    {
                        Console.WriteLine(strbuilder.ToString());
                        return strbuilder.ToString();
                    }
                }
                strbuilder.Append(strs[0][index]);
            }
            Console.WriteLine(strbuilder.ToString());
            return strbuilder.ToString();
        }

        public string longestCommonPrefix2()
        {
            string[] strs = { "clow", "clue", "clumsy" };
            if (strs.Length == 0) return String.Empty;
            Array.Sort(strs);

            var first = strs[0];
            var last = strs[strs.Length - 1];
            var strbuilder = new StringBuilder();
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != last[i])
                {
                    break;
                }
                strbuilder.Append(first[i]);
            }
            return strbuilder.ToString();
        }
    }
}
