using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AdvancedProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("D:/Documents/AdvancedProject/AdvancedProject/IN/Users.txt"))
            {
                string d;
                while ((d = sr.ReadLine()) != null)
                {
                    string[] data = d.Split(',');
                    try
                    {
                        if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
                            throw new Exception("Enter User and Pass");
                        if (txtUsername.Text == data[0] && txtPassword.Text == data[1])
                        {
                            labelError.Visible = false;
                            Dashboard ds = new Dashboard();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
