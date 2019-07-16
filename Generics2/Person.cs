using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    class Person : IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Age < other.Age)
            {
                return -1;
            }
            else if (Age > other.Age)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
