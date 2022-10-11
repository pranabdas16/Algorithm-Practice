using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii/
    /// </summary>
    public class IntersectTwoArray
    {
        public int[] Intersect(int[] nums1, int[] nums2) 
        {
            List<int> smallArr, LongArr, newList = new List<int>();
            if (nums1.Length > nums2.Length)
            {
                smallArr = nums2.ToList();
                LongArr = nums1.ToList();
            }
            else
            {
                smallArr = nums1.ToList();
                LongArr = nums2.ToList();
            }

            for (int i = 0; i < smallArr.Count; i++)
            {
                int k = 0;
                while (LongArr.Count - 1 >= k)
                {
                    if (LongArr[k] == smallArr[i])
                    {
                        int val = Convert.ToInt32(smallArr[i]);
                        newList.Add(val);
                        LongArr.RemoveAt(k);
                        break;
                    }
                    k++;
                }
            
            }
            Console.WriteLine("Here is the list:");
            foreach (int val in newList)
            {
                Console.Write($"{val}|->");
            }
            int[] result = newList.ToArray();
            return result; 
        }
    }
}
