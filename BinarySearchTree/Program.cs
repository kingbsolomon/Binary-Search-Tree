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

            myBST.Add(55);
            myBST.Add(17);
            myBST.Add(77);
            myBST.Add(27);
            myBST.Add(12);
            myBST.Add(4);
            myBST.Add(33);
            myBST.Add(10);
            myBST.Add(80);

            Console.WriteLine(myBST.Search(12));
            Console.WriteLine(myBST.Search(15));
            Console.WriteLine(myBST.Search(10));
            Console.WriteLine(myBST.Search(55));
            Console.WriteLine(myBST.Search(81));
            Console.ReadLine();

           
           
        }
    }
}
