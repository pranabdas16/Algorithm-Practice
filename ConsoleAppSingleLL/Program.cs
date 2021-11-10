using System;
using ConsoleAppSingleLL;

namespace ConsoleAppSingleLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //LinkedList linkedList = new LinkedList();
            //linkedList.AddNodeToFront(5);
            //linkedList.AddNodeToFront(7);
            //linkedList.AddNodeToFront(1);
            //linkedList.AddNodeToFront(3);
            //linkedList.PrintList();

            //MyLinkListNode objMLLnode = new MyLinkListNode(5);
            //objMLLnode.next = new MyLinkListNode(7);
            //objMLLnode.next.next = new MyLinkListNode(9);
            //objMLLnode.next.next.next = new MyLinkListNode(10);
            //objMLLnode.next.next.next.next = new MyLinkListNode(11);

            //objMLLnode.print();
            //Console.ReadLine();

            //MyLinkListNode objMLLnode1 = new MyLinkListNode(5);
            //objMLLnode1.AddToEnd(90);
            //objMLLnode1.AddToEnd(70);
            //objMLLnode.print();

            MyLinkedList objMyLL = new MyLinkedList();
            //objMyLL.AddToEnd(5);
            //objMyLL.AddToEnd(9);
            //objMyLL.AddToEnd(12);
            //objMyLL.AddToEnd(17);

            objMyLL.AddToBeginning(5);
            objMyLL.AddToBeginning(9);
            objMyLL.AddToBeginning(12);
            objMyLL.AddToBeginning(17);

            objMyLL.Print();


            Console.ReadLine();
            
        }
    }
}
