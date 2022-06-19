using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Queue2._0
{
    class Program
    {
        static void Main(string[] args)
        {



            IntQueue myqueue = new IntQueue();
            

            while(true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press and enter number keys to select option:");
                Console.WriteLine("1. Enqueue names");
                Console.WriteLine("2. Dequeue Names");
                Console.WriteLine("3. Show All Names");
                Console.WriteLine("4. Show Total Number Of Names");
                Console.WriteLine("5. Check If Queue Is Full");
                Console.WriteLine("6. Check If Queue Is Empty");
                Console.WriteLine("7. Show Last Name In List");
                Console.WriteLine("8. Exit");
                Console.WriteLine("");

                int menu = Convert.ToInt32(Console.ReadLine());
                
                switch (menu) 
                {
                    case 1:
                        Console.WriteLine("Enter Name To Add");
                        string addName = Convert.ToString(Console.ReadLine());
                        myqueue.Enqueue(addName);
                        break;
                    case 2:
                        Console.Write(myqueue.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.Write(myqueue.Display());
                        break;
                    case 4:
                        Console.Write("number of names:"+myqueue.QueueAmount());
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine(myqueue.IsFull());
                        break;
                    case 6: 
                        Console.WriteLine("");
                        Console.WriteLine(myqueue.IsEmpty());
                        break;
                    case 7:
                        Console.WriteLine("");
                        Console.WriteLine(myqueue.Peek());
                        break;
                    case 8:
                        System.Environment.Exit(1);
                        break;
              
                }
            }
        }
    }
}
