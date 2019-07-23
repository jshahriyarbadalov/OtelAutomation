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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        CategoryORM cOrm =new CategoryORM();
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cOrm.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category ctg=new Category();
            ctg.Name = textBox1.Text;
            bool result = cOrm.Insert(ctg);
            if (result)
            {
                MessageBox.Show("Added successful!");
                dataGridView1.DataSource = cOrm.Select();
            }
            else
            {
                MessageBox.Show("Added not successful!");

            }
        }
    }
}
