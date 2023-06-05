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
    public partial class CustomerRegistration : Form
    {
        List<Person> pe;
        public CustomerRegistration(List<Person> pe)
        {
            this.pe = pe;
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string cn = txtName.Text;
                string mn = txtMobile .Text;
                string cg = gender.SelectedText;
                string ci = txtId.Text;
                string em = txtMail.Text;
                string un = txtUN.Text;
                string pw = txtPW.Text;


                if (cn.Equals("") || mn.Equals("") || ci.Equals(""))
                    throw new Exception();

                Customer s = new Customer(cn, mn, cg, em, ci, un,pw);
                pe.Append(s);
                using (StreamWriter sr = new StreamWriter("D:/Documents/AdvancedProject/AdvancedProject/IN/Customers.txt", true))
                {
                    sr.WriteLine("\n" + un + "," + pw + "," + ci);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            MessageBox.Show("Registration Confirmed");
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
