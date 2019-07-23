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
    public partial class RoomTurForm : Form
    {
        public RoomTurForm()
        {
            InitializeComponent();
        }
        RoomTurORM rtOrm=new RoomTurORM();

        private void RoomTurForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rtOrm.Select();
        }

        private void btnRoomTur_Click(object sender, EventArgs e)
        {
            RoomTur rt=new RoomTur();
            rt.Name = txtName.Text;
            rt.Description = txtDescription.Text;

            bool result = rtOrm.Insert(rt);
            if (result)
            {
                MessageBox.Show("Added successful!");
                dataGridView1.DataSource = rtOrm.Select();
            }
            else
            {
                MessageBox.Show("Added not successful!");
            }
        }
    }
}
