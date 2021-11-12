using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleNode
    {
        public SingleNode next;
        public int data;

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
            //if (headNode.next == null)
            //{
            //    this.headNode = null;
            //}
            //else
            //{
            //    _ = headNode.next;
            //    RemoveLast();
            //}
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
