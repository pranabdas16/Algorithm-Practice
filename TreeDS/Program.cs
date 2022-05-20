using System;
using TreeDS.Tree;

namespace TreeDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Binary Tree5*******************");
            BinarySearchTree1 BST = new BinarySearchTree1();
            BST.AddNode(12);
            BST.AddNode(3);
            BST.AddNode(17);
            BST.AddNode(15);
            BST.AddNode(18);
            BST.AddNode(10);
            BST.AddNode(2);



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
