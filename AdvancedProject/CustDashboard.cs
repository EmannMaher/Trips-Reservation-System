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
    public partial class CustDashboard : Form
    {
        public CustDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Feedback c = new Customer_Feedback();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activities s = new Activities();
            this.Hide();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restaurant  s = new Restaurant ();
            this.Hide();
            s.Show();
        }
    }
}
