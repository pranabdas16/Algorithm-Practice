using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    /// <summary>
    /// I hava to check the lastnode add value.....
    /// </summary>
   public class SingleLinkedList2
    {
        public Node2 head;

        public SingleLinkedList2()
        {
            head = null;
        }

        //Add data to head.......
        public void AddTohead(int dataElement)
        {
            Node2 objNode2 = new Node2();
            objNode2.Data = dataElement;
            objNode2.Next = head;
            head = objNode2;
        }

        public void AddToLast(int val)
        {
            Node2 objNode2 = new Node2();
            objNode2.Data = val;
            objNode2.Next = null;

            if (head == null)
            {
                head = objNode2;
            }
            else
            {
                Node2 objNode2another = new Node2();
                objNode2another = head;
                while (objNode2another.Next != null)
                {
                    objNode2another = objNode2another.Next;
                }
                Node2 temp = new Node2();
                temp.Data = val;
                temp.Next = null;
                objNode2another.Next = temp;
               // head = objNode2another; print last two valuesss.... I have to check this. 
            }
        
        }

        public void AddToLast2(int newElement)
        {
            Node2 objN2 = new Node2();
            objN2.Data = newElement;
            objN2.Next = null;
            if (head == null)
            {
                head = objN2;
            }
            else
            {
                Node2 temp = new Node2();
                temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = objN2;
            }
        }

        public void SortAssending()
        {
            int counter =0;
            Node2 temp, current, test, temp2 = new Node2();
            temp = head;
            current = test = head;

            while (test.Next != null)
            {
                test = test.Next;
                counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                while (temp.Next != null && current.Next != null)
                {
                    if (current.Data > temp.Next.Data)
                    {
                        temp = temp.Next;

                        temp2.Data = current.Data;
                        // temp2.Next = current.Next;
                        current.Data = temp.Data;
                        // current.Next = temp.Next;
                        temp.Data = temp2.Data;
                        // temp.Next = temp2.Next;
                    }

                    current = current.Next;
                    // temp = temp.Next;
                }
                temp = current = head;
            }
        }
        //Add print all linked list value....
        public void PrintList()
        {
            Node2 objNode2 = new Node2();
            objNode2 = head;
            if (objNode2 == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Here is the single linked list: ");
                while (objNode2 != null)
                {
                    Console.Write("|"+ objNode2.Data + "|->");
                   objNode2= objNode2.Next;
                }
            }

        }


    }
}
