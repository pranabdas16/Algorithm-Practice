using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS
{
   public class Node6
    {
        public int Data;
        public Node6 LeftLeaf;
        public Node6 RighLeaf;

        public Node6()
        { 
            //Default Constructor...
        }

        public Node6(int element)
        {
            Data = element;
        }
    }
}
