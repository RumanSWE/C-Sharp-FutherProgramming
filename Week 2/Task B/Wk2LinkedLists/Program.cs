using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_objects_Libary
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkListGen<string> Books = new LinkListGen<string>();
            List<string> isbnList = new List<string>(); //isbn sort list


            while (true)
            {
                Console.Write("Add title to the book: ");
                string Title = Console.ReadLine();

                Console.Write("Add isbn to book: ");
                string isbn = Console.ReadLine();

                Console.Write("Add name to book: ");
                string name = Console.ReadLine();

                Person author = new Person(name);


                Book book = new Book(Title, isbn, author);



                isbnList.Add(isbn); //isbn sort list


                Books.AddItem(book.title);
                Books.AddItem(book.ISBN);
                Books.AddItem(book.author.name.ToString());




                Console.WriteLine("(1) Remove  === (2) Display === (3) Sort by ISBN (4) Add ");
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {

                    Console.Write("Remove item from libary books: ");
                    string rmvItem = Console.ReadLine();

                    Books.RemoveItem(rmvItem);
                }
                else if (menu == 2)
                {

                    Console.WriteLine(Books.DisplayList());


                }
                else if (menu == 3)
                {

                    string[] arrayISBN = isbnList.ToArray();
                    Books.Sort(arrayISBN);

                }
                else
                {

                }



            }
            //Console.ReadKey();

        }
    }
}
