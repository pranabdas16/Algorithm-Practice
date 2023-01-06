using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// </summary>
    public class GetIntersectionNode
    {
        public ListNode getIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode p1 = headA;
            ListNode p2 = headB;

            while (p1 != p2)
            {
                p1 = p1 == null ? headB : p1.next;
                p2 = p2 == null ? headA : p2.next;
            }
            return p1;
        }

        public ListNode getIntersectionNode1(ListNode headA, ListNode headB)
        {
            ListNode p1 = headA;
            ListNode p2 = headB;
            // Dictionary<int >
            return p1;
        }
    }
}
