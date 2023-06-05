using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Employee : Form
    {
        List<Person> pr;
        public Employee(List<Person> pr)
        {
            this.pr = pr;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {


            try
            {
                string un = txtUsername.Text, ps = txtPassword.Text;
                string nm = txtname.Text;
                string ph = txtPhone.Text;
                string ml = txtEmail.Text;
                string g = gender.SelectedText;
                int s = Convert.ToInt32(txtSalary.Text);

                if (un.Equals("") || ps.Equals("") || nm.Equals("") || ph.Equals(""))
                    throw new Exception();

                Receptionist f = new Receptionist(nm, ph, ml, g, "0000", s, un, ps);
                pr.Append(f);
                using (StreamWriter sr = new StreamWriter("D:/Documents/AdvancedProject/AdvancedProject/IN/Users.txt", true))
                {
                    sr.WriteLine("\n" + un + "," + ps);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Valid Data");
                return;
            }

            MessageBox.Show("Added");
    }
    }
}
