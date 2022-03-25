using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Few_Test_To_Pass
{
   public class LeftRotation1
    {
        /// <summary>
        /// Left Rotation
        /// https://www.hackerrank.com/challenges/array-left-rotation/problem?isFullScreen=true
        /// </summary>
        public void leftRotation1()
        {
            int d =2;
            List<int> arr = new List<int>();
            List<int> result = new List<int>();
            for (int i = d; i < arr.Count; i++)
            {
                result.Add(arr[i]);
            }
            for (int i = 0; i < d; i++)
            {
                result.Add(arr[i]);
            }
            
        }
    }
}
