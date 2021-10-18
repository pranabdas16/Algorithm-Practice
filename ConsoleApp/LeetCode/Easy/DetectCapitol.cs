using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    class DetectCapitol
    {
        /// <summary>
        /// https://leetcode.com/problems/detect-capital/
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool detectCapitol(string word)
        {
            int strLngth = word.Length;
            int countUp = 0;
            int countLow = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    countUp++;
                }
                else
                {
                    countLow++;
                }
            }
            if (countUp == strLngth)
            {
                return true;
            }
            else if (countUp == 1 && char.IsUpper(word[0]))
            {
                return true;
            }
            else if (countLow == strLngth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
