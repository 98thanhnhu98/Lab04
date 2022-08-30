using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Staff : Employee
    {
        public string Title { get; set; }
        public override string Department { get; set; }
        public override float Salary { get; set; }
        public override DateTime Datehired { get; set; }
        public override string Name { get; set; }
        public override string Phone { get; set; }
        public override int Age { get; set; }
        public Staff(string title, string department, float salary, DateTime datehired, string name, string phone, int age)
        {
            Title = title;
            Department = department;
            Salary = salary;
            Datehired = datehired;
            Name = name;
            Phone = phone;
            Age = age;
        }

        public Staff() { } 
        public override string ToString()
        {
            return "Info Basic : \nName - " + Name +
                "\nAge - " + Age + "\nPhone - " + Phone +
                "\n===============\n" +
                "Job : Faculity\nDepartment - " + department +
                "Title - " + Title +
                "\nDay Star job - " + datehired.ToShortDateString();
        }
        public override string CalculBonus()
        {
            return "Salary Of Staff : " + (0.06 * Salary) + " USD";
        }

        public override string CalculationVacation()
        {
            Console.WriteLine("Your Vacation is : ");
            if(getyear() >= 5)
            {
               return "You get 4 weeks";
            }
            else
            {
                return "You get 3 weeks";
            }
        }

        public override int getyear()
        {
            TimeSpan age = DateTime.Now - Datehired;
            int year = age.Days / 365;
            return year;
        }
    }
}
