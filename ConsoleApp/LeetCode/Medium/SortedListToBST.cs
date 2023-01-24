using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/description/
    /// </summary>
    /// Reference
    /// https://miafish.wordpress.com/2015/01/28/leetcode-oj-c-convert-sorted-list-to-binary-search-tree/
    /// Reference

    // Definition for singly-linked list.
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
 
     // Definition for a binary tree node.
      public class TreeNode {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
              this.val = val;
              this.left = left;
              this.right = right;
          }
      }
     
    public class SortedListToBST
    {
        public TreeNode sortedListToBST(ListNode head)
        {
            var values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            return SortedArrayToBST(values.ToArray(), 0, values.Count - 1);
        }

        private TreeNode SortedArrayToBST(int[] values, int low, int high)
        {
            if (low > high)
            {
                return null;
            }

            var mid = (high - low) / 2 + low;
            var root = new TreeNode(values[mid])
            {
                left = SortedArrayToBST(values, low, mid - 1),
                right = SortedArrayToBST(values, mid + 1, high)
            };

            return root;
        }

    }
}
