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
    public partial class SpecificationForm : Form
    {
        public SpecificationForm()
        {
            InitializeComponent();
        }

        SpecificationORM sOrm=new SpecificationORM();
        private void SpecificationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sOrm.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Specifications sp=new Specifications();
            sp.Name = txtName.Text;
            sp.Description = txtDescription.Text;

            bool result = sOrm.Insert(sp);

            if (result)
            {
                dataGridView1.DataSource = sOrm.Select();
                MessageBox.Show("Specification added successful!");
            }
            else
            {
                MessageBox.Show("Specification added not successful!");
            }
        }
    }
}
