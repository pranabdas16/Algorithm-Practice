using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Search
{
    class LinearSearch1
    {
        public void linearSearchMain()
        {
            Console.WriteLine("Please enter input search item:");
            int serachItem = int.Parse(Console.ReadLine());
            int[] arr = { 3, 5, 6, 7, };// 10, 12, 50, 55, 66, 70};
            //if ()
          int result =  LinearSearchRecover(arr, 0, serachItem);
            if (result < 0)
            {
                Console.WriteLine($"{serachItem} is not found");
            }
            else
            {
                Console.WriteLine($"{serachItem} is found at index {result}");
            }
        }

        public int LinearSearchRecover(int[] arr,int index, int searchItem)
        {
            if (index >= arr.Length)
                return -1;
            if (arr[index] == searchItem)
                return index;
            return LinearSearchRecover(arr, index+1, searchItem);


        }
    }
}
