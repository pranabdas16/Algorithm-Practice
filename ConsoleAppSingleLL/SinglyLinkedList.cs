using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class Node
    {
        public int Data { get; set; }
        public Node Next;
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
   public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }
        
        //public SinglyLinkedList()
        //{

        //}

        public void AddFirst(int data)
        {
            Node obj;
            if (Head == null)
            {
                obj = new Node(data);
            }
            else
            {
                AddFirst(data);
            }
        }

        public void Print()
        {
            //Console.Write("|" + Node +"| ->" );
        }
        //public void AddTail(int data)
        //{
        //    if ( Head== null)
        //    {
        //      new Node(data);
        //    }
        //    else
        //    {

        //        AddTail(data);
        //    }
        //}
    }
}
