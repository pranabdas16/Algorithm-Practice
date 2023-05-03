using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class BinaryTree5
    {
        public Node5 Root;

        public BinaryTree5()
        {
            Root = null;
        }

        public void AddNode(int element)
        {
            if (Root == null)
            {
                Root = new Node5(element);
                return;
            }
            else
                AddNodeRec(Root, new Node5(element));
        }

        public void AddNodeRec(Node5 Root,  Node5 val)
        {
            if (Root == null)
            {
                Root = val;
                return;
            }

            if (Root.Data > val.Data)
            {
                if (Root.LeftLeaf == null)
                {
                    Root.LeftLeaf = val;
                    return;
                }
                else
                {
                    AddNodeRec(Root.LeftLeaf, val);
                }
            }
            else
            {
                if (Root.RightLeaf == null)
                {
                    Root.RightLeaf = val;
                }
                else
                    AddNodeRec(Root.RightLeaf, val);
            }
        }

        public void TraversePreOrder(Node5 parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.Data + " ");
                TraversePreOrder(parent.LeftLeaf);
                TraversePreOrder(parent.RightLeaf);
            }
        }

        public void TraverseInOrder(Node5 parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftLeaf);
                Console.WriteLine(parent.Data + " ");
                TraverseInOrder(parent.RightLeaf);
            }
        }

        public void TraversePostOrder(Node5 parent)
        {
            if (parent != null)
            {
                
                TraversePostOrder(parent.LeftLeaf);
                TraversePostOrder(parent.RightLeaf);
                Console.WriteLine(parent.Data + " ");
            }
        }
    }
}
