using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
   public class Receptionist : Emp
    {
        public string username;
        public string password;
        public int hours;
        public Receptionist (string name, string mobileNum, string email, string gender, string ID,int salary,string username,string password) : base(name, mobileNum, email, gender, ID,salary)
        {
            this.username = username;
            this.password = password;
        }
        public override string ToString()
        {
            return base.ToString() + "his/her user name is "+ username + " and password is " + password;
        }
        public override double SalaryBonus(int salary, int hours)
        { if (hours < 100)
                return base.SalaryBonus(salary,hours);
            else
                return base.SalaryBonus(salary,hours) * 2;
        }

    }
}
