using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_objects_Libary
{
       class LinkGen<T> 
    {
        private T data;
        private LinkGen<T> next;

        public LinkGen(T item, LinkGen<T> list)
        {
            data = item;
            next = list;
        }
        public LinkGen<T> Next
        {
            set { next = value; }
            get { return next; }
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
    }

}
