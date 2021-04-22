using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class BreakingTheRecords
    {
        /// <summary>
        /// Breaking The Records
        /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
        /// BreakingTheRecords objBTR = new BreakingTheRecords();
        /// objBTR.breakingTheRecords();
        /// </summary>
        public void breakingTheRecords()
        {
            Stopwatch objStpWatch = new Stopwatch();
            objStpWatch.Start();
            int[] score = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            int gameCount = score.Length;
            int MaxScore = score[0], MinScore = score[0], MaxCount =0, MinCount =0;

            for (int i = 0; i < gameCount-1; i++)
            {
                if (score[i] > score[i + 1])
                {
                    if (MaxScore > score[i])
                    {
                        MaxScore = score[i];
                        MaxCount++;
                    }
                    else if (MinScore > score[i + 1])
                    {
                        MinScore = score[i + 1];
                        MinCount++;
                    }
                    else if (MinScore > score[i])
                    {
                        MinScore = score[i];
                        MinCount++;
                    }
                }
                else if (score[i] < score[i + 1])
                {
                    if (MaxScore > score[i + 1])
                    {
                        MaxScore = score[i];
                        MaxCount++;
                    }
                    else if (MaxScore < score[i + 1])
                    {
                        MaxScore = score[i];
                        MaxCount++;
                    }
                    if (MinScore > score[i])
                    {
                        MinScore = score[i];
                        MinCount++;
                    }
                    else if (MinScore < score[i])
                    {
                        //MinScore = score[i];
                        //MinCount--;
                    }

                }
            }
            objStpWatch.Stop();
            Console.WriteLine(MaxCount +","+ MinCount);
            Console.WriteLine(objStpWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
