using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
   public class MinimumSwaps2V1
    {
        public int minimumSwaps()//int[] a)
        {
            int[] a = { 7, 1, 3, 2, 4, 5, 6 };
            int swap = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i + 1 != a[i])
                {
                    int t = i;
                    while (a[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = a[t];
                    a[t] = a[i];
                    a[i] = temp;
                    swap++;
                }
            }
            Console.WriteLine($"Here is the count for Min swap: {swap}");
            return swap;
        }
    }
}
