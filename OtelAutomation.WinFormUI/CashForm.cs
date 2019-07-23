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
    public partial class CashForm : Form
    {
        public CashForm()
        {
            InitializeComponent();
        }
        CashORM cOrm=new CashORM();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cash c=new Cash();
            c.Name = txtName.Text;
            c.Description = txtDescription.Text;
            bool result = cOrm.Insert(c);
            if (result)
            {
                MessageBox.Show("Cash Added Successful!");
                dataGridView1.DataSource = cOrm.Select();
            }
            else
            {
                MessageBox.Show("Cash Added Not Successful!");
            }
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cOrm.Select();
        }
    }
}
