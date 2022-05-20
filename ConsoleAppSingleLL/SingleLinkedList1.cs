using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL1
{
    public class SingleLinkedList1
    {
        Node1 head;
        public SingleLinkedList1()
        {
            head = null;
        }

        public void AddFront(int x)
        {
            Node1 objNode1 = new Node1();
            objNode1.data = x;
            objNode1.next = head;
            head = objNode1;
        }

        public void AddLast(int newElement)
        {
            if (head == null)
            {
               Node1  objNode1 = new Node1();
                objNode1.data = newElement;
                objNode1.next = null;
                head = objNode1;
            }
            else
            {
                Node1 temp1 = head;
                // AddLast(newElement
                // 
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                    
                }
                Node1 lastNode = new Node1();

                lastNode.data = newElement;
                lastNode.next = null;
                temp1.next = lastNode;
            }
        }

        public void ReverseList()
        {
            if (head != null)
            {
                Node1 prevNode, currntNode, nextNode = new Node1();
                prevNode = null;
                currntNode = head;
                nextNode = null;

                while (currntNode != null)
                {
                    nextNode = currntNode.next;
                    currntNode.next = prevNode;

                    prevNode = currntNode;
                    currntNode = nextNode;
                }
                head = prevNode;
            }
        }

        public void Print()
        {
            Node1 temp1 = new Node1();
            temp1 = head;
            if (temp1 != null)
            {
                Console.Write("This list is: ");
                while (temp1 != null)
                {
                    Console.Write("|"+ temp1.data +"->");
                   temp1 = temp1.next;
                }
            }
            else
            {
                Console.WriteLine("");
            }

        }
        
    }
        
    
}
