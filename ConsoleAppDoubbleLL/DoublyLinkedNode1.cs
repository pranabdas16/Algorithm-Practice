using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoubbleLL
{
   public class DoublyLinkedNode1
    {
        public int data;
        public DoublyLinkedNode1 next;
        public DoublyLinkedNode1 previous;

        public DoublyLinkedNode1()
        { 
        
        }
        public DoublyLinkedNode1(int Data)
        {
            this.data = Data;
        }
    }
}
