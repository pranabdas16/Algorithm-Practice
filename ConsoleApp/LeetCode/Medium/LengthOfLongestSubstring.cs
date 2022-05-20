using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
   public class LengthOfLongestSubstring
    {
        public int lengthOfLongestSubstring(string s)
        {
           
            Dictionary<char, int> longstSubStrDic = new Dictionary<char, int>();
            int maxCount = 0, previousIndex;
            for (int i = 0; i < s.Length; i++)
            {
                if (longstSubStrDic.ContainsKey(s[i]))
                {
                    //int outVal;
                    //longstSubStrDic.TryGetValue(s[i], out outVal);
                    //longstSubStrDic[s[i]] = outVal + 1;
                    if (longstSubStrDic.Count > maxCount)
                    {
                        maxCount = longstSubStrDic.Count;
                    }
                    longstSubStrDic.Clear();
                    //int index = longstSubStrDic.ElementAt(s[i]).Value;
                    if (i == s.Length - 1)
                    {
                        longstSubStrDic.Add(s[i], 1);
                        break;
                    }
                    if (s[i] == s[i - 1])
                    {
                        i--;
                    }
                    //else if (s[i] != s[i - 1])
                    //{
                    //    i--;
                    //}
                    else
                    {
                        int index = s.IndexOf(s[i]);
                        // i = index+1;
                        i = index;
                        if (i == 0)
                        { //i;
                        }
                        else
                            i--;
                    }
                    
                }
                else
                {
                    longstSubStrDic.Add(s[i], 1);
                }
                
            }
            if (longstSubStrDic.Count > maxCount)
            {
                maxCount = longstSubStrDic.Count;
            }
            //foreach (var charVal in longstSubStrDic)
            //{
            //    if (charVal.Value > 1)
            //    {
            //        longstSubStrDic.Remove(charVal.Key);
            //    }

            //}
            // return longstSubStrDic.Count;
            Console.WriteLine($"Here is the MaxCount: {maxCount}");
            return maxCount;
        }
    }
}
