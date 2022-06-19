using System;

namespace Wk5GraphsTaskA
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph<char> myGraph = new Graph<char>();

            Console.WriteLine("is the graph empty?:" + myGraph.IsEmptyGraph());
            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');

            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');

            Console.Write("Are A and B adjacent:");
            Console.Write(myGraph.IsAdjacent(myGraph.GetNodeByID('A'), myGraph.GetNodeByID('B')));


            Console.WriteLine("Is the gr");
            Console.WriteLine("is the graph empty?:" + myGraph.IsEmptyGraph());
            Console.WriteLine("number of nodes"+myGraph.NumNodesGraph());
            Console.WriteLine("number of edges" + myGraph.NumEdgesGraph());
           // Console.WriteLine(myGraph.NumNodesGraph());     
        }
    }
}
