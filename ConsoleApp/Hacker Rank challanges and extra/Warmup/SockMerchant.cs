using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Warmup
{
   public class SockMerchant
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        /// </summary>
        /// <returns></returns>
        public int sockMerchant()//int n, List<int> ar)
        {
            List<int> ar = new List<int>();
            ar.Add(1);
            ar.Add(2);
            ar.Add(1);
            ar.Add(2);
            ar.Add(1);
            ar.Add(3);
            ar.Add(1);
            //ar.Add();
            int n = 7;
            int count = 0, TotalCount = 0;
            foreach (char c in ar.Distinct()) 
            {
                for (int i = 0; i < n; i++)
                {
                    if (c == ar[i])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    count = count / 2;
                }
                TotalCount += count;
                count = 0;
            }

                return TotalCount;
        }
    }
}
