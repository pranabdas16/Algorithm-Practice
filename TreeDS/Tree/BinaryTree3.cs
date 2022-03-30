using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
    /// <summary>
    /// Reference...
    /// https://www.codeguru.co.in/2015/03/how-to-create-binary-tree-in-c.html
    /// http://csharpexamples.com/c-binary-search-tree-implementation/
    /// </summary>
    public class BinaryTree3
    {
        public Node3 root;
        public BinaryTree3()
        {
            root = null;
        }

        public void Insert(int element)
        {
            if (root == null)
            {
                root = new Node3(element);
                return;
            }
            else
                InsertRec(root, new Node3(element));
        }

        private void InsertRec(Node3 Root, Node3 element)
        {
            if (Root == null)
                Root = element;

            if (element.Data < Root.Data)
            {
                if (Root.LeftNode == null)
                    Root.LeftNode = element;
                else
                    InsertRec(Root.LeftNode, element);
            }
            else
            {
                if (Root.RightNode == null)
                    Root.RightNode = element;
                else
                    InsertRec(Root.RightNode, element);
            }
        }

        public void TraversePreOrder(Node3 parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node3 parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.RightNode);
            }
        }
        public void TraversePostOrder(Node3 parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
