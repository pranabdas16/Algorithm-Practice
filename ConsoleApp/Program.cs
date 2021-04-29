using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Simple_problem;
using ConsoleApp.Hacker_Rank_challanges_and_extra;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter the string/Int:");
            //string myString = Console.ReadLine().ToString();
            // int vlaue = int.Parse(Console.ReadLine());

            ///sort string call function.....
            //SortString objSortSring = new SortString();
            //objSortSring.shortstring(myString);

            /// Reverse string......
            //ReverseString objReverseString = new ReverseString();
            //objReverseString.reverseString(myString);

            ///Reverse integer value...
            //int value = Convert.ToInt32(myString);
            //StackIntSimple objIntStack = new StackIntSimple();
            //objIntStack.stackIntegerSimple(value);

            //int[] arr = new int[] { 1, 2, 3, 4 };
            //Stack<int> myStack = new Stack<int>(arr);

            //foreach (var item in myStack)
            //    Console.Write(item + ","); //prints 4,3,2,1, 

            ///Reverse integer value.....
            //int var = int.Parse(Console.ReadLine());
            //ReverseInteger objrevInt = new ReverseInteger();
            //objrevInt.reverseInteger(var);

            ///Check for palindrome of integer value
            //Palindrome obj = new Palindrome();
            //obj.palindrome();

            /// Roman to interger
            //RomanToInteger obj = new RomanToInteger();
            //obj.romanToInteger();

            ///Two sum Array...
            //TwoSumArray obj = new TwoSumArray();
            //obj.twoSumArray();

            ///Find longest common Prefix using character by charcter matching....
            //String[] arr = {"geeksforgeeks", "geeks",
            //"geek", "geezer" };
            //int n = arr.Length;

            //commonPrefix obj = new commonPrefix();

            //string ans = obj.CommonPrefix(arr, n);

            //if (ans.Length > 0)
            //{
            //    Console.WriteLine("The longest common prefix is:" + ans);
            //}
            //else
            //{
            //    Console.WriteLine("There is no common prefix");
            //}
            //Console.ReadLine();

            ///Valid Parenthesis
            ///Given a string containing just the charcters (, ), {, }, [ and ] detemine if the input sting is valid.
            //validParenthesis obj = new validParenthesis();
            //obj.isValidReview();

            ///Stack exercise....
            ///integer stack
            StackExercise obj = new StackExercise();
            //obj.stackofInt();

            ///Stack of int Array use....
           // obj.stackOfIntArry();

            ///Stack of String Array use...
           // obj.stackOfStringArray();

            ///Single Linked list with multiple action..
            
            ///Single linked list to add 
            LinkedList linkedList = new LinkedList();
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

            //SumOfOneDArray objS= new SumOfOneDArray();
            //objS.sumOfOneDArray();

            //LongestUniqueSubsttr objLngUnqsubstr = new LongestUniqueSubsttr();
            //objLngUnqsubstr.longestUniqueSubsttr();

            //AVeryBigSum objBigSum = new AVeryBigSum();
            //objBigSum.aVeryBigSum();

            //Staircase objStaircase = new Staircase();
            //objStaircase.staircase();

            //MiniMaxSum OjbMinMaxSum = new MiniMaxSum();
            //OjbMinMaxSum.miniMaxSum();

            //Console.WriteLine(6%3);

            //Console.ReadLine();
        }

    //static void reverse(int x)
    //{
    //    long res = 0;
    //    while (x != 0)
    //    {
    //        res = res * 10 + x % 10;
    //        x = x / 10;
    //    }

    //    if (res < int.MinValue || res > int.MaxValue)
    //    {
    //        //return 0;
    //        Console.Write("");
    //    }
    //    else {
    //        Console.Write(res);
    //    }
    //}
    static void removeDuplicate(char[] CharArry, int b)
        {
            string str = new string(CharArry);
           // List<string> listStr = new List<string>(str);
            string newStr="";
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
            
                Console.Write(str);
            
            Console.ReadLine();



            //for ( i = 0; i < b; i++)
            //{
            //    for ( j = i+1; j < b; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
                        
            //            break;
            //        }
                    
            //    }
            //    if(j<b)
            //    if(str[i] == str[j])
            //    {
            //        //do nothhing;
            //    }
            //    else
            //    str[index++] = str[i];
            //    //if (j == i)
            //    //{
            //    //    str[index++] = str[i];
            //    //}


            //}
            //while()
            //for (int k = 0; k < index; k++)
            //    Console.Write(str[index]);
            //Console.ReadLine();
        }
    }
}
