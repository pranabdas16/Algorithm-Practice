using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp.Sorting
{
    class InsertionSort
    {
        public void insertionSort()
        {
            double[] unsortedList = { 5,2,4,6,1,3};// { 4, 3, 2, 10, 12, 1, 5, 6 };
            Stopwatch objTimeStamp = new Stopwatch();
            objTimeStamp.Start();
            int i = 1;
            int j = i;
            double temp = 0;

            while (i < unsortedList.Length)
            {
                j = i;

                while (j > 0 && unsortedList[j-1] > unsortedList[j])
                {
                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp;
                    j--;
                }
                i++;
            }
            objTimeStamp.Stop();
            Console.WriteLine(string.Join(",",unsortedList));
            Console.WriteLine(objTimeStamp.ElapsedMilliseconds);

            //int k = 0;
            //while (k < unsortedList.Length)
            //{
              //  Console.WriteLine(unsortedList[k]);
              //  k++;
            //}
            Console.ReadLine();
        }
    }
}
