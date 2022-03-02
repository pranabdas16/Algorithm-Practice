using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
   public class MinimumSwaps2V2
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>

        public void minimumSwaps2V2()
        {
            int[] arr = { 7, 1, 3, 2, 4, 5, 6 };// 4, 3, 1, 2 };
            int minVal = 1, t, swap = 0; ;
            //int maxVal = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                t = i;
                int minIndex= Array.IndexOf(arr, minVal);
                //while (minVal != arr[t])
                //{
                //    t++;
                //}
                if ( i == minIndex)
                {

                }
                else
                {
                    while (minVal != arr[t] )
                    {
                        int temp = arr[t];
                            arr[t] = arr[i];
                           arr[i] = temp;
                            swap++;
                            minVal++;
                            t++;
                        if (minVal == 9)
                            minVal = 1;
                        if (t == 7)
                            t = 0;
                    }
                    //if (minVal == arr[minIndex])// && i+1 != arr[i])
                    //{
                    //    int temp = arr[minIndex];
                    //    arr[minIndex] = arr[i];
                    //    arr[i] = temp;
                    //    swap++;
                    //    minVal++;
                    //}
                }
            }
            Console.WriteLine($"Here is the count for Min swap: {swap}");
            //return swap;

            foreach(var c in arr)
            {
                Console.Write($"{c},");
            }
        }

        public void minimumSwaps2Version1()
        {
            int[] arr = { 1, 3, 5, 2, 4, 6, 7 };//4, 3, 1, 2 };//7, 1, 3, 2, 4, 5, 6 };
            int minval = 1, swap =0 ;

            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = false;
                int j = i;
                while (minval != arr[j])
                {
                    j++;
                    flag = true;
                    if (j == arr.Length)
                        j = 0;
                    if (minval == i - 1)
                        flag = false;
                }
                if (flag)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    swap++;
                    minval++;
                }
            }
            Console.WriteLine($"Here is the Swap cout {swap}");
            foreach (var c in arr)
            {
                Console.Write($"{c}, ");
            }
        }

        public void minimumSwaps2Version2()
        {
            int[] arr = { 1, 3, 5, 2, 4, 6, 7 };//4, 3, 1, 2 };//7, 1, 3, 2, 4, 5, 6 };
            int minval = 1, swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int t = i;
                while (arr[t] != i + 1)
                {
                    t++;
                }
                int temp = arr[t];
                arr[t] = arr[i];
                arr[i] = temp;
                swap++;
            }
            Console.WriteLine($"Here is the Swap count {swap}");
            foreach (var c in arr)
            {
                Console.Write($"{c}, ");
            }
        }

        public void minimumSwaps2Version3()
        {
            int[] arr = { 1, 3, 5, 2, 4, 6, 7 };//4, 3, 1, 2 };//7, 1, 3, 2, 4, 5, 6 };
            int minval = 1, swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    int t = i;
                    while (arr[t] != i+1)
                    {
                        t++;
                    }
                    int temp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = temp;
                    swap++;
                    minval++;
                }
            }
            Console.WriteLine($"Here is the Swap count {swap}");
            foreach (var c in arr)
            {
                Console.Write($"{c}, ");
            }
        }
    }
}
