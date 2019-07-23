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
    public partial class RoomSpecificationForm : Form
    {
        public RoomSpecificationForm()
        {
            InitializeComponent();
        }

        private void RoomSpecificationForm_Load(object sender, EventArgs e)
        {
            RoomsORM rOrm=new RoomsORM();
            cmbRooms.DataSource = rOrm.Select();
            cmbRooms.DisplayMember = "Name";
            cmbRooms.ValueMember = "id";

            SpecificationORM sOrm=new SpecificationORM();
            listSpecification.DataSource = sOrm.Select();
            listSpecification.DisplayMember = "Name";
            listSpecification.ValueMember = "id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoomSpecificationORM rsOrm=new RoomSpecificationORM();
            RoomSpecification rs=new RoomSpecification();
            rs.RoomID = (int) cmbRooms.SelectedValue;
            rs.SpecificationID = (int) listSpecification.SelectedValue;
            short values;
            if (short.TryParse(txtValue.Text, out values))
            {
                rs.Value = values;
            }

            bool result = rsOrm.Insert(rs);
            
            if(result)
            {
                listSpecification.DataSource = rsOrm.Select();
                MessageBox.Show("Added successful!");
            }
            else
            {
                MessageBox.Show("Added not successful!");

            }
        }
    }
}
