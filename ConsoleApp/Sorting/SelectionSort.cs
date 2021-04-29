using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sorting
{
    class SelectionSort
    {
        /// <summary>
        /// Selection sort 
        /// This selection sort not yet completed. I need to work it....
        /// </summary>
        public void selectionSort()
        {
            int[] arry = { 10, 4, 8, 6, 7};
            int i = 0, temp, minIndex=0, maxIndex=0;
            int j = i + 1;
            for (i = 0; i < arry.Length; ++i)
            {
                for (j =i+1; j < arry.Length - 1; ++j)
                {
                    if (i > j)
                    {
                        minIndex = j;
                        maxIndex = i;
                    }
                    temp = arry[maxIndex];
                    arry[i] = arry[minIndex];
                    arry[minIndex] = temp;
                }
            }
        }
    }
}
