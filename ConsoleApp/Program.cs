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
    public class Program
    {

        public ListNode ReverseList(ListNode head)
        {
            ListNode Head;
            ///
             void AddToHead(int element)
            {
                ListNode newNode = new ListNode();
                newNode.val = element;
                newNode.next = Head;

                Head = newNode;
                //Count++;
            }

             void AddToTail(int element)
            {
                ListNode tempNode = new ListNode();
                tempNode = Head;

                ListNode newNode = new ListNode();
                newNode.val = element;
                newNode.next = null;

                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
                //Count++;
            }

            ////
            ListNode tempStart = head;

            ListNode newList = new ListNode();


            return tempStart;

        }
        #region start the merge two list.....
        public class ListNode
        {
            public int val;      
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        

        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode dummy = new ListNode(0);
                ListNode curr = dummy;

                while (list1 != null && list2 != null)
                {
                    if (list1.val <= list2.val)
                    {
                        curr.next = list1;
                        list1 = list1.next;
                    }
                    else {
                        curr.next = list2;
                        list2 = list2.next;
                    }
                    curr = curr.next;
                }
                curr.next = list1 != null ? list1 : list2;
                return dummy.next;
            }
            
        }
        //Removing below node3 after above...
        public class Node31
        {
            public Node31 Next;
            public int Data;


        }

        //Removing below singlelinked list after above....
        public class SingleLinkedList31
        {
            public ListNode Head;

            public SingleLinkedList31()
            {
                Head = null;
            }

            public void Print()
            {
                if (Head == null)
                    Console.WriteLine("List is Empty.");
                else
                {
                    ListNode temp = new ListNode();
                    temp = Head;
                    Console.Write("The list is: ");
                    while (temp != null)
                    {
                        Console.Write("|" + temp.val + "|->");
                        temp = temp.next;
                    }

                }
            }
            public void AddToFront(int element)
            {
                ListNode temp = new ListNode();
                temp.val = element;
                temp.next = Head;
                Head = temp;
            }

            public void AddToEnd(int element)
            {
                ListNode temp = new ListNode();
                temp.val = element;
                temp.next = null;

                if (Head == null)
                    Head = temp;
                else
                {
                    ListNode temp2 = new ListNode();
                    temp2 = Head;
                    while (temp2.next != null)
                    {
                        temp2 = temp2.next;
                    }
                    temp2.next = temp;
                }

            }
        }

        #endregion

        #region Group anagram code which also need to be removed.
        public class GroupAnagram
        {
            public class mydic
            {
                int intval;
                string strval;
                public mydic()
                { 
                }
                public mydic(int val, string val2)
                {
                    intval = val;
                    strval = val2;
                }
            }
            public void method()
            {
                string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
                Dictionary<string, int> inputList= new Dictionary<string, int>();
                //Dictionary<string, int> inputList1 = new Dictionary<string, int>();

                foreach (string inpStr in strs)
                {
                    int val = 0;
                    for (int i = 0; i < inpStr.Length; i++)
                    {
                        int c = inpStr[i];
                        val += c;
                        if (i == inpStr.Length - 1)
                        {
                            inputList.Add(inpStr, val);
                        }
                    }

                }
                Console.WriteLine("Here is the value");
                int val1 = 0;
                List<string> resultstr = new List<string>();
                int k = 0;
                // ILookup<string, int> inputList1 = (ILookup<string, int>)inputList.ToLookup(x => x.Value, x => x.Key);

                for (int i = 0; i < inputList.Count; i++)
                { 
                   // if(inputList)
                
                }
                foreach (var couple in inputList)
                {
                    int val2 = couple.Value;
                    if (val1 == val2)
                    {
                        resultstr.Add(couple.Key.ToString());
                    }
                    else
                    {
                        resultstr.Add(couple.Key.ToString());
                    }
                    val1 = val2;
                }
            }
        }

        #endregion

        class InsertionSort
        {
            // Function to sort array
            // using insertion sort
            public void sort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    // Move elements of arr[0..i-1],
                    // that are greater than key,
                    // to one position ahead of
                    // their current position
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
            }

            // A utility function to print
            // array of size n
            public void printArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");

                Console.Write("\n");
            }
        }



        private static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("My new new new  new code run here");
            int a = 2, b = 3;
            GetSum objGS = new GetSum();
            objGS.getSum2(a, b);

            int[] val1 = { 2, 4, 3, 5, 7 };
            int[] val2 = { 5, 6, 4 };
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode();
            string str = "Hello there";
            int lngth = str.Length;
            Console.WriteLine($"Here is the string:{str.Substring(0, lngth-1)}");
            string num1 = "11", num2 ="123";
            AddStrings objADS = new AddStrings();
            objADS.addStrings(num1, num2);
            
            //for (int i = 0; i < val1.Length; i++)
            //{
            //    ListNode tempNode = new ListNode(val1[i]);
            //    l1 = tempNode;
            //    //l1 = l1.next;
                
            //}
            for (int i = 0; i < val1.Length; i++)
            {
                ListNode tempNode = new ListNode();
                tempNode.val = val1[i];
                tempNode.next = null;
                while (l1.next != null)
                {
                    l1 = l1.next;
                }
                l1.next = tempNode;

            }

            
            AddTwoNumbers1 objATN = new AddTwoNumbers1();
            


            //int exceval = 89;
            //ConvertToTitle objCTT = new ConvertToTitle();
            //objCTT.convertToTitle(exceval);

            int[] arr = { 9, 7, 1, 2, 6};
            InsertionSort obj1 = new InsertionSort();
            obj1.sort(arr);
            obj1.printArray(arr);

            Console.WriteLine();
            Console.WriteLine("*****************************");
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
            LongestCommonPrefix obj = new LongestCommonPrefix();
            obj.longestCommonPrefix();








            Console.WriteLine();
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