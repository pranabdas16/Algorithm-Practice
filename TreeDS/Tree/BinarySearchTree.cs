using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class BinarySearchTree
    {
        public BSTNode Root;

        public void AddValue(int element)
        {
            if (Root == null)
            {
                Root = new BSTNode(element);
            }
            else
            {
                AddValue(element, Root);
            }
        }
        protected void AddValue(int element, BSTNode CurrentRoot)
        {
            if (element >= CurrentRoot.Value)
            {
                AddtoRight(element, CurrentRoot);
            }
            else
            {
                AddtoLeft(element, CurrentRoot);
            }
        }

        protected void AddtoRight(int element, BSTNode CurrentRoot)
        {
            if (CurrentRoot.RightNode== null)
            {
                CurrentRoot.RightNode = new BSTNode(element);
            }
            else
            {
                AddValue(element, CurrentRoot.RightNode);
            }
        }

        protected void AddtoLeft(int element, BSTNode CurrentRoot)
        {
            if (CurrentRoot.LeftNode == null)
            {
                CurrentRoot.LeftNode = new BSTNode(element);
            }
            else
            {
                AddValue(element, CurrentRoot.LeftNode);
            }
        }
        //Left.Node, root, right.Node
        public void InOrderTraversal()
        { 
            
        }

        // Root, Left, right
        public void PreOrder()
        {

        }

        //left, right, root
        public void PostOrder()
        { 
        
        }
    }
}
