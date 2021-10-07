using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Search
{
    class LinearSearch2
    {
        public void linearSearch2()
        {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int mid = 1 + (arr.Length - 1) / 2;
        int x = 3;
        int val = -1;
        Console.WriteLine("Mid value of of array : " + mid);
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    val = i;
                }
                }
                Console.WriteLine("Linear search for given array: " + val);
                Console.WriteLine("Power value of 2 ^ 4 is here:" + Math.Pow(2, 4));
        }
    }
}
