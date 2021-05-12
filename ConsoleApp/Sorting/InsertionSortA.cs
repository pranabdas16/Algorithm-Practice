using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp.Sorting
{
    class InsertionSortA
    {
        public void insertionSortA()
        {
            Stopwatch objSW = new Stopwatch();
            objSW.Start();
            int[] arr1 = { 12, 11, 13, 5, 6 };// { 4, 7, 6, 1, 3, 4, 9, 10 };
            int n = arr1.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr1[i];
                int j = i - 1;

                while (j >= 0 && arr1[j] > key)
                {
                    arr1[j + 1] = arr1[j];
                    j = j - 1;
                }
                arr1[j + 1] = key;
            }
           
            objSW.Stop();
            Console.WriteLine(string.Join(",",arr1));
            Console.WriteLine(objSW.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
