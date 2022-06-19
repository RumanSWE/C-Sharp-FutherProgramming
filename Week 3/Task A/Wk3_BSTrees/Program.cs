using System;
using System.IO;

namespace Wk3_BSTrees
{
    class Program
    {
        static BSTree<string> myTree = new BSTree<string>();
        static void Main(string[] args)
        {


            readFile();
            
            string buffer = " ";
           


            myTree.PreOrder(ref buffer);
            Console.WriteLine(buffer);

            int counter = myTree.Count();
            Console.WriteLine("Number of nodes in tree is: {0}", counter);
            Console.WriteLine("height of the tree is: {0}", myTree.Height());
            Console.WriteLine("helo world");

           
            myTree.InOrder(ref buffer);
            Console.WriteLine(buffer);

            
            Console.WriteLine("Number of nodes in tree is: {0}", counter);
            Console.WriteLine("height of the tree is: {0}", myTree.Height());
            Console.WriteLine("helo world");

            myTree.PostOrder(ref buffer);
            Console.WriteLine(buffer);

            Console.WriteLine("Number of nodes in tree is: {0}", counter);
            Console.WriteLine("height of the tree is: {0}", myTree.Height());
            Console.WriteLine("helo world");


            readFile();
            

            Console.ReadKey();

          

            static void readFile()
            {
                const int MAX_FILE_LINES = 50000;
                string[] AllLines = new string[MAX_FILE_LINES];

                //reads from bin/DEBUG subdirectory of project directory
                AllLines = File.ReadAllLines("textFile.txt");


                foreach (string line in AllLines)
                {
                    //split words using space , . ?
                    string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                    foreach (string word in words)
                        if (word != "")
                        {
                            myTree.InsertItem(word.ToLower());
                        }
                            //Console.WriteLine(word.ToLower());
                }
            }
        }
        
    }
}
