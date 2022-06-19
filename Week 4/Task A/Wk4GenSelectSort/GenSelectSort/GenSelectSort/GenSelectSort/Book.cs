using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSelectSort
{

    class Book : IComparable
    {

        public string ISBN;
        public string Title;
        public string Author;

        public Book(string ISBN, string Title, String Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }

        public override string ToString()
        {
            return Title + " by " + Author + " ISBN: " + ISBN;
        }


        // Complete the code of CompareTo to compare two objects of the class Book

        public int CompareTo(Object other)
        {
            
        }

    }

}
