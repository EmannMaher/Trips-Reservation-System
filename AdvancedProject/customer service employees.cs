using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
   public class customer_service_employees:Emp 
    {
        public int hour;
        public int No_of_BookedRooms;
        public customer_service_employees(string name, string mobileNum, string email, string gender, string ID, int salary,int hours,int n) : base(name, mobileNum, email, gender, ID, salary)
        {
            hour = hours;
            No_of_BookedRooms = n;

        }
        public override string ToString()
        {
            return base.ToString() + "his/her acheived hours " + hour + " and number ofrooms he served last month is  " +No_of_BookedRooms;
        }
        public override double SalaryBonus(int salary, int No_of_BookedRooms)
        {
            if (No_of_BookedRooms < 160)
                return base.SalaryBonus(salary, No_of_BookedRooms);
            else
                return base.SalaryBonus(salary, No_of_BookedRooms) * 1.5;
        }
    }
}
