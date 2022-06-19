using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Queue2._0
{
    class IntQueue                     
    { 


        private readonly int maxsize = 10;
        private string[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;
        public int result = 0;
        
        
        

        public IntQueue()
        {
            store = new string[maxsize];
        }

        public IntQueue(int size)
        {
            maxsize = size;
            store = new string[maxsize];
        }

        public void Enqueue(string value)
        {
            numItems++;
            
            store[tail] = value;
            if (++tail == maxsize) // wrap around array
            {
                tail = 0;

            }
        }
        public int QueueAmount()
        {
            int result = store.Count(s => s != null);
            return result;
        }

        public string Dequeue()
        {
            string headItem;
            numItems--;
            headItem = store[head];

            if (++head == maxsize)
            {     
                head = 0;
            }
            return headItem;
        }
        public string Display() //THIS WORKS
        {

            if ( numItems == 0)
             {
            Console.WriteLine("Error Empty list");
             }
             else
             {
                foreach(string item in store)
                {
                 Console.Write(item+" ");
               
                 }
             
             }
            return null;
        }
        
        public string Peek()// THIS WORKS
        {
          if (numItems != 0)
          {
            return store[tail-1];
          }
          else 
          {
            return null;
          }
        }

        public bool IsEmpty() //THIS WORKS
        {
            return (result == 0);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }
        public bool IsFull() //THIS WORKS
        {
            return (result == maxsize);
 
        }   
    }
}
