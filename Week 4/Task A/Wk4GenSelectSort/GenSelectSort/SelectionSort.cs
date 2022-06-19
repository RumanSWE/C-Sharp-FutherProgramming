using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSelectSort
{
    class SelectionSort<T> where T : IComparable
    {
        public T[] Sort(T[] list)
        {
            int smallest;
            T temp;

            for (int i = 0; i < list.Length; i++)
            {
                smallest = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[smallest]) < 0) 
                    {
                        smallest = j;
                    }
                }
                temp = list[i];
                list[i] = list[smallest];
                list[smallest] = temp;  //swap
            }
            return list;
        }
    }
}
