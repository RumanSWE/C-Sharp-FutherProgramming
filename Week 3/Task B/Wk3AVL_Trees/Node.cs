using System;
using System.Collections.Generic;
using System.Text;

namespace Assessed_exercise_2_1
{
    class Node<T> where T : IComparable<T>
    {
        private T data;
        private int balanceFactor = 0;
        public Node<T> Left, Right;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}