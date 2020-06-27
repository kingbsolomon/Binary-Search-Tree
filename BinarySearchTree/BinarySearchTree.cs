using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {

        public Node RootNode;
        public BinarySearchTree()
        {
            RootNode = null;
        }

        public void Add(int value)
        {
            Node newNode = new Node(value);

            if(RootNode == null)
            {
                RootNode = newNode;
                return;
            }
            
            Node currentNode = RootNode;
            while (true)
            {   
                if (newNode.Data < currentNode.Data)
                {
                    if (currentNode.LeftNode == null)
                    {
                        currentNode.LeftNode = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.LeftNode;
                    }
                }
                else if (newNode.Data > currentNode.Data)
                {
                    if (currentNode.RightNode == null)
                    {
                        currentNode.RightNode = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                    }
                }
            }
        }

        public bool Search(int value)
        {
            if (value == RootNode.Data)
            {
                return true;
            }

            Node currentNode = RootNode;
            while (true)
            {
                if (value < currentNode.Data)
                {
                    if (currentNode.LeftNode == null)
                    {
                        break;
                    }
                    else if (value == currentNode.LeftNode.Data)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.LeftNode;
                    }
                }
                else if (value > currentNode.Data)
                {
                    if (currentNode.RightNode == null)
                    {
                        break;
                    }
                    else if (value == currentNode.RightNode.Data)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                    }
                }
            }
            return false;
        }
    }
}
