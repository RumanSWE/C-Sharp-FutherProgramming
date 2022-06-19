using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5GraphTaskB
{
    public class GraphNode<T>
    {
        public T id; // data stored in the node (“id” of the  node).
        private LinkedList<T> adjList; // adjacency list of the node
                                       //Use LinkedList from C#

        // constructor 
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        // set and get the data stored in the node 
        public T ID
        {
            set { id = value; }
            get { return id; }
            // to be completed
        }

        //add a directed edge from “this” node to the node "to”
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.id);

            //to be completed. 
            //hint: add the id of node “to” to the adjacency list
        }
        public void RemoveEdge(GraphNode<T> to)
        {
            adjList.Remove(to.id);
        }


        // returns the adjacent list of the node
        public LinkedList<T> GetAdjList()
        {
            return adjList;
            //to be completed.
            // hint: returns the adjacency list
        }
    }
}
