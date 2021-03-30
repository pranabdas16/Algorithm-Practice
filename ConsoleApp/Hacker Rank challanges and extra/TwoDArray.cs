using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    /// <summary>
    /// Two dimensional Array...
    /// Difference of primary and secondary diagonal...
    /// Following commented code will go program.cs file to run the code..
    /// TwoDArray objt = new TwoDArray();
    /// objt.twoDArray();
    /// </summary>
    class TwoDArray
    {
        public void twoDArray()
        {
            int n = 3;
            //int [][] anotherTwoDArray = { { 11, 2, 3,},
            //                     { 4,   5, 6},
            //                    { 10, 8,-12} };
            int[,] twodimArray = { { 11, 2, 3,},
                                 { 4,   5, 6},
                                { 10, 8,-12} };
            // Initialize sums of diagonals
            int d1 = 0, d2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(twodimArray[i,j] + " "); 
                }
                Console.WriteLine();
            }

            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    // finding sum of primary diagonal
                    if (i == j)
                        d1 += twodimArray[i, j];

                    // finding sum of secondary diagonal
                    if (i == n - j - 1)
                        d2 += twodimArray[i, j];
                }
            }
            Console.WriteLine("Primary diagonal value: " + d1);
            Console.WriteLine("Secondary diagonal value: " + d2);
            // Absolute difference of the
            // sums across the diagonals
            d1 = d1 - d2;
            Console.WriteLine("The absolute difference: "+ d1);
            Console.ReadLine();
        }
    }
}
