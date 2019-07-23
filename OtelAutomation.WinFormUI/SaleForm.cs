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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            CustomerORM csOrm=new CustomerORM();
            cmbCustomer.DataSource = csOrm.Select();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "id";

            RoomsORM rOrm=new RoomsORM();
            cmbRoom.DataSource = rOrm.Select();
            cmbRoom.DisplayMember = "Name";
            cmbRoom.ValueMember = "id";

            ProductORM pOrm=new ProductORM();
            dataGridView1.DataSource = pOrm.Select();
        }

        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please, select product which you want!");
                return;
            }

            ListViewItem lvi=new ListViewItem();
            lvi.Text = (listView1.Items.Count + 1).ToString();
            lvi.SubItems.Add(dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString());
            lvi.SubItems.Add(numProdUnit.Value.ToString());
            lvi.SubItems.Add(numProdPrice.Value.ToString());
            lvi.SubItems.Add(numDiscount.Value.ToString());
            lvi.Tag = dataGridView1.CurrentRow.Cells["id"].Value;
            listView1.Items.Add(lvi);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaleORM saleOrm=new SaleORM();
            Sale s=new Sale();
            s.CustomerID =Convert.ToInt32(cmbCustomer.SelectedValue);
            s.RoomID = Convert.ToInt32(cmbRoom.SelectedValue);
            s.StaffID = StaffORM.ActiveUser.Id;
            s.RoomPrice = numProdPrice.Value;
            s.SaleDate=DateTime.Now;
           int sId=Convert.ToInt32(saleOrm.InsertScalar(s));
           if (sId > 0)
           {
               SaleDetailsORM sdOrm=new SaleDetailsORM();
               foreach (ListViewItem lvi in listView1.Items)
               {
                   
                   SaleDetails sd = new SaleDetails();
                   sd.SaleID = sId;
                   sd.ProductID = (int) lvi.Tag;
                   sd.Price = Convert.ToDecimal(lvi.SubItems[3].Text);
                   sd.Quantity = Convert.ToDouble(lvi.SubItems[2].Text);
                   sd.Discount = Convert.ToDouble(lvi.SubItems[4].Text);
                   sdOrm.Insert(sd);
               }
           }
        }
    }
}
