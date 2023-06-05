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
    public partial class CheckOut : Form 
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Dashboard  ds = new Dashboard ();
            this.Hide();
            ds.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
