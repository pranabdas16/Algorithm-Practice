using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class CountingValleys
    {
        /// <summary>
        /// Counting Valleys
        /// https://www.hackerrank.com/challenges/counting-valleys/problem
        /// CountingValleys objCV = new CountingValleys();
        /// objCV.countingValleys();
        /// </summary>

        public void countingValleys()
        {
            int steps1 = 8;
            string path1 = "UDDDUDUU";
            int seaLevel = 0, vallycounter =0;

            for (int i = 0; i < steps1; i++)
            {
                if (path1[i] == 'D')
                {
                    seaLevel--;
                }
                else if (path1[i] == 'U')
                {
                    seaLevel++;
                }

                if (seaLevel == 0  && path1[i] == 'U' )
                {
                    vallycounter++;
                }
            }

            Console.WriteLine(vallycounter);
            Console.ReadLine();

        }
    }
}
