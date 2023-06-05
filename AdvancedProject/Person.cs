using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
    public abstract class Person
    {
        public string name;
        public string mobileNum;
        public string email;
        public string gender;
        public string ID;
        public Person (string name,string mobileNum,string email,string gender,string ID)
        {
            this.name = name;
            this.mobileNum = mobileNum;
            this.email = email;
            this.gender = gender;
            this.ID = ID;
        }
    }
}
