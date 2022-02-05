using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoubbleLL
{
   public class DoublyLinkedList1
    {
        public DoublyLinkedNode1 Head;
        public DoublyLinkedNode1 Tail;
        private int Count;
        public bool IsEmpty => Count == 0;

        public DoublyLinkedList1()
        {
            Head = null;
        }

        public void PrintdoublyLinkedList()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                DoublyLinkedNode1 currNode = new DoublyLinkedNode1();
                currNode = Head;
                while (currNode != null)
                {
                    Console.Write("|"+ currNode.data + "|->" );
                    currNode = currNode.next;
                }
            }
        }

        public void AddToFront(int newElement)
        {

            if (IsEmpty)
            {
                DoublyLinkedNode1 objFront = new DoublyLinkedNode1();
                objFront.data = newElement;
                objFront.next = null;
                objFront.previous = null;
                Head = objFront;
            }
            else
            {
                DoublyLinkedNode1 objFront = new DoublyLinkedNode1();
                objFront.data = newElement;
                objFront.previous = null;
                objFront.next = Head;
                Head = objFront;
            }
            Count++;
        }

        public void AddToFront1(int newElement)
        {
            DoublyLinkedNode1 temp = Head;
            DoublyLinkedNode1 node = new DoublyLinkedNode1(newElement);
            Head = node;

            Head.next = temp;
            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.previous = Head;
            }
            Count++;
        }
                
        // This one add next and previous both with tail node
        public void AddToTail(int newElement)
        {
            DoublyLinkedNode1 objTail = new DoublyLinkedNode1();
            objTail.data = newElement;

            //Test for null value when Tail become Head....
            if (IsEmpty)
            {
                objTail.previous = null;
                objTail.next = Head;
                Head = objTail;
            }
            else
            {
                DoublyLinkedNode1 currNode, temp = new DoublyLinkedNode1();
                currNode = Head;
                while (currNode.next != null)
                    currNode = currNode.next;

                objTail.next = null;
                objTail.previous = currNode;
                currNode.next = objTail;
            }
            Count++;
        }

        /// This one doesn't add previous node
        public void AddToTail1(int newElement)
        {
            DoublyLinkedNode1 objTail = new DoublyLinkedNode1();
            objTail.data = newElement;


            if (Head == null)
            {
                objTail.previous = null;
                objTail.next = Head;
                Head = objTail;
            }
            else
            {
                DoublyLinkedNode1 currNode, temp = new DoublyLinkedNode1();
                currNode = Head;
                while (currNode.next != null)
                    currNode = currNode.next;

                objTail.next = null;
                currNode.next = objTail;
            }
            Count++;
        }
       
        public void RemoveHeadNode()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is already empty");
            }
            else
            {
                DoublyLinkedNode1 temp = new DoublyLinkedNode1();
                temp = this.Head;
                this.Head = this.Head.next;
                temp = null;
                Count--;
            }
           // Count--;
        }

        public void RemoveHeadNode1()
        {
            if (Head != null)
            {
                DoublyLinkedNode1 currNode = new DoublyLinkedNode1();
                currNode = Head;
                currNode = currNode.next;
                Head = currNode;
                Count--;
            }
            else
            {
                Console.WriteLine("List is already empty");
            }
           // Count--;
        }

        public void RemoveLastNode()
        {
            if (Head != null)
            {
                DoublyLinkedNode1 currNode = new DoublyLinkedNode1();
                currNode = Head;
                while (currNode.next != null)
                    currNode = currNode.next;

                currNode = currNode.previous;
                currNode.next = null;
                Count--;
            }
        }
    }
}
