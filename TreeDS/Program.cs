using System;
using TreeDS.Tree;

namespace TreeDS
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            Console.WriteLine("***************Binary Tree1*******************");
            BinaryTree7 obj = new BinaryTree7();
            obj.AddNode(25);
            obj.AddNode(15);
            obj.AddNode(50);
            obj.AddNode(10);
            obj.AddNode(22);
            obj.AddNode(35);
            obj.AddNode(70);
            obj.AddNode(4);
            obj.AddNode(12);
            obj.AddNode(18);
            obj.AddNode(24);
            obj.AddNode(31);
            obj.AddNode(44);
            obj.AddNode(66);
            obj.AddNode(90);
            Console.WriteLine();
            obj.printInorder(obj.root);


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

            //BinaryTree objBinaryTree = new BinaryTree();
            //objBinaryTree.AddNode(1);
            //objBinaryTree.AddNode(2);
            //objBinaryTree.AddNode(7);
            //objBinaryTree.AddNode(3);
            //objBinaryTree.AddNode(10);
            //objBinaryTree.AddNode(5);
            //objBinaryTree.AddNode(8);

            //Console.WriteLine("PreOrder Traversal:");
            //objBinaryTree.TraversePreOrder(objBinaryTree.Root);
            //Console.WriteLine();

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
