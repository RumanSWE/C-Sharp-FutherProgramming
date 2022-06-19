using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk5GraphTaskB
{
    public partial class Form1 : Form
    {
        Graph<string> myGraph = new Graph<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        private void addConnectionBtn_Click(object sender, EventArgs e)
        {
            if (!(myGraph.doesContain(connectFromTxt.Text) && myGraph.doesContain(connectToTxt.Text)))
            {
                myGraph.AddEdge(connectFromTxt.Text, connectToTxt.Text);
                Console.WriteLine("edge added");
                Console.WriteLine(myGraph.NumEdgesGraph());
            }
            string[] words = myGraph.getAllNodes().Split(',');
            for (int i = 0; i < words.Length; i++)
            {

            }

            txtConnection.Text = connectFromTxt.Text;
            txtConnection.Text = connectToTxt.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (myGraph.doesContain(AddAirport.Text))
            {
                myGraph.AddNode(AddAirport.Text);
            }
            else
            {
                Console.WriteLine("Airport already exists");
            }

            string[] words = myGraph.getAllNodes().Split(',');
            string displayWords = " ";

            for (int i = 0; i < words.Length; i++)
            {
                displayWords += words[i] + "\r\n";
                Console.WriteLine("add");
            }
            allAirports.Text = displayWords;
            
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Text = "test";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();

            
            myGraph.BreadthFirstraverse(reachableTxt.Text,ref temp);

            temp.Count();
            string wordDisp = " ";
            foreach (string s in temp)
            {
                wordDisp += s + "\r\n";
                Console.WriteLine("lookup");
            }
            searchTxt.Text = wordDisp;
            Console.WriteLine("lookup display");
        }

        
    }
}
