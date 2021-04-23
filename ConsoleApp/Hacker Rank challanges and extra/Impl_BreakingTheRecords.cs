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
            int[] score = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };  
            int gameCount = score.Length;
            int MaxScore = score[0], MinScore = score[0], MaxCount =0, MinCount =0;
            int[] val = new int[2];
            for (int i = 0; i < gameCount-1; i++)
            {
                if (score[i] > score[i + 1])
                {
                    if (MaxScore > score[i])
                    {
                        //do nothing...
                    }
                    if (MinScore > score[i + 1])
                    {
                        MinScore = score[i + 1];
                        MinCount++;
                    }
                    if (MinScore > score[i])
                    {
                        MinScore = score[i];
                        MinCount++;
                    }
                }
                else if (score[i] < score[i + 1])
                {
                    if (MaxScore > score[i + 1])
                    {
                       //do nothing...
                    }
                    if (MaxScore < score[i + 1])
                    {
                        MaxScore = score[i+1];
                        MaxCount++;
                    }
                    if (MinScore > score[i])
                    {
                        MinScore = score[i];
                        MinCount++;
                    }
                    if (MinScore < score[i])
                    {
                       // do nothing...
                    }

                }
            }
            val[0] = MaxCount;
            val[1] = MinCount;
            //return val;
            objStpWatch.Stop();
            Console.WriteLine(MaxCount + "," + MinCount);
            Console.WriteLine(objStpWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
