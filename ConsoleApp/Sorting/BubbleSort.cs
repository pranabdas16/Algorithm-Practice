using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp.Sorting
{
    class BubbleSort
    {
        /// <summary>
        /// BubbleSort objBS = new BubbleSort();
        /// objBS.bubbleSort();
        /// </summary>
        public void bubbleSort()
        {
            int[] arr = { 15, 12, 10, 7, 6, 2 };// { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(",",arr));
            Console.ReadLine();
        }
    }
}
