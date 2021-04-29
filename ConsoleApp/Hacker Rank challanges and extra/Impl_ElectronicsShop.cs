using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class ElectronicsShop
    {
        /// <summary>
        /// Electronics Shop
        /// https://www.hackerrank.com/challenges/electronics-shop/problem
        /// This is not yet completed complete need to fix few more test cases....
        /// ElectronicsShop objES = new ElectronicsShop();
        /// objES.electronicsShop();
        /// </summary>
        public void electronicsShop()
            {
            int[] keyboards1 = {4};
            int[] drives1 = {5};
            int b1 = 5, sum = 0, maxsum =0 ;
            

            for (int i = 0; i < keyboards1.Length; i++)
            {
                for (int j = 0; j < drives1.Length; j++)
                {
                    sum = keyboards1[i] + drives1[j];
                    if (b1 >= sum)
                    {
                        if (maxsum < sum)
                        {
                            maxsum = sum;
                        }
                    }
                    else
                        maxsum = -1;
                }
            }
            Console.WriteLine(maxsum);
            Console.ReadLine();
            }
    }
}
