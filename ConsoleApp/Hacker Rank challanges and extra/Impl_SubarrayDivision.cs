using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Subarray Division
    /// https://www.hackerrank.com/challenges/the-birthday-bar/problem
    /// Two test case failed, need to check later then removed this line...
    /// SubarrayDivision objSD = new SubarrayDivision();
    /// objSD.subarrayDivision();
    /// </summary>
    class SubarrayDivision
    {
        public void subarrayDivision()//List<int> s, int d, int m)
        {
            List<int> s1 = new List<int>{ 5, 5, 3, 2, 2, 2, 1, 2, 5, 3, 5, 5, 4, 3, 3, 5 };
            int d1 = 13, m1 = 3;
            int sum =0, count =0, countOfSubArray=0, k=0;
            
            for (int i = 0; i < s1.Count; i++)
            {
                sum = 0; count = 0; k =i;
                for (int j = 0; j < m1; j++)
                {
                    sum = sum + s1[k];
                    count++;
                    if (k < s1.Count - 1)
                    { k++; }
                    if (count == m1)
                    {
                        if (sum == d1)
                        {
                            countOfSubArray++;
                            break;
                        }
                        break;
                    }
                }
            }

            Console.WriteLine(countOfSubArray);
            Console.ReadLine();
        }
    }
}
