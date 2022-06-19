using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_objects_Libary
{
    class Person : IComparable
    {
        private int age;
        public string name;

        public Person(string name) //constructor with one argument
        {
            this.name = name;
            age = 18; //default age
        }
        public int Age
        {
            set { this.age = value; }
            get { return age; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }

    }

}
