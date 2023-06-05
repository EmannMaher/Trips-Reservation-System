using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Customer_Feedback : Form
    {
        public Customer_Feedback()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CustDashboard ds = new CustDashboard();
            this.Hide();
            ds.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(guna2TextBox1.Text) > 7)
            {
                MessageBox.Show("Thank you for the good rating :)");
            }
            else if (Convert.ToInt32(guna2TextBox1.Text) > 5)
            {
                MessageBox.Show("Thank you, we will improve our service -_-");
            }
            else
            {
                MessageBox.Show("we apologize for our bad services. :(");
            }

        }
    }
}
