using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS.Node
{
   public class BSTNode1
    {
        public int Data;
        public BSTNode1 LeftNode;
        public BSTNode1 RightNode;

        public BSTNode1()
        { 
        }

        public BSTNode1(int element)
        {
            Data = element;
        }
    }
}
