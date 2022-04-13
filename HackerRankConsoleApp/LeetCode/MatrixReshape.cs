using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class MatrixReshape
    {
        /// <summary>
        /// https://leetcode.com/problems/minimum-size-subarray-sum/
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int[][] matrixReshape(int[][] mat, int r, int c)
        {
            int row, col;
            row = mat.Length;
            col = mat[0].Length;
            List<int> matList = new List<int>();
            int[][] targetMat = new int[r][];
            
            for (int i = 0; i < r; i++)
            {
                targetMat[i] = new int[c];
            }
            if (row == r && col == c)
            {
                return mat;
            }
            else
            {
                try
                {
                    for (int i = 0; i < mat.Length; i++)
                    {
                        for (int j = 0; j < mat[i].Length; j++)
                        {
                            matList.Add(mat[i][j]);
                        }
                    }
                }
                catch ( Exception ex)
                {
                   // throw ex;
                }
               // return targetMat;
            }
            int k = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    targetMat[i][j] = matList[k];
                    k++;
                }
            }
            return targetMat;

        }
    }
}
