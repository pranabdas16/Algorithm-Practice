using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Array12.JaggedArray
{
    class FlipAndInvertImage1
    {
        /// <summary>
        /// https://leetcode.com/problems/flipping-an-image/
        /// Step1: First reverse each row
        /// Step2: Then, invert the image
        /// //following to call through Program
        /// FlipAndInvertImage1 objflipAndInvertImage = new FlipAndInvertImage1();
        /// int[][] myfirstJaggedArray = objflipAndInvertImage.flipAndInvertImage();
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public int[][] flipAndInvertImage()//int[][] image)
        {
            int [][] nullVal= new int [0][];
            try
            {
                //int[][] givenArry = image;
                int[][] givenArry = new int[][] {
                                        new int []{ 1, 1, 0, 0 },
                                        new int []{ 1, 0, 0, 1 },
                                        new int []{ 0, 0, 1, 1 },
                                        new int []{ 1, 0, 1, 0} };
                int[][] ansArray = new int[givenArry.Length][];
                //ansArray[0] = new int[givenArry[0].Length];
                //ansArray[1] = new int[givenArry[1].Length];
                //ansArray[2] = new int[givenArry[2].Length];
                for (int i = 0; i < givenArry.Length; i++)
                {
                    ansArray[i] = new int[givenArry[i].Length];
                }

                int x = 0;
                int y = 0;
                for (int i = 0; i < givenArry.Length; i++)
                {
                    if (x == givenArry.Length)
                    {
                        x = 0;
                    }
                    for (int j = givenArry[i].Length - 1; j >= 0; j--)
                    {
                        if (y == givenArry[i].Length)
                        {
                            y = 0;
                        }
                        ansArray[x][y] = givenArry[i][j];
                        
                        y++;
                    }
                    
                    x++;
                }
                for (int i = 0; i < ansArray.Length; i++)
                {
                    for (int j = 0; j < ansArray[i].Length; j++)
                    {
                        if (ansArray[i][j] == 0)
                        {
                            ansArray[i][j] = 1;
                        }
                        else if (ansArray[i][j] == 1)
                        {
                            ansArray[i][j] = 0;
                        }
                    }
                }

                return ansArray;
            }
            catch (NullReferenceException ex)
            {
                return nullVal;
            }
        }
    }
}
