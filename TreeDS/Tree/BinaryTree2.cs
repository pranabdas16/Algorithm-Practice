using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class BinaryTree2
    {
        public Node2 Root { get; set; }

        public bool Add(int element)
        {
            Node2 before = null, after = this.Root;

            Node2 newNode = new Node2();
            newNode.Data = element;

            while (after != null)
            {
                before = after;
                if (element < after.Data)//Is new node in left tree? 
                    after = after.LeftNode;
                else if (element > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                    return false;//Exist for same value
            }

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (element < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true; 
        }
        public void TraversePreOrder(Node2 parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node2 parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node2 parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
