using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class FindLength
    {
        /// <summary>
        /// https://leetcode.com/problems/maximum-length-of-repeated-subarray/
        /// </summary>
        /// <param name="nums1"></param> { 1, 2, 3, 2, 1 }
        /// <param name="nums2"></param> { 3, 2, 1, 4, 7}
        /// <returns></returns>
        public int findLength(int[] nums1, int[] nums2)
        {
            List<int> resultList = new List<int>();
            int counter = 0, maxLength = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                int temp = i;
                for (int j = 0; j < nums2.Length; j++)
                {
                    try
                    {
                        if (nums1[i] == nums2[j])
                        {
                            if (counter == 0)
                                resultList.Add(nums1[i]);

                            counter++;
                            if ((i - (i - 1)) == 1 && counter > 1)
                            {
                                resultList.Add(nums1[i]);
                            }
                            else if ((i - (i - 1)) != 1 && counter > 1)
                            {
                                break;
                            }

                            if (resultList.Count > maxLength)
                                maxLength = resultList.Count;

                            i++;
                        }
                        else if (nums1[i] != nums2[j] && counter != 0)
                        {
                            break;
                        }
                    }
                    catch
                    { 
                    
                    }
                }
                resultList = new List<int>();
                i = temp;
                counter = 0;
            }
            Console.WriteLine($"Max length: {maxLength}");
            return maxLength;
        }
    }
}
