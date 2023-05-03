using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class ListNode01
    {
        public int Data { get; set; }
        public ListNode01 Next;
        public ListNode01(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
   public class SinglyLinkedList
    {
        public ListNode01 Head { get; set; }
        public ListNode01 Tail { get; set; }
        public int Count { get; set; }
        
        //public SinglyLinkedList()
        //{

        //}

        public void AddFirst(int data)
        {
            ListNode01 obj;
            if (Head == null)
            {
                obj = new ListNode01(data);
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
