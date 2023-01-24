using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/submissions/879538797/
    /// </summary>
// Definition for a binary tree node.
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
         }
     }

    public class SortedArrayToBST
    {
        public TreeNode sortedArrayToBST(int[] nums)
        {
            if (nums == null) return null;
            return GetTreeNode(nums, 0, nums.Length - 1);
        }

        private TreeNode GetTreeNode(int[] nums, int low, int high)
        {
            TreeNode result = null;
            if (low <= high)
            {
                var mid = (low + high) / 2;
                result = new TreeNode(nums[mid]);
                result.left = GetTreeNode(nums, low, mid - 1);
                result.right = GetTreeNode(nums, mid + 1, high);
            }
            return result;
        }
    }
}
