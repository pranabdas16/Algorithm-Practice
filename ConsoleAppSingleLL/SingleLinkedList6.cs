using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleLinkedList6
    {
        public Node6 Head;
        public SingleLinkedList6()
        {
            Head = null;
        }
        //Print the list...
        public void PrintList()
        {
            if (Head == null)
                Console.WriteLine("The List is empty.");
            else
            {
                Console.Write("The List is: ");
                Node6 temp = new Node6();
                temp = Head;
                while (temp != null)
                {
                    Console.Write($"|{temp.Data}|->");
                    temp = temp.Next;
                }
            }
        }
        // Add to head on the list...
        public void AddToHead(int element)
        {
            Node6 newNode = new Node6();
            newNode.Data = element;
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddToTail(int element)
        {
            if (Head == null)
            {
                Node6 newNode = new Node6();
                newNode.Data = element;
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node6 temp = new Node6();
                temp = Head;

                Node6 newNode = new Node6();
                newNode.Data = element;
                newNode.Next = null;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        //Inserts a new element at the given position
        public void push_at(int newElement, int position)
        {
            Node6 newNode = new Node6();
            newNode.Data = newElement;
            newNode.Next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {

                Node6 temp = new Node6();
                temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }

                if (temp != null)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }

        }

        //Delete an element at the given position
        public void pop_at(int position)
        {
            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1 && Head != null)
            {
                Node6 nodeToDelete = Head;
                Head = Head.Next;
                nodeToDelete = null;
            }
            else
            {
                Node6 temp = new Node6();
                temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }
                if (temp != null && temp.Next != null)
                {
                    Node6 nodeToDelete = temp.Next;
                    temp.Next = temp.Next.Next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                }
            }
        }

        //reverse the list
        public void ReverseList()
        {
            if (this.Head != null)
            {
                Node6 prevNode = null;
                Node6 nextNode = null;
                Node6 curNode = this.Head;

                // prevNode.next = null;
                while (curNode != null)
                {
                    nextNode = curNode.Next;
                    curNode.Next = prevNode;

                    prevNode = curNode;
                    curNode = nextNode;
                }

                this.Head = prevNode;
            }
        }
    }
}
