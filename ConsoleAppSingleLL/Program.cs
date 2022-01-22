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

            // MyLinkedList objMyLL = new MyLinkedList();
            //objMyLL.AddToEnd(5);
            //objMyLL.AddToEnd(9);
            //objMyLL.AddToEnd(12);
            //objMyLL.AddToEnd(17);

            //objMyLL.AddToBeginning(5);
            //objMyLL.AddToBeginning(9);
            //objMyLL.AddToBeginning(12);
            //objMyLL.AddToBeginning(17);

            //objMyLL.Print();

            //SingleNode objSingleNode = new SingleNode();

            singleListNode objSingleNode = new singleListNode(7);
            objSingleNode.AddToEnd(8);
            objSingleNode.AddToEnd(10);
            objSingleNode.AddToEnd(12);

            objSingleNode.Print();

            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            //SinglLinkedList objSLL = new SinglLinkedList();
            //objSLL.AddLast(101);
            //objSLL.AddLast(102);
            //objSLL.AddFront(100);
            //objSingleNode.AddLast(10);
            //objSingleNode.AddLast(15);
            //objSingleNode.AddLast(7);
            //objSingleNode.Print();

            //objSingleNode = new SingleNode(47);

            //Console.WriteLine();
            //Console.WriteLine("**********************************************************************************");
            //Console.WriteLine("**********************************************************************************");

            //SinglLinkedList objSLL = new SinglLinkedList();
            //objSLL.AddLast(101);
            //objSLL.AddLast(102);
            //objSLL.AddLast(104);
            //objSLL.AddLast(106);
            //objSLL.AddLast(110);
            //objSingleNode.AddLast(10);
            //objSingleNode.AddLast(15);
            //objSingleNode.AddLast(7);
            //objSingleNode.Print();

            //objSLL.Print();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************");
           // objSLL.Reverse();

            //objSLL.Print();
            //Console.WriteLine();
            //objSLL.RemoveFirst();
            //objSLL.RemoveLast();

            //objSLL.Reverse();

            //objSLL.Print();


            //SinglyNode objSlyNode = new SinglyNode(5);
            //objSlyNode.AddToEnd(7);
            //objSlyNode.AddToStart(3);

            //objSlyNode.AddToEnd(8);
            //objSlyNode.AddToEnd(10);
            //objSlyNode.AddToEnd(12);
            //objSlyNode.Print();

            Console.ReadLine();
            
        }
    }
}
