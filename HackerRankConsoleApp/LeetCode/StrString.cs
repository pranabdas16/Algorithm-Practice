using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class StrString
    {
        public int StrStr1(string haystack, string needle)
        {
            int counter = 0, index = -1;
            for (int i = 0; i < needle.Length; i++)
            {
                for (int j = 0; j < haystack.Length; j++)
                {
                    if ((needle[i] == haystack[j]) )
                    {
                        Console.WriteLine($"here is the index: {j}");
                        return j;
                    }
                    else
                    {
                        continue;
                        //break;
                    }
                }
                break;
            }
            Console.WriteLine($"here is the index: -1");
            return -1;
        }

        public int StrStr(string haystack, string needle)
        {
            int len1 = haystack.Length;
            int len2 = needle.Length;

            for (int i = 0; i <= len1 - len2; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (haystack[i + j] == needle[j])
                    {
                        if (j == len2 - 1)
                            return i;
                    }
                    else
                        break;
                }
            }

            return -1;
        }
    }
}
