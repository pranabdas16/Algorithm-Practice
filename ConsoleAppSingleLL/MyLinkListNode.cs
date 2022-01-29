using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    class MyLinkListNode
    {
        public int data;
        public MyLinkListNode next;
        public MyLinkListNode(int x)
        {
            data = x;
            next = null;
        }

        public void print()
        {
           Console.Write("|" + data + "|-> ");
            if (next != null)
            {

                next.print();
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new MyLinkListNode(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new MyLinkListNode(data);
            }
            else if (data < next.data)
            {
                MyLinkListNode temp = new MyLinkListNode(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
        
    }

    class MyLinkedList
    {
       public MyLinkListNode headNode;

       public MyLinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new MyLinkListNode(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new MyLinkListNode(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new MyLinkListNode(data);
            }
            else
            {
                MyLinkListNode temp = new MyLinkListNode(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.print();
            }
        }

    }
}
