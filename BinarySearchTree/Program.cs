using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree myBST = new BinarySearchTree();

            Node node1 = new Node(15);
            Node node2 = new Node(17);
            Node node3 = new Node(7);
            Node node4 = new Node(15);
            myBST.Add(node1);
            myBST.Add(node2);
            myBST.Add(node3);
            myBST.Add(node4);
           
        }
    }
}
