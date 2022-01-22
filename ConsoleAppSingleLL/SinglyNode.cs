using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SinglyNode
    {
        public int data { get; set; }
        public SinglyNode Next { get; set; }

        public SinglyNode(int value)
        {
            data = value;
            Next = null; 
        }

        public void AddToEnd(int value)
        {
            if (Next == null)
            {
                Next = new SinglyNode(value);
            }
            else
            {
                Next.AddToEnd(value);
            }
        }

        public void AddToStart(int value)
        {
            if (Next == null)
            {
                Next = new SinglyNode(value);
            }
            else
            {
                SinglyNode currentNode = new SinglyNode(value);
                currentNode.Next = Next;
                Next = currentNode;
            }
        }

        public void Print()
        {
            Console.Write("|{0}->",data);
            if (Next != null)
            {
                Next.Print();
            }
        }
    }
}
