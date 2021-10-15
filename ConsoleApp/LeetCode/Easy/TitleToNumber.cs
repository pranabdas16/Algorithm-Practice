using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/excel-sheet-column-number/
    /// </summary>
    class TitleToNumber
    {
        public int titleToNumber(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result *= 26;
                result += s[i] - 'A' + 1;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
