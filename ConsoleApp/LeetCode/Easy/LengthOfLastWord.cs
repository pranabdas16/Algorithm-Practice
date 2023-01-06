using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    public class LengthOfLastWord
    {
        /// <summary>
        /// https://leetcode.com/problems/length-of-last-word/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int lengthOfLastWord(string s)
        {
            int lgth = s.Length;
            string str = "";
            string sb = null;
            List<string> sList = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    str = s[i].ToString();
                    if (str != " ")
                    {
                        sb = sb + str;
                        //sList.Add(str);
                    }
                    else
                    {
                        if (sb != null)
                        {
                            sList.Add(sb.ToString());
                            sb = null;
                        }
                    }
                    if (i == s.Length - 1)
                    {
                        sList.Add(sb.ToString());
                        sb = null;
                    }
                }
                catch
                { }
            }
            lgth = sList.Count - 1;
            string str1 = sList[lgth].ToString();
            int count = str1.Length;
            return count;
        }
    }
}
