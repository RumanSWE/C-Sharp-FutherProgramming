

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSelectSort
{
    class Program
    {

        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }



        // Implement here the generic Selection Sort (SelecSortGen)


        // use the main to test that SelecSortGen works
        static void Main(string[] args)
        {
            // Code to construct an array of Book

            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284",
                "9483294", "9823943" };

            Book[] library = new Book[10];


            // fill an array of books
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);

            }



            // call SelectSortGen to sort the array library (choose to sort the books by using either title, author or isbn)
            //display sorted array so you can check that the sorting method works also for an array of Book





            // create an array of int
            // call SelectSortGen to sort the array of int
            ////display sorted array so you can check that the sorting method works also for an array of int



            // create an array of string
            // call SelectSortGen to sort the array of string 
            ////display sorted array so you can check that the sorting method works also for an array of string


            Console.ReadKey();



        }
    }
}
