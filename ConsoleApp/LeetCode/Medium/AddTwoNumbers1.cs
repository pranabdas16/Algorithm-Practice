using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
  //  public class ListNode
  //  {
  //    public int val;
  //    public ListNode next;
  //    public ListNode(int val = 0, ListNode next = null)
  //      {
  //          this.val = val;
  //          this.next = next;
  //               }
  //}
    public class AddTwoNumbers1
    {
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode newl1 = l1;
            ListNode newl2 = l2;
            ListNode resultList = new ListNode();
            string str1 = "", str2 = "";
            while (newl1 != null)
            {
                str1 = str1 + (newl1.val).ToString();
                newl1 = newl1.next;
            }
            while (newl2 != null)
            {
                str2 = str2 + (newl2.val).ToString();
                newl2 = newl2.next;
            }
            int resultval = Convert.ToInt32(str1) + Convert.ToInt32(str2);
            List<int> resltLst = new List<int>();
            foreach(char c in resultval.ToString())
            {
                resltLst.Add(Convert.ToInt32(c));
            }
            ListNode head = new ListNode();
            head.val = resltLst[0];
            head.next = null;
            ListNode temp = new ListNode();
            for (int i = 1; i < resltLst.Count; i++)
            {
                temp.val = resltLst[i];
                temp.next = null;
                head = temp;
            }

            return head;
        }
        public ListNode addTwoNumbers1(ListNode l1, ListNode l2)
        {
            ListNode newl1 = l1;
            ListNode newl2 = l2;
            ListNode resultList = new ListNode(0);
            ListNode currentNode = resultList;
            int  carry=0;
            if (l1 == null)
                return l1;
            else if (l2 == null)
                return l2;
            else if (l1 == null && l2 == null)
                return l1;
            else
            {
                while (l1 != null || l2 != null || carry != 0)
                { 
                    int x = l1 != null? l1.val : 0;
                    int y = l2 != null ? l2.val : 0;

                    int sum = carry + x + y;

                    carry = sum / 10;
                    currentNode.next = new ListNode(sum % 10);
                    currentNode = currentNode.next;
                    if (l1 != null)
                        l1 = l1.next;
                    if (l2 != null)
                        l2 = l2.next;
                }
                return resultList.next;
            
            }
            
        }
    }
}
