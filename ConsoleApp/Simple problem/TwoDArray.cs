using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    /// <summary>
    /// Two dimensional Array 
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(twodimArray[i,j] + " "); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
