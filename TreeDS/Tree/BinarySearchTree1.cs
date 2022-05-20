using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class BinarySearchTree1
    {
        public BSTNode1 Root;

        public void AddNode(int element)
        {
            if (Root == null)
            {
                Root = new BSTNode1(element);
            }
            else
            {
                if (Root.Data <= element)
                {
                    AddRightNode(new BSTNode1(element), Root);
                }
                else
                {
                    AddlLeftNode(new BSTNode1(element), Root);
                }
            }
        }

        private void AddlLeftNode(BSTNode1 bSTNode1, BSTNode1 root)
        {
            if (bSTNode1.Data < root.Data)
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = bSTNode1;
                }
                else
                {
                    AddlLeftNode(bSTNode1, root.LeftNode);
                }
            }
            else
            {
                AddRightNode(bSTNode1, root.LeftNode);
            }
        }

        private void AddRightNode(BSTNode1 bSTNode1, BSTNode1 root)
        {
            if (bSTNode1.Data >= root.Data)
            {
                if (root.RightNode == null)
                    root.RightNode = bSTNode1;
                else
                {
                    AddRightNode(bSTNode1, root.RightNode);
                }
            }
            else
            {
                AddlLeftNode(bSTNode1, root.RightNode);
            }
        }
    }
}
