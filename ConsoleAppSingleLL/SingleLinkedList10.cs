using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleLinkedList10
    {
        public Node10 Head;
        public int count =0;

        public void AddToHead(int element)
        {
            Node10 newNode = new Node10();
            newNode.Data = element;
            newNode.Next = Head;
            Head = newNode;
            count++;
        }

        public void AddToTail(int element)
        {
            Node10 newNode = new Node10();
            newNode.Data = element;
            newNode.Next = null;

            if (Head == null)
            {
                AddToHead(element);
            }
            else
            {
                Node10 temp = new Node10();
                temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                count++;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        public void AddAtPosition(int position)
        {
            
            if (position <= 0 || position <= count-1)
            {
                Console.WriteLine("This is not the correct Position.");
            }
            else
            { 
                
            }
        }

        public void AddElementtoIndex(int indexVal, int element)
        {
            Node10 temp = new Node10();
            temp = Head;

            int currentIndex = 0;
            if (indexVal < 0 || indexVal > count)
            {
                Console.WriteLine("This is not the valid Index.");
            }
            else
            {
                Node10 newNode = new Node10();
                newNode.Data = element;
                while (indexVal-1 != currentIndex)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                newNode.Next = temp.Next;
                //temp.Next = null;
                temp.Next = newNode;
                count++;
            }
            //PrintList();
        }

        public void PrintList()
        {
            Node10 temp = new Node10();
            temp = Head;
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("Here the Linked List padu: ");
                while (temp != null)
                {
                    Console.Write($"| {temp.Data} |->");
                    temp = temp.Next;
                }
                Console.WriteLine($"Total list count padu: {count}");
            }
        }
    }
}
