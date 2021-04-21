using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class DivisibleSumPairs
    {
        /// <summary>
        /// Divisible Sum Pairs
        /// https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
        /// DivisibleSumPairs objDSP = new DivisibleSumPairs();
        /// objDSP.divisibleSumPairs();
        /// </summary>
        public void divisibleSumPairs()
        {

            int[] givenArray = { 1, 3, 2, 6, 1, 2 };
            int n1 = 6;
            int k1 = 3;
            int sum=0, mod =0, counter=0;
            for (int i = 0; i < n1-1; i++)
            {
                for (int j = i + 1; j < n1; j++)
                {
                   sum = givenArray[i] + givenArray[j];
                    mod = sum % k1;

                    if (mod == 0)
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
