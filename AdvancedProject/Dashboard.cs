using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvancedProject
{
    public partial class Dashboard : Form
    {
        List<Person> pr;
        List<Person> pe;
        public Dashboard()
        {
            pr = new List<Person>();
            pe = new List<Person>();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnCustomerReg_Click_1(object sender, EventArgs e)
        {
            CustomerRegistration rg = new CustomerRegistration(pe);
            this.Hide();
            rg.Show();

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom rm = new AddRoom();
            this.Hide();
            rm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut ck = new CheckOut();
            this.Hide();
            ck.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee em = new Employee(pr);
            this.Hide();
            em.Show();
        }
    }
}
