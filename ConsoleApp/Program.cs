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

            int[] arr = { 1, 2, 3, 4, 5, 6,7};
            int mid = 1 + (arr.Length - 1) / 2;
            int x = 3;
            int val = -1;
            Console.WriteLine("Mid value of of array : " + mid);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    val = i;
                }
            }
            Console.WriteLine("Linear search for given array: " + val);
            Console.WriteLine("Power value of 2 ^ 4 is here:"  + Math.Pow(2, 4));
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************");
            

            Console.ReadKey();
            Console.ReadLine();
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
