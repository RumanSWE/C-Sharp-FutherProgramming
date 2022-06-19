using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Wk4TaskB
{

    public partial class Form1 : Form
    {
        List<Request> inserts = new List<Request>();
       

        public Form1()
        {
            InitializeComponent();

        }
        public bool timeValid(string time)
        {
            Regex regExp = new Regex(@"(([0-1][0-9])|([2][0-3])).([0-5][0-9])");
            return regExp.IsMatch(time.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (timeValid(textTimeIn.Text) == true && timeValid(textTimeOut.Text) == true)
            {
     
                int id = Convert.ToInt32(textID.Text);
                float t1 = float.Parse(textTimeIn.Text);
                float t2 = float.Parse(textTimeOut.Text);

                inserts.Add(new Request(id, t1, t2));
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string temp = "";
            
            foreach (Request r in inserts)
            {
                temp += r.display() + "\r\n";
            }
            txtDisplay.Text = temp;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            
            List<Request> SortedFinish = inserts.OrderBy(o => o.finishTime).ToList();//sorted by finish time
        


            var temp = SortedFinish.FirstOrDefault();
            
            string buffer = temp.id.ToString();
            buffer += ", ";

            int i = 0;
           
            foreach (Request x in SortedFinish)
            {

                i++;
                if (temp.finishTime < x.startTime)
                {
                    Console.WriteLine(i);

                    temp = SortedFinish[i-1];

                    buffer += temp.id.ToString() + ", ";
                    Console.WriteLine(buffer);
                   
                }
            }
            txtSortDisplay.Text = buffer;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
