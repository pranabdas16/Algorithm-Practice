using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class MiniMaxSum
    {
        /// <summary>
        /// Min Max Sum......
        /// https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// MiniMaxSum OjbMinMaxSum = new MiniMaxSum();
        /// OjbMinMaxSum.miniMaxSum();
        /// </summary>
        public void miniMaxSum()
        {
            long[] arr = { 1, 2, 3, 4, 5 };
            long max = 0, min = 100, sum =0, cal =0;
            long n = arr.Length;
            List<long> objIntList = new List<long>();

            foreach (long val in arr)
            {
                sum += val;
                
            }

            while (n > 0)
            {
                cal = sum - arr[n - 1];
                objIntList.Add(cal);
    
                n--;
            }

            foreach (long var in objIntList)
            {
                if (max < var)
                {
                    max = var;
                    
                }
                min = var;
            }
            
            foreach (long var in objIntList)
            {
                if (min > var)
                {
                    min = var;
                }
            }

            Console.WriteLine( min +" " + max);     
            
            Console.ReadLine();

        }
    }
}
