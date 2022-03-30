using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDS.Node;

namespace TreeDS.Tree
{
    /// <summary>
    /// Reference...
    /// https://www.codeguru.co.in/2015/03/how-to-create-binary-tree-in-c.html
    /// http://csharpexamples.com/c-binary-search-tree-implementation/
    /// </summary>
    public class BinaryTree4
    {
        public Node4 root;
        public BinaryTree4()
        {
            root = null;
        }

        public void AddNode(int element)
        {
            if (root == null)
            {
                root = new Node4(element);
                return;
            }
            else
                AddNodeRec(root, new Node4(element));
        }

        private void AddNodeRec(Node4 root, Node4 newNode)
        {
            if (root == null)
                root = newNode;
            
            if (newNode.data < root.data)
            {
                //If new node value is smaller than root..... 
                if (root.leftNode == null)
                    root.leftNode = newNode;
                else
                    AddNodeRec(root.leftNode, newNode);
            }
            else 
            {
                //If new node value is greater than root.....
                if (root.rightNode == null)
                    root.rightNode = newNode;
                else
                    AddNodeRec(root.rightNode, newNode);
            }
        }

    }
}
