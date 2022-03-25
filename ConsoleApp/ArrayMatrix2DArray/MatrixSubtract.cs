using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Matrix2DArray
{
   public class MatrixSubtract
    {
        /// <summary>
        /// Matrix Substract
        /// https://www.sanfoundry.com/csharp-programs-matrix-subtraction/
        /// MatrixSubtract objMatrxSub = new MatrixSubtract();
        /// objMatrxSub.matrixSubtract();
        /// </summary>
        public void matrixSubtract()
        {
            //3 3 2
            //3 1 2
            //6 6 6
            int[,] arryA = { { 9, 8, 7},
                             { 6, 5, 4},
                             { 7, 8, 9} };

            int[,] arryB = { { 6, 5, 5},
                             { 3, 4, 2},
                             { 1, 2, 3} };

            int rowLngth = arryA.GetLength(0);
            int ColLngth = arryB.GetLength(1);

            int[,] sumArry = new int[rowLngth, ColLngth];

            for (int i = 0; i < rowLngth; i++)
                for (int j = 0; j < ColLngth; j++)
                {
                    sumArry[i, j] = arryA[i, j] - arryB[i, j];
                }

            for (int i = 0; i < rowLngth; i++)
            {
                for (int j = 0; j < ColLngth; j++)
                {
                    Console.Write(sumArry[i, j] + ",");
                }
                Console.WriteLine();
            }

        }
    }
}
