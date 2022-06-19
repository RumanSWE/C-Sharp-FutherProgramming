using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk5GraphTaskB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
            /*
            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');

            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');

            Console.Write("Are A and B adjacent:");
            Console.Write(myGraph.IsAdjacent(myGraph.GetNodeByID('A'), myGraph.GetNodeByID('B')));


            Console.WriteLine("Is the gr");
            Console.WriteLine(myGraph.IsEmptyGraph());
            Console.WriteLine(myGraph.NumEdgesGraph());
            // Console.WriteLine(myGraph.NumNodesGraph());
            */
        }
    }
}
