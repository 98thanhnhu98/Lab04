using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Faculty : Employee
    {
        public int OfxficeHours { get; set; }
        public static int Rank { get; set;}

        public override string Department { get; set; }
        public override float Salary { get ; set ; }
        public override DateTime Datehired { get; set ; }


        public override string Name { get ; set; }
        public override string Phone { get; set ; }
        public override int Age { get; set ; }


        public Faculty(int ofxficeHours, string department, float salary, DateTime datehired, string name, string phone, int age)
        {
            OfxficeHours = ofxficeHours;
            Department = department;
            Salary = salary;
            Datehired = datehired;
            Name = name;
            Phone = phone;
            Age = age;
        }

        public string getRanker(int ranker)
        {
            if(ranker == 1)
            {
                return "Senior";
            }else if(ranker == 2)
            {
                return "Senior Lecturer";
            }
            else {
                return "";
            }
        }
        public override string ToString()
        {
            return "Info Basic : \nName - " + Name +
                "\nAge - "+Age + "\nPhone - " + Phone +
                "\n===============\n"+
                "Job : Faculity\nDepartment - "+ department+
                "Office Hours - " +OfxficeHours+" :hour\n"+
                "Day Star job - " + datehired.ToShortDateString();
        }
        public override string CalculBonus()
        {
            return "Salary of Faculity : " + ((1000 + 0.05) * Salary) + " USD";
        }


        public override string CalculationVacation()
        {
            int ranker = Rank;
            Console.WriteLine("Your Vacation is : ");
            if (getyear() < 3)
            {
                return "You get 4 weeks";
            }
            else if (getyear() >= 3)
            {
               return "You get 5 weeks";
            }
            else if (getyear() >= 3 && getRanker(ranker)== "Senior Lecturer")
            {
                return "You get 6 weeks";
            }
            else
            {
                return "NULL";
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
