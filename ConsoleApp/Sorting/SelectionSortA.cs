using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp.Sorting
{
    class SelectionSortA
    {
        /// <summary>
        /// Selection Sort
        /// different way of selection sort...
        /// </summary>
        public void selectionSortA()
        {
            int[] arr = { 4, 5, 6, 1, 2, 3 };
            Stopwatch objSw = new Stopwatch();
            objSw.Start();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

            }
            objSw.Stop();
            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(objSw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
