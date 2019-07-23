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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        ProductORM pOrm=new ProductORM();
        CategoryORM ctgOrm=new CategoryORM();
        UnitTypeORM uOrm=new UnitTypeORM();

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            combUnit.DataSource = uOrm.Select();
            combUnit.ValueMember = "id";
            combUnit.DisplayMember = "Name";

            combCategory.DataSource = ctgOrm.Select();
            combCategory.ValueMember = "Id";
            combCategory.DisplayMember = "Name";

            dataGridView1.DataSource = pOrm.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Products p=new Products();
           p.Name = txtName.Text;
           p.Quantity =(double)numQuantity.Value;
           p.Price = numPrice.Value;

           p.UnitTypeID = (int) combUnit.SelectedValue;
           p.CategoryID = (int) combCategory.SelectedValue;

           bool result = pOrm.Insert(p);
           if (result)
           {
               MessageBox.Show("Added successful!");
               dataGridView1.DataSource = pOrm.Select();
            }
           else
           {
               MessageBox.Show("Added not successful!");
           }
        }
    }
}
