using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Array.JaggedArray
{
    /// <summary> doesn't work fully No...........................
    /// https://leetcode.com/problems/transpose-matrix/
    /// Transposen Matrix...
    /// it does work square bracket but doesn't work 
    /// </summary>
    class TransponseMatrix1
    {
        public int [][] transposeMatrix()
        {
            int[][] matrix = new int[][] {
                
                new [] { 2, 4, -1},
                new [] { -10, 5, 11},
                new [] { 18, -7, 6}
            };
            int[][] ansMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                ansMatrix[i] = new int[matrix[i].Length];

            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    ansMatrix[j][i] = matrix[i][j];

                }
            }
            return ansMatrix;

        }
    }
}
