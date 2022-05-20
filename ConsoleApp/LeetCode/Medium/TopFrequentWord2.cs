using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-words/
    /// took the reference of another code...
    /// </summary>
    public class TopFrequentWord2
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var list = new Dictionary<string, int>();
            var ans = new List<Pair>();
            foreach (var w in words)
            {
                if (!list.ContainsKey(w))
                {
                    list.Add(w, 1);
                }
                else
                {
                    list[w]++;
                }
            }

            foreach (var l in list)
            {
                ans.Add(new Pair(l.Key, l.Value));
            }

            ans.Sort(new PairCompare());
            var final = new List<string>();
            for (int i = 0; i < k; i++)
            {
                final.Add(ans[i].word);
            }
            return final;
        }
        public class Pair
        {
            public string word;
            public int freq;
            public Pair(string w, int f)
            {
                word = w;
                freq = f;
            }
        }

        public class PairCompare : IComparer<Pair>
        {
            public int Compare(Pair x, Pair y)
            {
                int f1 = x.freq;
                int f2 = y.freq;

                string w1 = x.word;
                string w2 = y.word;

                if (f1 != f2)
                {
                    return f2 - f1;
                }
                else
                {
                    return string.Compare(w1, w2);
                }
            }

        }
    }
}
