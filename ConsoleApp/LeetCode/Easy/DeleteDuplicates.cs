using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
    /// </summary>  
    public class ListNode
    {
      public int val;
      public ListNode next;
      //public ListNode(int val = 0, ListNode next = null)
      //  {
      //      this.val = val;
      //      this.next = next;
      //  }
    }
    public class DeleteDuplicates
    {
        ListNode head = new ListNode();

        public DeleteDuplicates()
        {
            //create new temp node...
            ListNode tempNode = new ListNode();
            // Add value to the node....
            //tempNode.val = 1;
            //tempNode.next = null;
            //Set the head as next if there is already value in the head...
           // tempNode.next = head;
            //Set the temp node as head....
            head = tempNode;

            AddtoTail(1);
            AddtoTail(1);
            AddtoTail(1);
            //AddtoTail(3);
            //AddtoTail(3);
            //AddtoTail(0);
            //AddtoTail(4);
            //AddtoTail(5);
            //AddtoTail(5);
            //AddtoTail(6);
            head = head.next;
            PrintList();
            Console.WriteLine();
            deleteDuplicates(head);
            //PrintList();
            Console.WriteLine();
            Console.WriteLine("End of the code");
        }

        public void PrintList()
        {
            ListNode tempNode = new ListNode();
            tempNode = head;
            Console.WriteLine("Here is the list:");
            while (tempNode != null)
            {
                Console.Write($"| {tempNode.val} |->");
                tempNode = tempNode.next;
            }
        }

        //Add to tail on the list...
        public void AddtoTail(int element)
        {
            ListNode tempNode = head;
            
            ListNode newNode = new ListNode();
            newNode.val = element;
            newNode.next = null;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = newNode;
            //head = tempNode;
        }

        public ListNode deleteDuplicates1(ListNode head)
        {
           
                ListNode tempNode = new ListNode();
                tempNode = head;
            try
            {
                while (tempNode != null)
                {
                    ListNode tempNode1 = tempNode.next;
                    if (tempNode.val == tempNode1.val)
                    {
                        if (tempNode.next.next != null)
                        {
                            tempNode.next = tempNode.next.next;
                        }
                        else
                        {
                            tempNode.next = null;
                        }
                    }
                    tempNode = tempNode.next;
                }
            }
            catch
            { }
            PrintList();
            return tempNode;
        }

        //This code working for leet code.
        public ListNode deleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var start = head;
            while (start.next != null)
            {
                if (start.val == start.next.val)
                {
                    start.next = start.next.next;
                }
                else
                {
                    start = start.next;
                }
            }

            return head;

        }
    }
}
