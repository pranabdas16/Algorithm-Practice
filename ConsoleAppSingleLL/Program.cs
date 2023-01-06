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


        public class Node
        {
            public int Data;
            public Node Next;
        }

        public class SingleList
        {
            public Node Head;
            public int count = 0; 

            public void AddToHead(int element)
            {
                Node newNode = new Node();
                newNode.Data = element;
                newNode.Next = Head;
                Head = newNode;
                count++;
            }

            public void AddToTail(int element)
            {
                Node tempNode = new Node();
                tempNode = Head;

                Node newNode = new Node();
                newNode.Data = element;
                newNode.Next = null;

                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
                count++;
            }

            public void RemoveHead()
            {
                Node temp = new Node();
                temp = Head;
                Head = temp.Next;
                count--;
            }

            public void RemoveTail()
            {
                Node tempNode = new Node();
                tempNode = Head;
                while (tempNode.Next.Next != null)
                    tempNode = tempNode.Next;

                tempNode.Next = null;
                count--;
            }

            public void Print()
            {
                Node temp = new Node();
                temp = Head;
                Console.Write("Here is the List:");
                while (temp != null)
                {
                    Console.Write($"| {temp.Data} |->");
                    temp = temp.Next;
                }
                Console.WriteLine($"Total list count is: {count}");
            }
        }
        static void Main(string[] args)
        {
            
			Console.WriteLine("**************************Linked List*******************************");
            SingleList obj = new SingleList();
            obj.AddToHead(3);
            obj.AddToHead(1);
            obj.AddToTail(5);
            obj.Print();
            obj.RemoveHead();
            obj.Print();
            obj.AddToTail(7);
            obj.Print();
            obj.RemoveTail();
            obj.Print();

            Console.WriteLine("**************************Linked List*******************************");
			
            Console.WriteLine("**************************Linked List*******************************");
            
            
        }
    }
}
