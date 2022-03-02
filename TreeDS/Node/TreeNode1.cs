using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS.Node
{
   public class TreeNode1
    {
        public int Value;
        public TreeNode1 Left;
        public TreeNode1 Right;

        public TreeNode1(int element)
        {
            Value = element;
            Left = null;
            Right = null;
        
        }
    }
}
