using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    public class LengthOfLongestSubstring1
    {
        //"abcabcbb";////"pwwkew";////"pwwkew";"aab";//"dvdf";
        public int LengthOfLongestSubstring(string s)
        {
            int maxCount = 0;
            Dictionary<char, int> subStringDic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (subStringDic.ContainsKey(s[j]))
                    {
                        if (maxCount < subStringDic.Count)
                            maxCount = subStringDic.Count;

                        subStringDic.Clear();
                        break;
                        //int outval;
                        //subStringDic.TryGetValue(s[i],out outval);
                        //subStringDic[s[i]] = outval + 1;
                    }
                    else
                    {
                        subStringDic.Add(s[j], 1);
                    }
                }
                if (maxCount < subStringDic.Count)
                    maxCount = subStringDic.Count;
            }
            Console.WriteLine($"Here is the MaxCount: {maxCount}");
            return maxCount;
        }
    }
}
