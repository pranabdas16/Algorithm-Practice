using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class SearchMatrix
    {
        public bool searchMatrix(int[][] matrix, int target)
        {
            bool result = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (target > matrix[i][j])
                    {
                        continue;
                    }
                    if (target < matrix[i][j])
                    {
                        Console.WriteLine("could not find the value the value....");
                        return false;
                    }
                    if (target == matrix[i][j])
                    {
                        Console.WriteLine("found the value....");
                        return true;
                    }
                }
            }
            Console.WriteLine("could not find the value the value....");
            return result;
        }
    }
}
