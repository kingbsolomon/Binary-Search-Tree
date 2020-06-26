using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {

        public Node RootNode;
        public Node LastNode;
        public Node LeftNode;
        public Node RightNode;
        public BinarySearchTree()
        {
            RootNode = null;
        }

        public void Add(Node newNode)
        {
            if(RootNode == null)
            {
                RootNode = newNode;
                LastNode = RootNode;
            }
            else if(newNode.Data < LastNode.Data)
            {
                LeftNode = newNode;
            }
            else if(newNode.Data > LastNode.Data)
            {
                RightNode = newNode;
                
            }

        }
    }
}
