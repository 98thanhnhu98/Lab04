using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Student : Person
    {
        private string enrolled;
        public string Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }

        public override string Name { get; set; }
        public override string Phone { get; set; }
        public override int Age { get; set; }
        public Student( string enrolled, string name, string phone, int age)
        {
            Enrolled = enrolled;
            Name = name;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            return "Student : \nName : " + Name + "\n Age :" + Age;
        }
    }
}
