using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankConsoleApp
{
    class Program
    {
        //int age;
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //Remove this below code in the region...
            #region 
            Dictionary<string, int> nameNumber = new Dictionary<string, int>();
            List<string> searchStr = new List<string>();
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            string key, value;
            for (int i = 0; i < n; i++)
            {
                string phrase = Console.ReadLine().ToString();
                string[] word = phrase.Split(' ');
                nameNumber.Add(word[0], Convert.ToInt32(word[1]));
            }
            for (int i = 0; i < n; i++)
            {
                searchStr.Add(Console.ReadLine().ToString());
            }
            for (int i = 0; i < n; i++)
            {
                if (nameNumber.Keys.Contains(searchStr[i]))
                {
                    Console.WriteLine($"{nameNumber.ElementAt(i).Key} = {nameNumber.ElementAt(i).Value}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            #endregion

            #region linked list sectin.... commnenting for now...
            //    SinglyLinkedList llist = new SinglyLinkedList();
            //    Console.WriteLine("Enter number of List:");
            //    int llistCount = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < llistCount; i++)
            //    {
            //        int llistItem = Convert.ToInt32(Console.ReadLine());
            //        llist.InsertNode(llistItem);
            //    }

            //    int data = Convert.ToInt32(Console.ReadLine());

            //    int position = Convert.ToInt32(Console.ReadLine());

            //    SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            //    //PrintSinglyLinkedList(llist_head, " ", textWriter);
            //    //textWriter.WriteLine();

            //    //textWriter.Flush();
            //    //textWriter.Close();
            //}

            //class SinglyLinkedListNode
            //{
            //    public int data;
            //    public SinglyLinkedListNode next;

            //    public SinglyLinkedListNode(int nodeData)
            //    {
            //        this.data = nodeData;
            //        this.next = null;
            //    }
            //}

            //class SinglyLinkedList
            //{
            //    public SinglyLinkedListNode head;
            //    public SinglyLinkedListNode tail;

            //    public SinglyLinkedList()
            //    {
            //        this.head = null;
            //        this.tail = null;
            //    }

            //    public void InsertNode(int nodeData)
            //    {
            //        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            //        if (this.head == null)
            //        {
            //            this.head = node;
            //        }
            //        else
            //        {
            //            this.tail.next = node;
            //        }

            //        this.tail = node;
            //    }
            //}

            //static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
            //{
            //    while (node != null)
            //    {
            //        textWriter.Write(node.data);

            //        node = node.next;

            //        if (node != null)
            //        {
            //            textWriter.Write(sep);
            //        }
            //    }
            //}


            //    /*
            //     * Complete the 'insertNodeAtPosition' function below.
            //     *
            //     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
            //     * The function accepts following parameters:
            //     *  1. INTEGER_SINGLY_LINKED_LIST llist
            //     *  2. INTEGER data
            //     *  3. INTEGER position
            //     */

            //    /*
            //     * For your reference:
            //     *
            //     * SinglyLinkedListNode
            //     * {
            //     *     int data;
            //     *     SinglyLinkedListNode next;
            //     * }
            //     *
            //     */

            //    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
            //    {
            //        SinglyLinkedListNode newNod = new SinglyLinkedListNode(data);
            //        SinglyLinkedListNode currNod = llist;
            //        SinglyLinkedListNode  nextNode, postNode, tempNode = null;
            //        tempNode= postNode = llist;

            //        for (int i = 1; i <= position; i++)
            //        {
            //            tempNode = tempNode.next;
            //            nextNode = tempNode;
            //            if (i == position)
            //            {

            //            nextNode.next = newNod;

            //                currNod.next = postNode;

            //            }
            //        currNod = currNod.next;
            //        }
            //        return null;
            //    }
            #endregion
        }
    }
}

