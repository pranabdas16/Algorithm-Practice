using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SingleLinkedList11
    {
        public Node11 head;
        public int count = 0;

        public void AddToHead(int element)
        {
            Node11 newNode = new Node11();
            newNode.val = element;
            newNode.next = head;

            head = newNode;
            count++;
        }

        public void AddToTail(int element)
        {
            Node11 newNode = new Node11();
            newNode.val = element;
            newNode.next = null;

            Node11 tempNode = head;

            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = newNode;
        }

        public void PrintList()
        {
            Node11 tempNode = head;
            Console.Write("Heere is the List:");
            while (tempNode != null)
            {
                Console.Write($" | {tempNode.val} |->");
                tempNode = tempNode.next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ReverseList()
        {
            if (this.head != null)
            {
                Node11 prevNode = head;
                Node11 tempNode = head;
                Node11 curNode = head.next;

                prevNode.next = null;

                while (curNode != null)
                {
                    tempNode = curNode.next;
                    curNode.next = prevNode;
                    prevNode = curNode;
                    curNode = tempNode;
                }

                head = prevNode;

            }
        }
    }
}
