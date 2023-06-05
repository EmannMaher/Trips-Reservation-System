using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
    public class Emp:Person 
    {
        public int salary;
        public Emp(string name, string mobileNum, string email, string gender, string ID,int salary) : base(name, mobileNum, email, gender, ID)
        {
            this.salary= salary;
        }
        public override string ToString()
        {
            return ("Employee Name is "+name+" ,his Mobile Number is "+mobileNum+" and his salary is "+salary +"\n");
        }

        public virtual double SalaryBonus(int salary, int h)
        {
            h = 0;
            return (salary + 0.1*salary);
        }
    }
}
