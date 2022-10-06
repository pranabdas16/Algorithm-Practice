using System;
using System.Collections;
using ConsoleAppSingleLL;
using ConsoleAppSingleLL1;



namespace ConsoleAppSingleLL
{
    class Program
    {
        public class ValidParenthesis
        {
            public void validParenthesis(string s)
            {
                bool result = false;
                Stack stackArray = new Stack();

                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '(':
                            stackArray.Push('(');
                            break;
                        case ')':
                            if (Convert.ToChar(stackArray.Peek()) == '(')
                            {
                                stackArray.Pop();
                            }
                            else
                            {
                                stackArray.Push(')');
                            }
                            break;
                        case '{':
                            stackArray.Push('{');
                            break;
                        case '}':
                            if (Convert.ToChar(stackArray.Peek()) == '{')
                            {
                                stackArray.Pop();
                            }
                            else
                            {
                                stackArray.Push('}');
                            }
                            break;
                        case '[':
                            stackArray.Push('[');
                            break;
                        case ']':
                            if (Convert.ToChar(stackArray.Peek()) == '[')
                            {
                                stackArray.Pop();
                            }
                            else
                            {
                                stackArray.Push(']');
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public class Node8<T> 
        {
            public T Data;
            public Node8<T> Next;        
        }

        public class SingleLinkedList8<T> 
        {
            public Node8<T> Head;
            public int count = 0;

            public void AddHeadToList(T element)
            {
                Node8<T> newNode = new Node8<T>();
                newNode.Data = element;
                newNode.Next = Head;

                Head = newNode;
                count++;
            }

            public void AddToTail(T element)
            {
                Node8<T> newNode = new Node8<T>();
                newNode.Data = element;
                newNode.Next = null;
                if (Head == null)
                    AddHeadToList(element);
                else
                {
                    Node8<T> tempNode = new Node8<T>();
                    tempNode = Head;
                    while (tempNode.Next != null)
                    {
                        tempNode = tempNode.Next;
                    }
                    tempNode.Next = newNode;
                    count++;
                }
            }

            public void ReverseList()
            {
                if (Head != null)
                {
                    Node8<T> preNode, currNode, nextNode = new Node8<T>();
                    preNode = null;
                    nextNode = null;
                    currNode = this.Head;

                    while (currNode != null)
                    {
                        nextNode = currNode.Next;
                        currNode.Next = preNode;

                        preNode = currNode;
                        currNode = nextNode;
                    }

                    Head = preNode;
                }
            }

            public void PrintList()
            {
                Node8<T> tempNode = new Node8<T>();
                tempNode = Head;
                while (tempNode != null)
                {
                    Console.Write($"|{tempNode.Data}|->");
                    tempNode = tempNode.Next;
                }
            }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Console.WriteLine("**************************Linked List 1*******************************");
            SingleLinkedList9 objSSL9 = new SingleLinkedList9();
            objSSL9.AddToHead(8);
            objSSL9.AddToHead(7);
            objSSL9.AddToHead(5);
            objSSL9.PrintList();
            objSSL9.AddToTail(10);
            objSSL9.AddToTail(11);
            objSSL9.PrintList();
            objSSL9.AddElementtoIndex(2, 100);
            objSSL9.PrintList();
            Console.WriteLine("**************************Linked List 7*******************************");
			SingleLinkedList7 objSSLL1 = new SingleLinkedList7();
			objSSLL1.AddToHead(10);
			objSSLL1.AddToHead(7);
			objSSLL1.AddToHead(5);
			objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.AddToTail(15);
            objSSLL1.AddToTail(18);
            objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.AddToPosition(3, 17);
            objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.RemoveAtPosition(1);
            objSSLL1.PrintList();
            Console.WriteLine();
            Console.WriteLine("Here is the Reverse List:");
			objSSLL1.ReverseList();
			objSSLL1.PrintReverseList();
            Console.WriteLine();




            Console.WriteLine("**************************Linked List 6*******************************");
            SingleLinkedList1 SSL1 = new SingleLinkedList1();
            SSL1.AddLast(12);
            SSL1.AddLast(10);
            SSL1.AddLast(8);
            Console.WriteLine("Here is the list:");
            SSL1.Print();
            SSL1.ReverseList();
            Console.WriteLine("Here is the Reverse List:");
            SSL1.Print();
            
        }
    }
}
