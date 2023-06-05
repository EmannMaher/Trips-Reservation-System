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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.modelDataSet.Rooms);

        }

        private void roomIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {/*
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                string phone = textBoxPhone.Text;
                string free = "";

                try
                {
                    int number = Convert.ToInt32(textBoxNumber.Text);
                    if (radioButtonYES.Checked)
                    {
                        free = "Yes";
                    }
                    else if (radioButtonNO.Checked)
                    {
                        free = "No";
                    }

                    if (room.addRoom(number, type, phone, free))
                    {
                        dataGridView1.DataSource = room.getRooms();
                        MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }
        }
}
