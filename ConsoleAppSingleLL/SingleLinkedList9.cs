using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleLinkedList9
    {
        public Node9 Head;
        public int Count = 0;

        public void AddToHead(int element)
        {
            Node9 newNode = new Node9();
            newNode.Data = element;
            newNode.Next = Head;

            Head = newNode;
            Count++;
        }

        public void AddToTail(int element)
        {
            Node9 tempNode = new Node9();
            tempNode = Head;

            Node9 newNode = new Node9();
            newNode.Data = element;
            newNode.Next = null;

            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }
            tempNode.Next = newNode;
            Count++;
        }

        public void PrintList()
        {
            Node9 tempNode = new Node9();
            tempNode = Head;
            while (tempNode != null)
            {
                Console.Write($"| {tempNode.Data} |->");
                tempNode = tempNode.Next;
            }
            Console.WriteLine($"Total count: {Count}");
        }

        public void AddElementtoIndex(int atIndex, int element)
        {
            Node9 temp = new Node9();
            temp = Head;

            Node9 newNode = new Node9();
            newNode.Data = element;
            int currentIndex = 0;
            if (atIndex == 0)
            {
                AddToHead(element);
            }
            else if (0 > atIndex && atIndex < Count)
            {
                while (atIndex != currentIndex)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                if (atIndex == currentIndex)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    Count++;
                }
            }
        }

    }
}
