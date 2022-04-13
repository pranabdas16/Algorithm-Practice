using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class FirstUniqChar
    {
        public int firstUniqchar(string s)
        {
            int index = -1;
            Dictionary<char, int> charWithCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charWithCount.ContainsKey(s[i]))
                {
                    charWithCount[s[i]]++;
                }
                else
                {
                    charWithCount.Add(s[i], 1);
                }
            }

            var firstNonUnique = charWithCount.Where(x => x.Value == 1).FirstOrDefault();//.ToString();
            char uniqueChar = firstNonUnique.Key;
            for (int i =0; i< s.Length; i++ )
            {
                if (s[i] == uniqueChar)
                {
                    index = i;
                }
            }
            
            return index;
        }

        public int firstUniqChar1(string s)  ///aabbc
        {
            int result=0, index=0;
            char val=' ';

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    if (i == 0)
                    {
                        result = -1;
                        Console.WriteLine($"first unique char: {result}");
                        return result;
                    }
                    else
                    {
                        val = s[i];
                        index = i;
                        break;
                    }
                }
            }
            for (int k = 0; k <= index; k++)
            {
                if (val == s[k])
                {
                    if (k < index)
                        result = --k;
                    else
                        result = --index;

                    Console.WriteLine($"first unique char: {result}");
                    return result;
                }
            }
            //Console.WriteLine($"first unique char: {result}");
            return 0;
        }
    }
}
