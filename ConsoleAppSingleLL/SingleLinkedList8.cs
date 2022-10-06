using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SingleLinkedList8
    {
        public Node8 Head;
        public SingleLinkedList8()
        {
            Head = null;
        }
        public void PrintList()
        {
            Node8 temp = new Node8();
            temp = Head;
            if (temp == null)
            {
                Console.WriteLine("This list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write($"|{temp.Data}|->");
                    temp = temp.Next;
                }
            }
            Console.WriteLine();
        }
        //Add to the Head of the list....
        public void AddToHead(int element)
        {
            Node8 newNode = new Node8();
            newNode.Data = element;
            newNode.Next = Head;
            Head = newNode;
        }
        //Add to the tail of the list....
        public void AddToTail(int element)
        {
            if (Head == null)
            {
                AddToHead(element);
            }
            else
            {
                Node8 tempNode = new Node8();
                tempNode = Head;
                Node8 newNode = new Node8();
                newNode.Data = element;
                newNode.Next = null;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }

    }
}
