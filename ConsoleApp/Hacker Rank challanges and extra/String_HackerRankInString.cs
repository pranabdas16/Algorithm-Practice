using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// HackerRank in a String!
    /// https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem?h_r=next-challenge&h_v=zen
    /// Following two line of Code to call this class and method in Program.cs
    /// HackerRankInString objHckrRankInstr = new HackerRankInString();
    /// objHckrRankInstr.hackerRankInString();
    /// </summary>
    class HackerRankInString
    {
        public void hackerRankInString()
        {
            string givenStr = "hereiamstackerrank"; //= s;  //This S could be input string when call above function...
            string hckrRnkStr = "hackerrank";
            Boolean yesNo = false;
            int j = 0;
            string outPutStr;
            for (int i = 0; i < givenStr.Length; i++)
            {
                if (givenStr[i] == hckrRnkStr[j])
                {
                    j++;
                }
                if (j == 10)
                {
                    yesNo = true;
                    break;
                }
            }

            if (yesNo == true)
            {
                outPutStr = "YES";
            }
            else
            {
                outPutStr = "NO";
            }

            //return outPutStr;
        }
    }
}
