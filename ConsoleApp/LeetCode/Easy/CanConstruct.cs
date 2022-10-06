using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/ransom-note/
    /// </summary>
    class CanConstruct
    {
        public bool canConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dicMag = new Dictionary<char, int>();
            int counter = 0;
            bool val = false;
            for (int i = 0; i < magazine.Length; i++)
            {
                if (dicMag.ContainsKey(magazine[i]))
                {
                    dicMag[magazine[i]]++;
                }
                else
                {
                    dicMag.Add((magazine[i]), 1);
                }
            }
            foreach(char c in ransomNote)
            {
                int numb = 0;
                dicMag.TryGetValue(c, out numb);
                if ((dicMag.ContainsKey(c)) && numb >= 1)
                {
                    counter++;
                    dicMag[c]--;
                }
                else
                {
                    val = false;
                }
               
            }

            if (counter == ransomNote.Length)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}
