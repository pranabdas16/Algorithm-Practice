using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class GetMinimumDifference
    {
        /// <summary>
        /// Not resolved yet.....
        /// </summary>
        /// <param name="job"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int getMinimumDifference(List<int> job, long k)
        {
            int max = 0, maxMax = 0;
            while (k > 0)
            {
                for (int i = 0; i < job.Count; i++)
                {
                    try
                    {
                        if (k <= 0)
                            break;

                        if ((job[i] < job[i + 1]))
                        {
                            job[i] = job[i] + 1;
                        }
                        else
                        {
                            job[i + 1] = job[i + 1] + 1;
                        }
                        k--;
                    }
                    catch
                    {

                    }
                }
            }

            for (int i = 0; i < job.Count; i++)
            {
                try
                {
                    if (job[i] > job[i + 1])
                    {
                        max = job[i] - job[i + 1];
                        if (maxMax < max)
                        {
                            maxMax = max;
                        }
                    }
                    else
                    {
                        max = job[i + 1] - job[i];
                        if (maxMax < max)
                        {
                            maxMax = max;
                        }
                    }

                }
                catch
                {

                }
            }
            if (maxMax == 0)
            {
                Console.WriteLine(maxMax);
                return 1;
            }
            else
            {
                Console.WriteLine(maxMax);
                return maxMax;
            }
        }
    }
}
