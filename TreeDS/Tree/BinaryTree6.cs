using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS
{
   public class BinaryTree6
    {
        public Node6 Root;
        public BinaryTree6()
        {
            Root = null;
        }

        public void AddNode(int element)
        {
            if (Root == null)
            {
                Root = new Node6(element);
                return;
            }
            else
                AddNodeRec(Root, new Node6(element));

        }

        public void AddNodeRec(Node6 RootNode, Node6 newNode)
        {
            if (Root == null)
            {
                Root = newNode;
            }

            if (RootNode.Data > newNode.Data)
            {
                if (RootNode.LeftLeaf == null)
                    RootNode.LeftLeaf = newNode;
                else
                    AddNodeRec(RootNode.LeftLeaf, newNode);
            }
            else
            {
                if (RootNode.RighLeaf == null)
                    RootNode.RighLeaf = newNode;
                else
                    AddNodeRec(RootNode.RighLeaf, newNode);
            }
        }
    }
}
