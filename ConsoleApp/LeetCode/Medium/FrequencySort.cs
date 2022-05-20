using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/sort-characters-by-frequency/
    /// 
    /// </summary>
    public class FrequencySort
    {
        public string frequencySort(string s)
        {
            string str = s;
            string final = "";
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            StringBuilder ResultStr = new StringBuilder();
            //Add to the charCount dictionary, updated the value as counter if same value....
            foreach (char c in str)
            {
                if (charCounter.ContainsKey(c))
                {
                    int count;
                    charCounter.TryGetValue(c, out count);
                    charCounter[c] = count + 1;
                }
                else
                {
                    charCounter.Add(c, 1);
                }

            }
            //order in decreasing manner add in a string…
            var slist = charCounter.OrderByDescending(x => x.Value);
            //Add to string builder by foreach loop..
            foreach (var l in slist)
            {
                int counter = l.Value;
                while (counter > 0)
                {
                    ResultStr.Append(l.Key);
                    counter--;
                }
            }
            return ResultStr.ToString();
        }
    }
}
