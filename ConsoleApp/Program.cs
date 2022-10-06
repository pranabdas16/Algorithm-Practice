using ConsoleApp.LeetCode.Medium;
using ConsoleApp.Search;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.LeetCode.Easy;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.Write("My code run here");
            Console.WriteLine();
            Console.WriteLine("*****************************");
            IsPalindrome objPal = new IsPalindrome();
            objPal.isPalindrome();
            //int[] nums = { -1, 1, -1, 1, -1 };
            //ArraySign objAS = new ArraySign();
            //objAS.arraySign(nums);




            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************");

            //StringSearch objStrSearch = new StringSearch();

            Console.WriteLine("*********************Start code here*******************************");
            //Code here to check
            List<string>
            CommonChars objCC = new CommonChars();
            objCC.CommonChar()




            
            
            
            
            Console.WriteLine("*********************End code here*******************************");
            
            StringSearch1 objStrSearch1 = new StringSearch1();
            objStrSearch1.stringSearch1();

            Console.WriteLine(repeatedString("aba", 15));
            long repeatedString(string s, long n)
            {
                if (s.Length == 0)
                    return 0;
                if (s.Length == 1 && s[0] == 'a')
                    return n;

                long quot, rem;
                quot = n / s.Length;
                rem = n % s.Length;
                string newStr = string.Empty;
                long countA = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                    {
                        countA++;
                    }
                }

                countA *= quot;

                for (int i = 0; i < rem; i++)
                {
                    if (s[i] == 'a')
                    {
                        countA++;
                    }
                }
                return countA;
            }

            Console.WriteLine("*********************Start Transpose need to move in the class*******************************");
            int[,] matrix1 = { { 2, 4, -1 }, { -10, 5, 11 }, { 18, -7, 6 } };
            Transpose(matrix1);

            void Transpose(int[,] matrix)
            {
                int[,] matrixArray = matrix;
                //int[,] ansMatrix = new //new int[3,3];
                int row = matrixArray.GetLength(0);
                int col = matrixArray.GetLength(1);
                int[,] ansMatrix = new int[row, col];

                //  00 01 02  ij ij ij  xy xy xy  2, 4, -1      2  -10  18
                //  10 11 12  ij ij ij  xy xy xy -10, 5, 11     4   5   -7
                //  20 21 22  ij ij ij  xy xy xy  18 -7, 6     -1   11   6

                int x1 = 0;
                int y = 0;
                for (int j = 0; j < col; j++)
                {
                    for (int i = 0; i < row; i++)
                    {
                        ansMatrix[y, x1] = matrixArray[j, i];
                        x1++;
                        if (x1 == 3)
                            x1 = 0;
                    }
                    y++;
                    if (y == 3)
                        y = 0;
                }

                for (int j = 0; j < col; j++)
                {
                    for (int i = 0; i < row; i++)
                    {
                        Console.Write(ansMatrix[i, j] + ",");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("*********************End Transpose need to move in the class*******************************");

            string[] objString = new string[] { "01111", "01101", "00011", "11110" };

            char[][] result = objString.Select(item => item.ToArray()).ToArray();

            int row2 = objString.Length;
            int col2 = objString[0].Length;

            char[,] solchar = new char[row2, col2];

            int[,] solArray = new int[row2, col2];

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    solArray[i, j] = Convert.ToInt32(result[i][j]);
                }
            }

            CountGoodNumbers objGoodNumbers = new CountGoodNumbers();
            objGoodNumbers.countGoodNumbers(50);

            int removeThis = 0;

            Console.ReadLine();
        }

        public class LinkedListt
        {
            private Node head;

            public class Node
            {
                public int data;
                public Node next;

                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }
        }

        private static void removeDuplicate(char[] CharArry, int b)
        {
            string str = new string(CharArry);
            // List<string> listStr = new List<string>(str);
            //int index = 0;
            int i = 0, j;

            while (i < b)
            {
                j = i;

                char c = str[i];

                for (j = 1; j < b; j++)
                {
                    if (str[i] == str[j])
                    {
                        //str.Remove(i, i);
                    }
                }

                i++;
                // Console.Write(c);
            }
        }
    }
}