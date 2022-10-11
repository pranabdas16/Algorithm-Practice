using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays/
    /// </summary>
    public class Intersection
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> list1, list2, Resultlist = new List<int>(); ;
            //int[] num1 = { 1, 2, 3, 3 };
            //int[] num2 = { 1, 1, 2, 2 };
            list1 = nums1.Distinct().ToList();
            list2 = nums2.Distinct().ToList();
            int i = 0, j = 0, counter = 0;
            while (i < list1.Count)
            {
                counter = 0;
                j = 0;
                while (j < list2.Count)
                {
                    if (list1[i] == list2[j])
                    {
                        int val = list1[i];
                        Resultlist.Add(val);
                        list1.RemoveAt(i);
                        list2.RemoveAt(j);
                        counter++;
                        break;
                    }
                    j++;
                }
                if (counter == 0)
                    i++;
            }
            int[] ResultArr = Resultlist.ToArray();
            return ResultArr;
        }
    }
}
