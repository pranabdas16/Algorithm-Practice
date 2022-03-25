using System;
using TreeDS.Tree;

namespace TreeDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Binary Tree*******************");

            BinaryTree2 objBinaryTree = new BinaryTree2();
            objBinaryTree.Add(1);
            objBinaryTree.Add(2);
            objBinaryTree.Add(7);
            objBinaryTree.Add(3);
            objBinaryTree.Add(10);
            objBinaryTree.Add(5);
            objBinaryTree.Add(8);

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
