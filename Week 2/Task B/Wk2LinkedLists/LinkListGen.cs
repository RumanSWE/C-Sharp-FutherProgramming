using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wk2_objects_Libary
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        

        public LinkListGen()
        {
            list = null; //create empty list (to add on etc)
        }
        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);//adds new linkgen
        }
        public string DisplayList()
        {

            LinkGen<T> temp = list; //temp start at the beging of the list
            string buffer = "";

            while (temp != null)    //keep going until end of list
            {

                buffer += temp.Data.ToString()+", ";
                temp = temp.Next;   //move a link forward

            }

            return buffer;

        }

        public int NumberOfItems()
        {
            int count = 0;
            LinkGen<T> temp = list; //temp start at the beging of the list
                                    //keep looping list.Data until list.Data is null
                                    //to go to next data use list.Next
            while (temp != null)

            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {

            LinkGen<T> temp = list; //temp start at the beging of the list

            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {
                    return true;
                }

                temp = temp.Next;
            }
            return false;

            
        }

        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();

            while (temp != null)
            {

                if (item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);
                    list = newList.list;
                }
                temp = temp.Next;
            }
        }

        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
            {
                list = new LinkGen<T>(item, null);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item, null);
            }

        }
    
        public void Sort(string[] arrayISBN)
        {
            string buffer = " ";

            Console.Write("Unsorted ISBN:");
            for (int i = 0; i < arrayISBN.Length; i++) //display unsorted array

            {
               
                Console.Write(buffer + arrayISBN[i]);
            }
            Array.Sort(arrayISBN);//sort unsoted array
            Console.WriteLine(" ");
            Console.Write("Sorted ISBN:");
            for (int i = 0; i < arrayISBN.Length;i++)
            {
                Console.Write(buffer + arrayISBN[i]);//display sorted array
            }
            Console.WriteLine(" ");

        }
        
        
    }
        
     

}



