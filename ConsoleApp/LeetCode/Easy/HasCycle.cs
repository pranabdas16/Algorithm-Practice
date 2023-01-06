using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// 
    /// </summary>
    /// 
 /**
 * Definition for singly-linked list.
 * public class ListNode
    {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x)
        {
            *val = x;
            *next = null;
            *     }
 * }
 */
    public class HasCycle
    {
        public bool hasCycle2(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }
        public bool hasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode fast = head;
            ListNode slow = head;
            do
            {
                if (fast.next == null || fast.next.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            } while (slow != fast);
            return true;
        }

        public bool hasCycle1(ListNode head)
        {
            ListNode tempNode = new ListNode();
            tempNode = head;
            Dictionary<int, int> visited = new Dictionary<int, int>(); 
            while (tempNode != null)
            {
                int val = tempNode.val;
                if (visited.ContainsKey(val))
                {
                    return true;
                }
                else
                {
                    visited.Add(val, 1);
                }
                tempNode = tempNode.next;
            }
            return false;
        }
    }
}
