using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS.Node
{
   public class BSTNode
    {
        public int Value;
        public BSTNode LeftNode;
        public BSTNode RightNode;

        public BSTNode()
        { 
        
        }

        public BSTNode(int element)
        {
            Value = element;
        }
    }
}
