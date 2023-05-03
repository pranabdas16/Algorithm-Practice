using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class Node12
    {
        public int val;
        public Node12 next;

        public Node12(int Val = 0, Node12 Next = null)
        {
            this.val = Val;
            this.next = Next;
        }
    }
}
