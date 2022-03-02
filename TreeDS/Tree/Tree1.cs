using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class Tree1
    {
        TreeNode1 Top;
        public Tree1()
        {
            Top = null;
        }

        public Tree1(int element)
        {
            Top = new TreeNode1(element);
        }

        public void Add(int element)
        {
            //Non-recursive to Add
            if (Top == null)
            {
                TreeNode1 objTreeNode = new TreeNode1(element);
                Top = objTreeNode;
                return;
            }
            TreeNode1 currNode = Top;
            bool added = false;
            while (!added)
            {
                //traverse tree
                if(element < currNode.Value)
                {
                    //go left
                    if (currNode.Left == null)
                    {
                        TreeNode1 newNode = new TreeNode1(element);
                        currNode.Left = newNode;
                        added = true;
                    }
                    else
                    {
                        currNode = currNode.Left;
                    }
                }
                if (element >= currNode.Value)
                {
                    if (currNode.Right == null)
                    {
                        TreeNode1 newNode = new TreeNode1(element);
                        currNode.Right = newNode;
                        added = true;
                    }
                    else 
                    {
                        //go right
                        currNode = currNode.Right;
                    }
                }
            }
        }

        public void AddRec(int element)
        {
            //Recurion to Add 
            
            AddRef(ref Top, element);

        }

        private void AddRef(ref TreeNode1 N, int elelment )
        { 
            //private recursive search for where to add the new node..
            if(N == null)
            {
                TreeNode1 newNode = new TreeNode1(elelment);
                N = newNode;
                return;
            }
            if (elelment < N.Value)
            {
                AddRef(ref N.Left, elelment);
                return;
            }
            if (elelment > N.Value)
            {
                AddRef(ref N.Right, elelment);
                return;
            }
        }

        public void Print(TreeNode1 N, ref string s)
        {
            if (N == null) { N = Top; }
            if (N.Left != null)
            {
                Print(N.Left, ref s);
                s = s + N.Value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.Value.ToString().PadLeft(3);
            }
            if (N.Right != null)
            {
                Print(N.Right, ref s);
            }
        }
    }
}
