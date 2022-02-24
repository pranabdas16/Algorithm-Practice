using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
   public class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            int smallStrLngth, longStrLngth;
            string smallStr, longStr, val = "NO";
            if (s1.Length > s2.Length)
            {
                smallStrLngth = s2.Length;
                smallStr = s2;
                longStr = s1;
            }
            else
            {
                smallStrLngth = s1.Length;
                smallStr = s1;
                longStr = s2;
            }

            int k = 0;
            while (k < smallStrLngth)
            {
                for (int i = 0; i < longStr.Length; i++)
                {
                    if (smallStr[k] == longStr[i])
                    {
                        val = "YES";
                        return val;
                    }
                }
                k++;
            }
            return val;
        }
    }
}
