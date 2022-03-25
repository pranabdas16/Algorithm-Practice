using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Matrix2DArray
{
    public class TransposeMatrix
    {
        /// <summary>
        /// Transpose Matrix.....
        /// https://leetcode.com/problems/transpose-matrix/
        /// </summary>
        public void transposeMatrix()
        {
            int[,] givenArray = { { 1, 2, 3, 10 },          // 00, 01, 02  // 1 4
                                  { 4, 5, 6, 11 },          // 10, 11, 12  // 2 5
                                 // { 7, 8, 9, 12 },
                                  { 17, 18, 19, 22 } };        // 20, 21, 22  // 3 6

            int rowLength = givenArray.GetLength(0);
            int colLength = givenArray.GetLength(1);
            int[,] targetArray = new int[rowLength, colLength];

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write($"{givenArray[i, j]}, ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    targetArray[i, j] = givenArray[j, i];

                }

            }
            Console.WriteLine("Target array");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write($"{targetArray[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
