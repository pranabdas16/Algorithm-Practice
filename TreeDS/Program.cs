using System;
using TreeDS.Tree;

namespace TreeDS
{
    class Program
    {
        public class Node
        {
            public int Data;
            public Node LeftNode;
            public Node RightNode;

            public Node()
            { 
            }

            public Node(int element)
            {
                Data = element;
            }
        }

        public class BinaryTree
        {
            public Node Root;
            public BinaryTree()
            {
                Root = null;
            }

            public void AddNode(int elelment)
            {
                if (Root == null)
                {
                    Root = new Node(elelment);
                }
                else
                {
                    AddNodeRec(Root, new Node(elelment)); 
                }
            }

            public void AddNodeRec(Node Root, Node val)
            {
                if (Root.Data > val.Data)
                {
                    if (Root.LeftNode == null)
                    {
                        Root.LeftNode = val;
                        return;
                    }
                    else
                        AddNodeRec(Root.LeftNode, val);
                }
                else
                {
                    if (Root.RightNode == null)
                    {
                        Root.RightNode = val;
                        return;
                    }
                    else
                        AddNodeRec(Root.RightNode, val);
                }
            }

            public void TraversePreOrder(Node parent)
            {
                if (parent != null)
                {
                    Console.WriteLine(parent.Data + " ");
                    TraversePreOrder(parent.LeftNode);
                    TraversePreOrder(parent.RightNode);
                }
            }
        }
        static void Main(string[] args)
        {
        

            Console.WriteLine("***************Binary Tree*******************");
            


            Console.WriteLine("***************String*******************");
            string str = null;
            string retString = null;
            str = "C# string substring examples here to understand";
            retString = str.Substring(10, 2);
            retString = str.Substring(10);
            retString = str.Substring(11, 12);
            Console.WriteLine(retString);
           









            Console.WriteLine("***************Binary Tree*******************");

            //BinaryTree5 bT5 = new BinaryTree5();
            //bT5.AddNode(7);
            //bT5.AddNode(3);
            //bT5.AddNode(15);
            //bT5.AddNode(6);
            //bT5.AddNode(18);
            //bT5.AddNode(8);
            //bT5.TraversePreOrder(bT5.Root);
            //bT5.TraverseInOrder(bT5.Root);
            //bT5.TraversePostOrder(bT5.Root);

            BinaryTree objBinaryTree = new BinaryTree();
            objBinaryTree.AddNode(1);
            objBinaryTree.AddNode(2);
            objBinaryTree.AddNode(7);
            objBinaryTree.AddNode(3);
            objBinaryTree.AddNode(10);
            objBinaryTree.AddNode(5);
            objBinaryTree.AddNode(8);

            Console.WriteLine("PreOrder Traversal:");
            objBinaryTree.TraversePreOrder(objBinaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("***************2nd Binary Tree*******************");
            BinaryTree3 objBT3 = new BinaryTree3();
            objBT3.Insert(15);
            objBT3.Insert(7);
            objBT3.Insert(17);
            objBT3.Insert(16);
            objBT3.Insert(21);
            objBT3.Insert(2);
            objBT3.Insert(8);

            Console.WriteLine("PreOrder Traversal Second Tree:");
            objBT3.TraversePreOrder(objBT3.root);
            Console.WriteLine();

        }
    }
}
