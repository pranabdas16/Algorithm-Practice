using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Walbreak
{
    class PlusOne
    {
        /// <summary>
        /// https://leetcode.com/problems/plus-one/
        /// </summary>
        /// <returns></returns>
        public int[] plusOne()
        {
            int[] inputArray = {9,9 };
            List<int> objIntList =  inputArray.ToList() ;

            int len = objIntList.Count();
            int lastVal = objIntList[len - 1] +1;
            if (lastVal == 10)
            {
                objIntList[len - 1] = 1;
                objIntList.Add(0);
            }
            else
            {
                objIntList[len - 1] = lastVal;
            }
            int[] ansArray = objIntList.ToArray();
            

            return ansArray;

        }
    }
}
