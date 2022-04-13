using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class Intersect
    {
        /// <summary>
        /// Not resolved question yet....
        /// https://leetcode.com/problems/intersection-of-two-arrays-ii/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        #region intersect....
        public int[] intersect(int[] nums1, int[] nums2)
        {
            int[] smallArr;
            int[] largeArr;
            List<int> output = new List<int>();
            if (nums1.Length < nums2.Length)
            {
                smallArr = nums1;
                largeArr = nums2;
            }
            else if (nums1.Length > nums2.Length)
            {
                smallArr = nums2;
                largeArr = nums1;
            }
            else
            {
                smallArr = nums1;
                largeArr = nums2;
            }
            int count = 0;
            for (int i = 0; i < smallArr.Length; i++)
            {
                for (int j = 0; j < largeArr.Length; j++)
                {
                    try
                    {
                        if ((smallArr[i] == smallArr[i + 1]) && smallArr.Length == 2 && largeArr.Length == 2)// && smallArr.Length != 2)
                            i++;
                    }
                    catch
                    {
                        //do nothing..
                    }
                    if (smallArr[i] == largeArr[j] && count == 0)
                    {
                        try
                        {
                            if ((largeArr[j] == largeArr[j + 1]) && smallArr.Length == 2 && largeArr.Length == 2)//&& largeArr.Length != 2)
                                j++;
                        }
                        catch
                        {
                            //do nothing...
                        }
                        output.Add(smallArr[i]);
                        count++;
                        //break;
                    }

                }
            }
            int[] opArr = output.ToArray();
            foreach (int a in opArr)
            {
                Console.Write($"{a},");
            }
            return opArr;
        }
        #endregion

        #region new intersect....
        public int[] intersectV2(int[] nums1, int[] nums2)
        {
            List<int> output = new List<int>();
            List<int> smallList = new List<int>();
            List<int> bigList = new List<int>();
            if (nums1.Length < nums2.Length)
            {
                smallList = nums1.ToList();
                bigList = nums2.ToList();
            }
            else
            {
                bigList = nums1.ToList();
                smallList = nums2.ToList();
            }
            int i = 0, j = 0 ;
            bool flag = true; 
            while(i < smallList.Count)
            {
                flag = true;
                while (j <bigList.Count)
                {
                    if (smallList[i] == bigList[j])
                    {
                        int val = smallList[i];
                        output.Add(val);
                        smallList.RemoveAt(i);
                        bigList.RemoveAt(j);
                        flag = false;
                        break;
                    }
                    else
                    {
                        j++;
                    }
                }
                j = 0;
                if (flag)
                {
                    i++;
                }
                
            }
            Console.Write($"Here is the list of output:");
            foreach (int c in output)
            {
                Console.Write($"{c},");
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] resultArr = output.ToArray();
            return resultArr;
        }
        #endregion
    }
}
