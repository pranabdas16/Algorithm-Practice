using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleLinkedList12
    {
        public Node12 head;
        public int count = 0;

        public void AddToHead(int element)
        {
            Node12 newNode = new Node12();
            newNode.val = element;
            newNode.next = head;

            head = newNode;
            count++;
        }

        public void AddToTail(int element)
        {
            Node12 tempNode = new Node12();
            tempNode = head;

            Node12 newNode = new Node12();
            newNode.val = element;
            newNode.next = null;

            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = newNode;
            count++;
        }

        public void PrintList()
        {
            Node12 tempNode = new Node12();
            tempNode = head;

            Console.WriteLine("Here is the list:");
        
        }

    }
}
