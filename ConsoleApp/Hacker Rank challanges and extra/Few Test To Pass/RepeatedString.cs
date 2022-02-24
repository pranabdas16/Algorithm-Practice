using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string/problem
    /// </summary>
    public class RepeatedString
    {
        public long repeatedString(string s, long n)
        {
            /*88888888888888888888888888888888888888888888888888888888888
             Third Approach
             88888888888888888888888888888888888888888888888888888888888*/
            if (s.Length == 0)
            {
                return 0;
            }
            if (s.Length == 1 && s[0] == 'a')
            {
                return n;
            }

            long quot, rem;
            quot = n / s.Length;
            rem = n % s.Length;
            string newStr = string.Empty;
            long countA = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    countA++;
                }
            }

            countA *= quot;

            for (int i = 0; i < rem; i++)
            {
                if (s[i] == 'a')
                {
                    countA++;
                }
            }
            return countA;
            /*88888888888888888888888888888888888888888888888888888888888
             Second Approach
             88888888888888888888888888888888888888888888888888888888888*/
            long size = s.Length, repeated = n / size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (s[i] == 'a')
                {
                    ++count;
                }
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                {
                    ++extra;
                }
            }

            repeated = (repeated * count) + extra;

            return repeated;
            /**********************************************************
             Second Approach
            **********************************************************/
            //List<char> listChar = new List<char>();
            //string str="";
            //int j = 0;
            //if (s.Length == 1 && 'a' == s[0])
            //    return n;
            //else if (s.Length == 1 && 'a' != s[0])
            //    return 0;
            //else
            //{
            //    for (long i = 0; i < n; i++)
            //    {
            //        if (j == Convert.ToInt64(s.Length))
            //            j = 0;

            //        str += s[j];
            //        j++;
            //    }
            //    //for (Int64 i = 0; i < n; i++)
            //    //{
            //    //    if (j == Convert.ToInt64(s.Length))
            //    //        j = 0;
            //    //    listChar.Add(s[j]);
            //    //    j++;
            //    //}
            //    long counter = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if ('a' == str[j])
            //            counter++;
            //    }
            //    //for (Int64 i = 0; i < n; i++)
            //    //{
            //    //    if ('a' == listChar[i])
            //    //        counter++;
            //    //}
            //    return counter;
            //}
        }
    }
}
