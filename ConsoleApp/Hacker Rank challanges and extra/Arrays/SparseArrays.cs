using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Arrays
{
   public class SparseArrays
    {
        /// <summary>
        /// Sparse Arrays
        /// https://www.hackerrank.com/challenges/sparse-arrays/problem?isFullScreen=true
        /// </summary>
        public void sparseArrays()
        {
            string[] strings = { "def", "de", "fgh" };//"aba", "baba", "aba", "xzxb" };
            string[] queries = { "de", "lmn", "fgh" }; //"aba", "xzxb", "ab" };
            // HashSet<string> hStrings = new HashSet<string>();
            // HashSet<string> hQueries = new HashSet<string>();
            List<int> result = new List<int>();
            int resultVal = 0;

            foreach (string quer in queries)
            {
                foreach (string str in strings)
                {
                    if (quer.Length == str.Length)
                    {
                        for (int i = 0; i < quer.Length; i++)
                        {
                            if (quer[i] == str[i])
                            {
                                if (i == str.Length-1)
                                    resultVal++;
                            }
                            else
                                break;          //else condition make the difference and helps to success couple of test case...
                        }
                    }
                }
                result.Add(resultVal);
                resultVal = 0;
            }
            foreach (int val in result)
                Console.WriteLine($"{val}");
        }

        public void sparseArraysV2()
        {
            string[] strings = {"def", "de", "fgh" };//"aba", "baba", "aba", "xzxb" };
            string[] queries = { "de", "lmn", "fgh" }; //"aba", "xzxb", "ab" };
            HashSet<string> hStrings = new HashSet<string>(strings);
            HashSet<string> hQueries = new HashSet<string>(queries);
            List<int> result = new List<int>();
            int resultVal = 0;

            foreach (string quer in hQueries)
            {
                foreach (string str in hStrings)
                {
                    if (quer.Length == str.Length)
                    {
                        for (int i = 0; i < quer.Length; i++)
                        {
                            if (quer[i] == str[i])
                            {
                                if (i == str.Length - 1)
                                    resultVal++;
                            }
                        }
                    }
                }
                result.Add(resultVal);
                resultVal = 0;
            }
            foreach (int val in result)
                Console.WriteLine($"{val}");
        }
    }
}
