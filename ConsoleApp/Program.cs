using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Simple_problem;
using ConsoleApp.Hacker_Rank_challanges_and_extra;
using ConsoleApp.Sorting;
using ConsoleApp.LinkedLIst;
using ConsoleApp.LeetCode.Easy;
using ConsoleApp.Sanfoundry;
using ConsoleApp.Hacker_Rank_challanges_and_extra.Arrays;
using ConsoleApp.Search;
using ConsoleApp.Array.JaggedArray;
using ConsoleApp.LeetCode.Walbreak;
using ConsoleApp.DS;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Stack exercise....
            ///integer stack
            // StackExercise obj = new StackExercise();
            //obj.stackofInt();

            ///Stack of int Array use....
            // obj.stackOfIntArry();

            ///Stack of String Array use...
            // obj.stackOfStringArray();

            ///Single Linked list with multiple action..

            ///Single linked list to add 
            //  LinkedList linkedList = new LinkedList();
            //linkedList.AddNodeToFront(5);
            //linkedList.AddNodeToFront(6);
            //linkedList.AddNodeToFront(1);
            //linkedList.AddNodeToFront(11);


            ///Single linked list... add to end..
            //linkedList.AddNodeToEnd(1);
            //linkedList.AddNodeToEnd(2);
            //linkedList.AddNodeToEnd(3);
            //linkedList.AddNodeToEnd(4);

            //linkedList.PrintList();

            //Console.WriteLine(6%3);

            //I need to still learn following code from linked list...
            //LinkedList1 lList = new LinkedList1();
            //lList.head = new LinkedList1.Node(1);
            //LinkedList1.Node second = new LinkedList1.Node(2);
            //LinkedList1.Node third = new LinkedList1.Node(3);

            //lList.head.next = second;
            //second.next = third;

            //MatrixSpiralCode objMSC = new MatrixSpiralCode();
            //objMSC.matrixspiralCode();

            
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************");
            //Console.WriteLine("Enter single character for comparision:");
            //char ch = 'c';
            //char Firstchar = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Enter Second character for comparision:");
            //char Secondchar = Convert.ToChar(Console.ReadLine());

            //if (Firstchar > Secondchar)
            //{ Console.WriteLine("True"); }
            //else
            //  Console.WriteLine("False");

            LinkedListt llistt = new LinkedListt();
            //llistt.; = new 

            //MatrixTicTacToe objTicTacToe = new MatrixTicTacToe();
            //objTicTacToe.matrixTicTacToe();

            // new linear search....
            //LinearSearch1 objLinearSearch1 = new LinearSearch1();
            //objLinearSearch1.linearSearchMain();


            //string parenthesis = "(()";
            //Stack<char> objStack = new Stack<char>(parenthesis);

            //for ( int i = 0; i <= objStack.Count-1; i++)
            //{
            //    if (objStack<char>[i] == '(')
            //    { 

            //    }
            //}

            // int[] nums1 = {3, 1, 2, 4 };
            //SortArrayByParity(nums1);

            //int[] SortArrayByParity(int[] nums )
            //{
            //    int[] reultArray = new int[nums.Length];
            //    int k = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] % 2 == 0)
            //        {
            //            reultArray[k] = nums[i];

            //            k++;
            //        }
            //    }

            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[j] % 2 == 1)
            //        {
            //            reultArray[k] = nums[j];

            //            k++;
            //        }
            //    }

            //    Console.WriteLine(string.Join(",", reultArray));
            //    return reultArray;
            //}
            Console.WriteLine("*********************Start Transpose need to move in the class*******************************");
            int[,] matrix1 = { { 2, 4, -1 }, { -10, 5, 11}, { 18, -7, 6} };
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
                        Console.Write(ansMatrix[i,j] + ",");
                    }
                    Console.WriteLine();
                }
                
            }

            Console.WriteLine("*********************End Transpose need to move in the class*******************************");

            // TransponseMatrix1 transponseMatrix = new TransponseMatrix1();
            //int [][] inptArray = transponseMatrix.transposeMatrix();

            //  PlusOne objPlusOne = new PlusOne();
            //int [] resultArray =  objPlusOne.plusOne();

            //SearchingChallenge objsearchingChallenge = new SearchingChallenge();
            //objsearchingChallenge.searchingChallenge();

            string[] objString = new string[] { "01111", "01101", "00011", "11110" };
            
            

            char[][] result = objString.Select(item => item.ToArray()).ToArray();

            int row2 = objString.Length;
            int col2 = objString[0].Length;

            char[,] solchar = new char[row2, col2];

            int[,] solArray = new int[row2, col2];

            for (int i = 0; i < row2; i++ )
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    solArray[i, j] = Convert.ToInt32(result[i][j]);
                   // solchar = (objString[i, j]);
                    // string str = objString[i, j];
                    //solArray[i, j] = Convert.ToInt32(str);

                }
            }
            ///check and remove following............................. 
            //FizzBuzz objFizzBuzz = new FizzBuzz();
            //objFizzBuzz.fizzBuzz(3);

            //TitleToNumber objTitleToNumber = new TitleToNumber();
            //objTitleToNumber.titleToNumber("AC");

            //char[] s = { 'H', 'e', 'l', 'l', 'o' };
            //ReverseStringleetCode objreverseStringleetCode = new ReverseStringleetCode();
            //objreverseStringleetCode.reverseString(s);

            ReverseWords objreverseWords = new ReverseWords();
            objreverseWords.reverseWords("blank");

            DictionaryOne objDicOne = new DictionaryOne();
            objDicOne.dictionaryOne();


            int removeThis = 0;

           // Console.ReadKey();
            Console.ReadLine();
        }

        public class LinkedListt 
        {
            Node head;
            public class Node {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            
            }
        }
        
        static void removeDuplicate(char[] CharArry, int b)
        {
            string str = new string(CharArry);
           // List<string> listStr = new List<string>(str);
            //int index = 0;
            int i=0, j;

            while (i < b)
            {
                j = i;

                char  c =  str[i];

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
