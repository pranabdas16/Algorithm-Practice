using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LinkedLIst
{
    public class LinkedList1
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
    }
}
