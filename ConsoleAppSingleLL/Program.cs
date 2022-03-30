using System;
using ConsoleAppSingleLL;
using ConsoleAppSingleLL1;

namespace ConsoleAppSingleLL
{
    class Program
    {
        public class SingleNode
        {
            public int Data;
            public SingleNode Next;

        }

        public class SingleList
        {
            public SingleNode Head;

            public void AddToTop(int element)
            {
                SingleNode objNewNode = new SingleNode();
                objNewNode.Data = element;
                objNewNode.Next = Head;
                Head = objNewNode;
            }

            public void AddToTail(int element)
            {
                SingleNode objNewNode = new SingleNode();
                objNewNode.Data = element;
                objNewNode.Next = null;

                if (Head == null)
                {
                    Head = objNewNode;
                }
                else
                {
                    SingleNode tempNode = new SingleNode();
                    tempNode = Head;
                    while (tempNode.Next != null)
                    {
                        tempNode = tempNode.Next;
                    }
                    tempNode.Next = objNewNode;
                }
            }

            public void PrintSingleList()
            {
                SingleNode tempNode = new SingleNode();
                tempNode = Head;
                if (Head == null)
                {
                    Console.Write("List is empty");
                }
                else
                {
                    while (tempNode != null)
                    {
                        Console.Write($"{tempNode.Data} |->");
                        tempNode = tempNode.Next;
                    }
                }
            }

        }
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

            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");
            SingleList obj = new SingleList();
            obj.AddToTop(5);
            obj.AddToTop(3);
            obj.AddToTop(1);
            obj.AddToTail(7);
            obj.PrintSingleList();
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
            //SingleLinkedList1 obj = new SingleLinkedList1();
            //obj.AddFront(10);
            //obj.AddFront(8);
            //obj.AddFront(1);
            //obj.Print();
            //obj.AddLast(11);
            //obj.Print();

            //SingleLinkedList2 objSSL2 = new SingleLinkedList2();
            //objSSL2.PrintList();
           // objSSL2.AddTohead(15);
            //objSSL2.AddTohead(10);
            //objSSL2.AddTohead(12);
           // objSSL2.PrintList();
            Console.WriteLine();
            //objSSL2.AddToLast(15);
            //objSSL2.AddToLast2(12);
            //objSSL2.AddToLast(10);
            //objSSL2.AddToLast2(7);
            //objSSL2.AddToLast(6);
            //objSSL2.AddToLast2(2);
            //objSSL2.PrintList();
            //objSSL2.SortAssending();
            Console.WriteLine();
            //Console.WriteLine("Below is sorted linked list:");
            //objSSL2.PrintList();

            Console.WriteLine();
            Console.WriteLine("**************************Linked List 3*************************");
            SingleLinkedList5 SSL5 = new SingleLinkedList5();
            SSL5.AddToFront(4);
            SSL5.AddToFront(5);
            SSL5.AddToTail(6);
            SSL5.PrintList();
            Console.WriteLine();
            Console.WriteLine("***");
            //SSL4.AddtoFrontWithougHead(7);
            SSL5.AddToTail(7);
            SSL5.AddToTail(9);

            SSL5.PrintList();

            SSL5.reverseList();
            Console.WriteLine();
            Console.WriteLine("***");
            SSL5.PrintList();
            Console.WriteLine("**************************Linked List 4*******************************");
            SingleLinkedList6 objSSL6 = new SingleLinkedList6();
            objSSL6.AddToHead(5);
            objSSL6.AddToHead(4);
            objSSL6.AddToHead(3);
            objSSL6.AddToHead(1);
            objSSL6.AddToTail(7);
            objSSL6.PrintList();
            Console.WriteLine();
            objSSL6.push_at(2, 4);
            objSSL6.PrintList();
            objSSL6.pop_at(6);
            Console.WriteLine();
            objSSL6.PrintList();
            Console.WriteLine("This reverse of list:");
            objSSL6.ReverseList();
            Console.ReadLine();
            
        }
    }
}
