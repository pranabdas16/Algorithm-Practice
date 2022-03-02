using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
   public class MinimumSwaps2
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        public void minimumSwaps2()
        {
            //Dictionary<int, int> target = new Dictionary<int, int>();
            int[] arr = { 4, 3, 1, 2 };
            int temp1, temp2, minNum=0, maxNum=0, counter =0;
            for (int j = 0; j < arr.Length; j++)
            {
               // minNum = 0; maxNum = 0; counter = 0;
                for (int i = j; i < arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        if (counter == 0)
                        {
                            minNum = arr[i + 1];
                            maxNum = arr[i];
                            counter++;
                        }
                        else if (counter > 0)
                        {
                            if (arr[i] > maxNum)
                            {
                                maxNum = arr[i];
                            }
                            if (arr[i + 1] < minNum)
                            {
                                minNum = arr[i + 1];
                            }
                        }
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            minNum = arr[i];
                            maxNum = arr[i + 1];
                            counter++;
                        }
                        else if (counter > 0)
                        {
                            if (arr[i + 1] < minNum)
                            {
                                minNum = arr[i + 1];
                            }
                            if (arr[i] > maxNum)
                            {
                                maxNum = arr[i];
                            }
                        }
                    }
                    //target.Add(minNum, maxNum);
                }
                int minIndex = FindIndexC(arr, minNum);
                int maxIndex = FindIndexC(arr, maxNum);
                int tmp;
                tmp = arr[minIndex];
                arr[minIndex] = arr[maxIndex];
                arr[maxIndex] = tmp;
            }
            Console.WriteLine($"Min Number: {minNum} and Max Number:{maxNum}");
           // target.Add(minNum, maxNum);
        }

        public int FindIndexC(int[] arr, int val)
        {
            int at=0;
            Dictionary<int, int> ObjKeyval = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    at = i;
                }
            }
           
            return at;
        }
    }
}
