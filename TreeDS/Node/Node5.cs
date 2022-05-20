using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS.Node
{
   public class Node5
    {
        public int Data;
        public Node5 LeftLeaf;
        public Node5 RightLeaf;

        public Node5()
        { 
        }

        public Node5(int element)
        {
            Data = element;            
        }
    }
}
