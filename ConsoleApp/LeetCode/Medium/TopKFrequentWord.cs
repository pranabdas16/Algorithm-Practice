using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-words/
    /// </summary>
    public class TopKFrequentWord
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            IList<string> resultList = new List<string>();
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (wordDict.ContainsKey(words[i]))
                {
                    int count;
                    wordDict.TryGetValue(words[i],out count);
                    wordDict[words[i]] = count + 1;
                }
                else
                {
                    wordDict.Add(words[i], 1);
                }
            }

            var wordListDic = wordDict.OrderByDescending(x => x.Value);
            List<string> wordListvalue = new List<string>();
            foreach (var wrd in wordListDic)
            {
                wordListvalue.Add(wrd.Key);
            }

            for (int i = 0; i < k; i++)
            {
                resultList.Add(wordListvalue[i]);
                Console.Write(wordListvalue[i]);
            }
            return resultList;
        }
    }
}
