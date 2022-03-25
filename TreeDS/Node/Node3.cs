using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS.Node
{
   public class Node3
    {
        public int Data;
        public Node3 RightNode;
        public Node3 LeftNode;

        public Node3()
        { 
        }
        public Node3(int value)
        {
            Data = value;
        }
    }
}
