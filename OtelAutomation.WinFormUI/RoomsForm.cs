using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelAutomation.Entity;
using OtelAutomation.Facade;

namespace OtelAutomation.WinFormUI
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }
        RoomsORM rOrm=new RoomsORM();
        RoomTurORM rtOrm=new RoomTurORM();
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            Lists();
            cmbRoomTur.DataSource = rOrm.Select();
            cmbRoomTur.ValueMember = "id";
            cmbRoomTur.DisplayMember = "Name";
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Name = txtName.Text;
            r.Description = txtDescription.Text;
            r.Capacity =(short) numCapacity.Value;
            r.CardNo = (short) numCardN.Value;
            r.RoomTurID = (int) cmbRoomTur.SelectedValue;

            bool result = rOrm.Insert(r);
            if (result)
            {
                Lists();
                MessageBox.Show("Room added successful!");
            }
            else
            {
                MessageBox.Show("Room added not successful!");
            }
        }

        void Lists()
        {
            dataGridView1.DataSource = rOrm.Select();
        }
    }
}
