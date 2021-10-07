using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sorting
{
    class ArrBubbleSort
    {
        ///
        // following is bubble sort......  EASY Method
        // start...
        ///

        public void arrBubbleSory()
        {
            int[] arrforbubbleSort = { 10, 70, 3, 6, 5, 3 };
            int tmp;
            for (int i = 0; i < arrforbubbleSort.Length - 1; i++)
            {
                for (int j = 0; j < arrforbubbleSort.Length - 1; j++)
                {
                    if (arrforbubbleSort[j] > arrforbubbleSort[j + 1])
                    {
                        tmp = arrforbubbleSort[j];
                        arrforbubbleSort[j] = arrforbubbleSort[j + 1];
                        arrforbubbleSort[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arrforbubbleSort));
        }
            //End....
    }
}
