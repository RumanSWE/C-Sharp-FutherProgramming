

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenSelectSort
{
    
    class Program 
    { 

       
        static void Main(string[] args)
        {

            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343565", "849328493", "389489325", "394834342", "983492389", "849283345", "483945554", "213313224", "348923948", "438932844",
                "948329454", "982394343" };
            string[] words = { "b", "a", "c", "f", "d", "e", "g", "J", "i", "h"  };
            int[] numbers = { 5, 6, 7, 3, 2, 1, 4, 9, 10, 8 };

            Book[] library = new Book[10];

            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);

            }
            SelectionSort<Book> bookSort= new SelectionSort<Book>();

            bookSort.Sort(library);

            Console.WriteLine("Sorted Array of Book titles: ");          
            for (int j = 0; j < library.Length; j++)
            {
                Console.WriteLine(library[j].Title);
            }

            /////////////////////
            
            Console.WriteLine("");
            Console.WriteLine("Sorted Array of integers: ");
            

            SelectionSort<int> intSort = new SelectionSort<int>();

           
            intSort.Sort(numbers);

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            ///////////////////////
            ///
            Console.WriteLine("");
            Console.WriteLine("Sorted Array of Strings: ");
            

            SelectionSort<string> stringSort = new SelectionSort<string>();

            stringSort.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            

            Console.ReadKey();
        }
       
    }
}
