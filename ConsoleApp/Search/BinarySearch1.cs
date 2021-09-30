using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Search
{
    class BinarySearch1
    {
        public int binarySearch1( int [] arr, int searchItem)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (searchItem == arr[mid])
                {
                    return mid;
                }
                else if (searchItem <= mid)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        public void binarySearchMain()
        {
            Console.WriteLine("Please provide input search item");
            int searhItem = int.Parse( Console.ReadLine());
            int[] arr = { 5, 11, 20, 25, 33, 49, 50, 62, 67, 73 };
            int result = binarySearch1(arr, searhItem);
            if (result < 0)
            {
                Console.WriteLine( searhItem + "is not foud");
            }
            else
            {
                Console.WriteLine($"{searhItem} is found at index: {result}");
            }

        }
    }
}
