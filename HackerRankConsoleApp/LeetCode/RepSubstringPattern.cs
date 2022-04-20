using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class RepSubstringPattern
    {
        /// <summary>
        /// https://leetcode.com/problems/repeated-substring-pattern/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RepeatedSubstringPattern(string s)
            {
                int n = s.Length;
                if (n <= 1)
                    return false;
                for (int i = n / 2; i > 1; i--)
                {
                    if (n % i == 0)
                    {
                        if (checkSubString(s, i))
                            return true;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (s[i] != s[0])
                        return false;
                }
                return true;
            }
            public bool checkSubString(string s, int index)
            {
                int range = s.Length / index;
                for (int i = 0; i < range; i++)
                {
                    char currVal = s[i];
                    for (int j = range; j < s.Length; j += range)
                    {
                        if (s[i + j] != currVal)
                            return false;
                    }
                }
                return true;
            }
        
        public bool RepeatedSubstringPattern1(string s)
        {
            Dictionary<char, int> uniqueChar = new Dictionary<char, int>();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    uniqueChar.Add(s[i], i);
                }
                catch
                {
                    break;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length == 1)
                   return true;
                if (s[i] == uniqueChar.ElementAt(j).Key)
                {
                    if ((i == s.Length - 1) && j == uniqueChar.Count - 1)
                    {
                        Console.WriteLine("This is Ture:");
                        return true;
                    }
                    if (j < uniqueChar.Count-1)
                        j++;
                    else if (j >= uniqueChar.Count - 1)
                        j = 0;               
                }
                else
                {
                    Console.WriteLine("This is false");
                    return false;
                }
               
                 if ((i == s.Length - 1) && j != uniqueChar.Count - 1)
                {
                    Console.WriteLine("This is false:");
                    return false;
                }

            }
            Console.WriteLine("This is false");
            return false;
        }
    }
}
