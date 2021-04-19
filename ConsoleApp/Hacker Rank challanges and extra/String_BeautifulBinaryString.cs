using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class BeautifulBinaryString
    {
        /// <summary>
        /// Beautiful Binary String
        /// https://www.hackerrank.com/challenges/beautiful-binary-string/problem?h_r=next-challenge&h_v=zen
        /// BeautifulBinaryString objBBS = new BeautifulBinaryString();
        /// objBBS.beautifulBinaryString();
        /// </summary>
        public void beautifulBinaryString()
        {
            string strGiven = "0100101010";
            string strSubstring = "010";
            int Counter = 0;
            for (int i = 0; i < strGiven.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (strGiven[i] == strSubstring[j])
                    {
                        if (j == 2)
                        {
                            Counter++;
                        }
                        i++;
                    }
                    else
                        break;

                    i--;
                }
            
            }
            Console.WriteLine(Counter);
            Console.ReadLine();

        }
    }
}
