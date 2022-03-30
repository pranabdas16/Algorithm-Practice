using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SingleLinkedList5
    {
        public Node5 head;
        public SingleLinkedList5()
        {
            head = null;
        }
        //Print the linked list...
        public void PrintList()
        {
            if (head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node5 temp = head;
                Console.Write("The list is:");
                while (temp != null)
                {
                    Console.Write("|"+ temp.data + "|->");
                    temp = temp.next;
                }
            }
        }
        // Add to head/front to the single linked list...
        public void AddToFront(int newElement)
        {
            Node5 temp = new Node5();
            temp.data = newElement;
            temp.next = head;
            head = temp;
        }

        public void AddToTail(int newElement)
        {
            Node5 temp = new Node5();
            temp.data = newElement;
            temp.next = null;

            if (head == null)
            {
                head = temp;
            }
            else
            {
                Node5 curNode = new Node5();
                curNode = head;
                while (curNode.next != null)
                    curNode = curNode.next;
                curNode.next = temp;
            }
        }

        //reverse the list
        public void reverseList()
        {
            if (this.head != null)
            {
                Node5 prevNode = null;
                Node5 nextNode = null;
                Node5 curNode = this.head;

                // prevNode.next = null;
                while (curNode != null)
                {
                    nextNode = curNode.next;
                    curNode.next = prevNode;

                    prevNode = curNode;
                    curNode = nextNode;
                }

                this.head = prevNode;
            }
        }

        //Inserts a new element at the given position
        public void push_at(int newElement, int position)
        {
            Node5 newNode = new Node5();
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                Node5 temp = new Node5();
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }

    }
}
