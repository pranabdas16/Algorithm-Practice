using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sorting
{
    class InsertionSort
    {
        public void insertionSort()
        {
            double[] unsortedList = { 4, 3, 2, 10, 12, 1, 5, 6 };
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
            int k = 0;
            while (k < unsortedList.Length)
            {
                Console.WriteLine(unsortedList[k]);
                k++;
            }
            Console.ReadLine();
        }
    }
}
