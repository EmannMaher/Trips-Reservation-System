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
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }
        static int i = 0, total = 0;
    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int price, quantity;
            string item;

            price = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            quantity = int.Parse(txt_quantity.Text);
            price = price * quantity;
            item = listView1.SelectedItems[0].Text;
            listView2.Items.Add(item);
            listView2.Items[i].SubItems.Add(price.ToString());
            i++;
            total = total + price;
            lbl_total.Text = total.ToString();
            lbl_total.Visible = true;
        }

        private void btn_orderCancle_Click(object sender, EventArgs e)
        {

            if (listView2.SelectedItems != null)
            {
                int deduct = 0;
                var confirm = MessageBox.Show("Are You Sure That You Want To Cancle Order", "DELETE ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {

                    for (int i = 0; i < listView2.Items.Count; i++)
                    {
                        if (listView2.Items[i].Selected)
                        {

                            deduct = int.Parse(listView2.Items[i].SubItems[1].Text);
                            listView2.Items[i].Remove();
                            i--;
                        }
                    }

                }
                total = total - deduct;
                lbl_total.Text = total.ToString();
                lbl_total.Visible = true;
            }
            else
            {
                MessageBox.Show("Select Item For Cancle order", "Cancle Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }
    }
}
