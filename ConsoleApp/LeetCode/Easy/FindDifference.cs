using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
   public class FindDifference
    {
        /// <summary>
        /// https://leetcode.com/problems/find-the-difference-of-two-arrays/
        /// </summary>
        /// <returns></returns>
        public IList<IList<int>> findDifference(int[] nums1, int[] nums2)
        {
            List<int> list1, list2;

            IList<IList<int>> TotalList = new List<IList<int>>();
            //int[] num1 = { 1, 2, 3, 3 };
            //int[] num2 = { 1, 1, 2, 2 };
            list1 = nums1.Distinct().ToList();
            list2 = nums2.Distinct().ToList();
            int i = 0, j = 0, counter =0;
            while (i < list1.Count)
            {
                counter = 0;
                j = 0;
                while (j < list2.Count)
                {
                    if (list1[i] == list2[j])
                    {
                        list1.RemoveAt(i);
                        list2.RemoveAt(j);
                        counter++;
                        break;
                    }
                    j++;
                }
                if(counter == 0)
                    i++;
            }
            TotalList.Add(list1);
            TotalList.Add(list2);
            return TotalList;
        }
    }
}
