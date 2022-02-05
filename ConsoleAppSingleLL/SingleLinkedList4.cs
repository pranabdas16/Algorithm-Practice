using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SingleLinkedList4
    {   //Head node create to start from the begining
        public Node4 head;
        //Constructor create to initialize head node with null;
        public SingleLinkedList4()
        {
            head = null;
        }

        //To print the Entire linked list starting from head....
        public void PrintList()
        {
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node4 currNode = new Node4();
                currNode = head;
                Console.Write("Here is the List:");
                while (currNode != null)
                {
                    Console.Write("|" + currNode.data + "|->");
                    currNode = currNode.next;
                }
            }
        }
        //Add the value at head.....
        public void AddtoFront(int newElement)
        {
            Node4 tempNode = new Node4();
            tempNode.data = newElement;
            tempNode.next = head;  // Make temNode as head by putting next the head...
            head = tempNode; // Putting head as head for future derived changess..
        }

        //Add the value at head.....By not putting head as head and print the solution what happen....
        public void AddtoFrontWithougtHead(int newElement)
        {
            Node4 tempNode = new Node4();
            tempNode.data = newElement;
            tempNode.next = head;  // Make temNode as head by putting next the head...
           // head = tempNode; // Putting head as head for future derived changess..
        }

        //Add element at the end of the list...
        public void AddToEnd(int newElement)
        {
            Node4 tmpNode = new Node4();
            tmpNode.data = newElement;
            tmpNode.next = null;
            if (head == null)   //check if list is empty...
                head = tmpNode; // if list is empty first node is the last node....
            else
            {
                Node4 currentNode = new Node4();
                currentNode = head;
                while (currentNode.next != null) //check for until next node is null in the list...
                    currentNode = currentNode.next;

                currentNode.next = tmpNode; // add the new node to the next of last node...
            }
        }

        //reverse the list
        public void reverseList()
        {
            if (this.head != null)
            {
                Node4 prevNode = null;
                Node4 nextNode = null;
                Node4 curNode = this.head;

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

        //Rever the list another way....
        public void ReverseList2()
        {
            Node4 temNod = new Node4();
            temNod = head;

            while (temNod != null)
                temNod = temNod.next;
        
        }

    }
}
