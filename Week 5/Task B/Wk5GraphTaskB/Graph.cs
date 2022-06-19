using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk5GraphTaskB
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
        public int NumNodesGraph(GraphNode<T> node)
        {
            return nodes.Count;
            // hint: how can you get the list of all nodes in the graph ? 
            // once you have that you can count (and return) how many elements are in the list             

        }


        public int NumEdgesGraph()
        {

            int edgeCount = 0;
            foreach (GraphNode<T> n in nodes)
            {
                edgeCount += n.GetAdjList().Count;
            }
            return edgeCount;
        }
       
        public bool ContainsGraph(GraphNode<T> node)
        {
            
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;

        }

      

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    bool b = from.GetAdjList().Contains(to.ID);
                    if (b == true)
                    { return true; }
                }
            }
            return false;
            

        }
        public GraphNode<T> GetNodeByID(T id)
        {
           
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
            }
            GraphNode<T> test = new GraphNode<T>(id);
            return test ;
           
        }
        public bool doesContain(string id)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if(n.ID.CompareTo(id) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public string getAllNodes()
        {
            string buffer = "";
            
            foreach(GraphNode<T> n in nodes)
            {
                buffer += n.ID + ", ";
            }
            return buffer;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null & n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.Write("Cannot add edge");
            }
        }
        public void RemoveEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null & n2 != null)
            { 
                n1.RemoveEdge(n2);
            } 
            else
            { 
                Console.Write("edge could not be removed"); 
            }
                
        }
        public void BreadthFirstraverse(T startID, ref List<T> visited)
        {


            LinkedList<T> adj;

            Queue<T> toVisit = new Queue<T>();

            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);


            while (toVisit.Count != 0)
            { 
             
                current = GetNodeByID(toVisit.Dequeue());

                visited.Add(current.id);

                adj = current.GetAdjList();
                
                foreach (T ID in adj)
                {
                    current = GetNodeByID(ID);
                    if (toVisit.Contains(current.ID) && visited.Contains(current.ID))
                    {
                        toVisit.Enqueue(current.ID);
                        visited.Add(current.ID);
                    }

                }
            }

        }
        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            //list as output as ref

            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Push(startID);

         
            while (toVisit.Count != 0 )
            {
                current = GetNodeByID(toVisit.Pop());
                visited.Add(current.id);

                adj = current.GetAdjList();

                foreach (T ID in adj)
                {
                    current = GetNodeByID(ID);
                    if (toVisit.Contains(current.ID) && visited.Contains(current.ID))
                    {
                        toVisit.Push(current.ID);
                        //visited.Add(current.ID);
                    }

                }
            }
           
        }
      
        public List<T> MotherVertex()
        {
            List<T> mother = new List<T>();

            foreach(GraphNode<T> n in nodes)
            {

            }
            return mother;
        }

    } //end class
}
