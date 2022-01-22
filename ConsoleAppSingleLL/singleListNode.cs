using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    class singleListNode
    {
        public int data;
        public singleListNode next;

        public singleListNode(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "| ->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new singleListNode(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }
}
