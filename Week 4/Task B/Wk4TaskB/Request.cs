using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Wk4TaskB
{
    class Request : IComparable
    {
        public float startTime;
        public float finishTime;
        public int id;

        public Request(int iD, float start, float finish)
        {
            id = iD;
            startTime = start;
            finishTime = finish;
        }
        public Request()
        {
        }

        public float StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public float FinishTime
        {
            get { return finishTime; }
            set { finishTime = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string display()
        {
            return "ID: " + this.id.ToString() + "\r\n" + "Start Time: " + this.startTime.ToString() + "\r\n" + "Finsh Time: " + this.finishTime.ToString();
        }
        public int CompareTo(Object obj)
        //implementation of CompareTo
        {// 		for IComparable

            Request other = (Request)obj;
            return finishTime.CompareTo(other.finishTime);
        }
    }
}