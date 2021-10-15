using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Walbreak
{
    class SearchingChallenge
    {
        public void searchingChallenge()//int [, ] qArray)
        {
            //["1011"],
            //["0010"]
            // ["01111",
            //  "01101",
            //  "00011",
            //  "11110"]
            int[,] givenArray = new int[,]
                                   { { 1, 0, 1, 1, 1},
                                     { 1, 0, 1, 0, 1},
                                     { 1, 1, 1, 0, 1},
                                     { 1, 1, 1, 1, 1},
                                   };
            //int[,] givenArray = qArray;
            int row = givenArray.GetLength(0);
            int col = givenArray.GetLength(1);

            int counter = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col ; j++)
                {
                    if (j + 1 == col)
                    { 
                    // do nothing
                    }
                    else
                    {
                        if (givenArray[i, j] == givenArray[i, j + 1] && givenArray[i, j] == 0)
                        {
                            counter++;
                        }
                    }
                }
            
            }

            for (int j = 0; j < col ; j++)
            {
                for (int i = 0; i < row ; i++)
                {
                    if (i + 1 == row)
                    {
                        // do nothing
                    }
                    else
                    {
                        if (givenArray[i, j] == givenArray[i + 1, j] && givenArray[i, j] == 0)
                        {
                            counter++;
                        }

                    }
                
                }
            }

            Console.WriteLine("Output:" + counter);
            Console.ReadLine();

        }
    }
}
