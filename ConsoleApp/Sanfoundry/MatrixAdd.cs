using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sanfoundry
{
    /// <summary>
    /// Matrix Addition
    /// https://www.sanfoundry.com/csharp-program-performs-matrix-addition/
    /// Main Link
    /// https://www.sanfoundry.com/csharp-programming-examples-on-matrix/
    /// MatrixAdd objmatrixAdd = new MatrixAdd();
    /// objmatrixAdd.matirixAdd();
    /// </summary>
    public class MatrixAdd
    {
        //2 4 6
        //4 4 8
        //4 5 10
        public void matirixAdd()
        {
            int[,] arryA = { { 1, 2, 3},
                             { 2, 3, 4},
                             { 3, 4, 5} };

            int[,] arryB = { { 1, 2, 3},
                             { 2, 1, 4},
                             { 1, 1, 5} };

            int rowLngth = arryA.GetLength(0);
            int ColLngth = arryB.GetLength(1);

            int[,] sumArry = new int[rowLngth, ColLngth];

            for (int i = 0; i < rowLngth; i++)
                for (int j = 0; j < ColLngth; j++)
                {
                    sumArry[i, j] = arryA[i, j] + arryB[i, j];
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
