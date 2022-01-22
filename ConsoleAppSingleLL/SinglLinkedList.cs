using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleNode
    {
        //public SingleNode next;
        public SingleNode next { 
            get; 
            set;
        }
        public int data;
        //public SingleNode()
        //{ 

        //}
        public SingleNode(int x)
        {
            data = x;
            next = null;
        }

        // To add as last node on the Linked List...
        public void AddLast(int data)
        {
            if (next == null)
            {
                //next.data = data;
                //next.next = null;
                next = new SingleNode(data);
            }
            else
            {
                next.AddLast(data);
            }
        }

        
        // To Print all nodes from the Linked List
        public void Print()
        {
            Console.Write("|{0}|->", data);
            if (next != null)
            {
                next.Print();
            }
        }

    }
   public class SinglLinkedList
    {
        public SingleNode headNode;
        int count = 0;
        public SinglLinkedList()
        {
            headNode = null;
        }

        public void AddLast(int data)
        {
            if (headNode == null)
            {
                headNode = new SingleNode(data);
            }
            else
            {
                headNode.AddLast(data);
            }
        }

        public void AddFront(int data)
        {
            if (headNode == null)
            {
               headNode = new SingleNode(data);
            }
            else
            {
                SingleNode temp = new SingleNode(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void RemoveFirst()
        {
            if (headNode != null)
            {
                headNode = headNode.next;
            }
        
        }

        public void RemoveLast()
        {
            //SingleNode objHead = headNode; 
            //while (headNode.next.next != null)
            //{
            //    //this.headNode.next.data = 0;

            //    headNode = headNode.next;
            //}
            //headNode.next = null;
            //headNode = objHead;


            SingleNode temp = headNode;
            if (headNode.next == null && count == 0)
            {
                this.headNode= null;
                count++;
            }
            else
            {
                headNode = headNode.next;
                RemoveLast();
            }

            headNode = temp;
        }
        public void Reverse()
        {
            SingleNode currentNode, NextNode = null, PreviousNode =null;
            currentNode = headNode;
            while (currentNode  != null)
            {
                
                NextNode = currentNode.next;
                currentNode.next = PreviousNode;
                PreviousNode = currentNode;

                currentNode = NextNode;

            }
            headNode = PreviousNode;
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
}
