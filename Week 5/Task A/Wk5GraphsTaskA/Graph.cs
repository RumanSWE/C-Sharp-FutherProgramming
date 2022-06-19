using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Wk5GraphsTaskA
{
    public class Graph<T> where T : IComparable
    {

        // list of all the nodes in the graph. Use LinkedList from C#
        private LinkedList<GraphNode<T>> nodes;


        // constructor – set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }


        // only returns true if the graph’s list of nodes is empty
        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }


        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            return nodes.Count;
            // hint: how can you get the list of all nodes in the graph ? 
            // once you have that you can count (and return) how many elements are in the list             

        }


        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {

            int edgeCount = 0;
            foreach (GraphNode<T> n in nodes)
            {
                edgeCount += n.GetAdjList().Count;
            }
            return edgeCount;
            
                // hint: this loop allows to run over all the nodes present in the   graph.

                // to get the total number of edges in the graph: 
                // you need to count how many outgoing edges each node has and then return the sum obtained considering all nodes in the graph

                // how can you get the number of outgoing edges for each node ? (i.e.,     use the adjacency list of the node)
            



        }

        // only returns true if node is present in the graph
        public bool ContainsGraph(GraphNode<T> node)
        {
            // to be completed. Hint: Search through the full list of nodes (search of the node is based on the id)
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;

        }

        // only returns true if nodes “from “ and “to” are adjacent

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    bool b = from.GetAdjList().Contains(to.ID);
                    if (b == true)
                    { return true; }
                }
            }
            return false;
            // to be completed
            //Hint: Find the node “from” in the list of nodes and then search its adjList to see if there is node “to” 

        }
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode <T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
            }
            return null;
            // to be completed
            //Hint: Search through the list of nodes for a node with this id
        }



        // Add a directed edge between the node with id "from" and the node with id “to” 
        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if(n1 != null & n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.Write("Cannot add edge");
            }

            // to be completed
            //Hint: Find the node with id “from” in the list of nodes and then
            //use the GraphNode method to add an edge to the node with id “to”   
        }


    } //end class

}
