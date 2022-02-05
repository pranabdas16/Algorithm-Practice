using System;

namespace ConsoleAppDoubbleLL
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList1 objDLL = new DoublyLinkedList1();

            objDLL.AddToFront1(5);
            objDLL.AddToFront1(7);
            objDLL.AddToFront1(10);
            objDLL.PrintdoublyLinkedList();
            Console.WriteLine();
            Console.WriteLine("******************");
            objDLL.AddToTail1(15);
            objDLL.AddToTail1(25);
            objDLL.AddToTail(35);
            objDLL.AddToTail(45);
            objDLL.AddToTail(55);
            objDLL.AddToTail(65);
            objDLL.AddToTail(75);
            objDLL.AddToTail(85);
            objDLL.PrintdoublyLinkedList();
            Console.WriteLine();
            Console.WriteLine("******************");
            //objDLL.RemoveHeadNode();
            Console.Write("List after Head removed:");
            objDLL.PrintdoublyLinkedList();
            Console.WriteLine();
            Console.WriteLine("******************");
            objDLL.RemoveHeadNode1();
            //objDLL.RemoveLastNode();
            Console.Write("List after Head removed:");
            objDLL.PrintdoublyLinkedList();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
