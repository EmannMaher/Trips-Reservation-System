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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("D:/Documents/AdvancedProject/AdvancedProject/IN/Customers.txt"))
            {
                string d;
                while ((d = sr.ReadLine()) != null)
                {
                    string[] data = d.Split(',');
                    try
                    {
                        if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
                            throw new Exception("Enter Username and Password");
                        if (txtUsername.Text == data[0] && txtPassword.Text == data[1])
                        {
                            labelError.Visible = false;
                            CustDashboard  ds = new CustDashboard();
                            this.Hide();
                            ds.Show();
                            return;
                        }
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                        return;
                    }
                }

                labelError.Visible = true;
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm x = new LoginForm();
            this.Hide();
            x.Show();
        }
    }
}
