using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
   public class SingleLinkedList3
    {
       public Node3 Head;

        public SingleLinkedList3()
        {
            Head = null;
        }

        public void Print()
        {
            if (Head == null)
                Console.WriteLine("List is Empty.");
            else {
                Node3 temp = new Node3();
                temp = Head;
                Console.Write("The list is: ");
                while (temp != null)
                {
                    Console.Write("|" + temp.Data + "|->");
                    temp = temp.Next;
                }

            }
        }
        public void AddToFront(int element)
        {
            Node3 temp = new Node3();
            temp.Data = element;
            temp.Next = Head;
            Head = temp;
        }

        public void AddToEnd(int element)
        {
            Node3 temp = new Node3();
            temp.Data = element;
            temp.Next = null;

            if (Head == null)
                Head = temp;
            else {
                Node3 temp2 = new Node3();
                temp2 = Head;
                while (temp2.Next != null)
                {
                    temp2 = temp2.Next;
                }
                temp2.Next = temp;
            }

        }
    }
}
