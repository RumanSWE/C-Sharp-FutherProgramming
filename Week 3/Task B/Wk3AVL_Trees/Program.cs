using System;
using System.IO;

namespace Wk3AVL_Trees
{
    class Program
    {
    
        static void Main(string[] args)


        {
            AVLTree<int> myTree = new AVLTree<int>();


            string buffer = " ";


           myTree.InsertItem(5); //left rotation test
            myTree.InsertItem(15);
            myTree.InsertItem(25);

          //  Console.WriteLine("height of node:{0}", myTree.Height());//height
            myTree.PreOrder();
            Console.WriteLine(buffer); //display

           

            Console.ReadKey();


        }

    }
}
