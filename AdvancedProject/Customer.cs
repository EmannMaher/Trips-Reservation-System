using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
    public class Customer:Person 
    {
        public string username;
        public string password;
        public bool cash;
        public Customer (string name, string mobileNum, string email, string gender,string ID,string username,string password) : base(name, mobileNum, email, gender,ID)
        {
            this.username= username;
            this.password = password;
        }
        public override string ToString()
        {
            return ("Customer name is "+ name + "and his/her mobile number is "+ mobileNum+ " ,email"+email+ "gender"+gender+ "\n username is "+username+ "\n password is "+ password);
        }
        public bool payment_status(bool cash)
        {
            if (cash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
