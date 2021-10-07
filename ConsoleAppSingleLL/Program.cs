using System;

namespace ConsoleAppSingleLL
{
    class Program
    {
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
            class LinkedList
            {
                int count;
                LinkedListNode head;

                public LinkedList()
                {
                    head = null;
                    count = 0;
                }
                public void AddNodeToFront(int data)
                {
                    LinkedListNode objLLN = new LinkedListNode(data);
                    objLLN.next = head;
                    count++;
                }
            }
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
