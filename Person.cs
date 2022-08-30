using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal abstract class Person
     {
        public abstract string Name { get; set; }
        public abstract string Phone { get; set; }
        public abstract int Age { get; set; }
    }
}
