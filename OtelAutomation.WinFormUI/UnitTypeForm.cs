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
    public partial class UnitTypeForm : Form
    {
        public UnitTypeForm()
        {
            InitializeComponent();
        }
        UnitTypeORM utOrm=new UnitTypeORM();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnitTypes ut=new UnitTypes();
            ut.Name = txtName.Text;
            bool result = utOrm.Insert(ut);
            if (result)
            {
                MessageBox.Show("Unit Type added successful!");
                dataGridView1.DataSource = utOrm.Select();
            }
            else
            {
                MessageBox.Show("Unit Type added not successful!");
            }

        }

        private void UnitTypeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utOrm.Select();
        }
    }
}
