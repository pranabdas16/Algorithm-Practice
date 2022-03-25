using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MatrixSpiralCode
    {
        public void matrixspiralCode()
        {
            int[,] inputArray= { {1,  2,  3,  4,  5 },        //00, 01, 02, 03, 04
                                { 6,  7,  8,   9, 10},       // 10, 11, 12, 13, 14
                                { 11, 12, 13, 14, 15},       // 20, 21, 22, 23, 24
                                { 16, 17, 18, 19, 20}        // 30, 31, 32, 33, 34
            };
            //[1, 2, 3, 4, 5, |  10, 15, 20, | 19, 18, 17, 16, | 11, 6, | 7, 8, 9, | 14, | 13, 12]
            //   ROW          |  COL         |   ROW           |  COL   | ROW      | COL |  ROW
            int firstRowlength = inputArray.Length;
            int Rn = inputArray.GetLength(0);
            int Cn = inputArray.GetLength(1);
            int i = 0, j = 0;
            while (j < Cn)   //Step 1
            {
                Console.Write(inputArray[i, j] + ",");
                j++;
                
            }
            i = 1;
            j = Cn-1; //=4
            while (i < Rn)   //Step 2
            {
                Console.Write(inputArray[i, j] + ",");
                i++;
            }
            i = Rn - 1;  // = 3
            j = Cn - 2;  // = 3
            while (j >= 0)   //Step 3
            {
                Console.Write(inputArray[i, j] + ",");
                j--;
            }
            i = Rn - 2;  // = 2
            j = 0;
            while (i > 0)   //Step 4
            {
                Console.Write(inputArray[i, j] + ",");
                i--;
            }
            i = 1;
            j = 1;
            while (j <= Cn - 2)  //Step 5
            {
                Console.Write(inputArray[i, j] + ",");
                j++;
            }
            i = 2;
            j = 3;
            while (i < Rn -1)  //Step 6
            {
                Console.Write(inputArray[i, j] + ",");
                i++;
            }
            i = 2;
            j = Cn - 3; // = 2
            while (j > Cn-5 )  //step 7
            {
                Console.Write(inputArray[i, j] + ",");
                j--;
            }


            Console.WriteLine();
            Console.WriteLine("Total Length: "+ firstRowlength+ ", Row Rn:"+ Rn +", Col Cn:"+ Cn);
            Console.ReadLine();
    }
    }
}
