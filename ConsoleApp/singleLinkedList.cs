﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //class singleLinkedList
    //{
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
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
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;

                count++;
            }

            public void PrintList()
            {
                LinkedListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }


        }

  //  }
}
