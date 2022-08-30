using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal abstract class Employee : Person
    {
        internal string department;
        internal float salary;
        internal DateTime datehired;
         
        public abstract string Department { get; set; }
        public abstract float Salary { get; set; }
        
        public abstract DateTime Datehired { get; set; }

        /*TimeSpan age = DateTime.Now - DateOfBirth;
        int year = age.Days / 365;
        int month = (age.Days - year * 365) / 30;
        int day = (age.Days - month * 365 - month * 30);

            return year.ToString() + " tuổi " + month.ToString() + " tháng " + day.ToString() + " ngày";
*/
        public abstract string CalculBonus();
        public abstract string CalculationVacation();

        public abstract int getyear();

    }
}
