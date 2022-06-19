using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_objects_Libary
{
    class Book : IComparable
    {
        public string title;
        public string ISBN;
        public Person author;

        public Book(string title)
        {
            this.title = title;
        }
        public Book(string title, string ISBN, Person author)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
        

        public int CompareTo(Object obj)
        //implementation of CompareTo
        {// 		for IComparable

            Book other = (Book)obj;
            return ISBN.CompareTo(other.ISBN);
        }

    }
}
