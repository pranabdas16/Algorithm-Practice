using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SumOfOneDArray
    {
        
        
        public void sumOfOneDArray()
        {
            int[] num = { 1, 2, 3, 4 };
            int calc =0;

            int[] resultArray = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                calc += num[i];

                resultArray[i] = calc;
            }
            Console.Write("[");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(resultArray[i] + ",");
            }
            Console.Write("]");

            Console.ReadLine();
                
        }
    }
}
