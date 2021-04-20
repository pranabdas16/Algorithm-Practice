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
        /// following two line of code use to call this method in program.cs
        /// BeautifulBinaryString objBBS = new BeautifulBinaryString();
        /// objBBS.beautifulBinaryString();
        /// </summary>
        public void beautifulBinaryString()
        {
            string strGiven = "1010100101";
                //"0100101010100010110100100110110100011100111110101001011001110111110000101011011111011001111100011101";
            string strSubstring = "010";
            int Counter = 0;
            int j = 0;
            for (int i = 0; i < strGiven.Length; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i < strGiven.Length)
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
                    }
                }
                if (j == 3 || j==1)
                {
                    i--;
                }
            }
            Console.WriteLine(Counter);
            Console.ReadLine();

        }
    }
}
