using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
   public class BinaryTree7
    {
        public Node7 root;
        public BinaryTree7()
        {
            root = null;
        }

        public void AddNode(int element)
        {
            if (root == null)
            {
                root = new Node7(element);
            }
            else
            {
                AddNodeRec(root, new Node7(element));
            }
        }

         void AddNodeRec(Node7 root ,Node7 newNode)
        {
            if (root.data > newNode.data)
            {
                if (root.left_Node == null)
                {
                    root.left_Node = newNode;
                    return;
                }
                else
                    AddNodeRec(root.left_Node, newNode);
            }
            else
            {
                if (root.right_Node == null)
                {
                    root.right_Node = newNode;
                }
                else
                    AddNodeRec(root.right_Node, newNode);
            }
        }

        public void printInorder(Node7 node)
        {
            if (node == null)
                return;
            /* first recur on left child */
            printInorder(node.left_Node);
            /* then print the data of node */
            Console.Write(node.data + " ");
            /* now recur on right child */
            printInorder(node.right_Node);
        }

        public void printPreorder(Node7 node)
        {
            if (node == null)
                return;
            /* first print data of node */
            Console.Write(node.data + " ");
            /* then recur on left subtree */
            printPreorder(node.left_Node);
            /* now recur on right subtree */
            printPreorder(node.right_Node);
        }

        public void printPostorder(Node7 node)
        {
            if (node == null)
                return;
            // first recur on left subtree
            printPostorder(node.left_Node);
            // then recur on right subtree
            printPostorder(node.right_Node);
            // now deal with the node
            Console.Write(node.data + " ");
        }
    }
}
