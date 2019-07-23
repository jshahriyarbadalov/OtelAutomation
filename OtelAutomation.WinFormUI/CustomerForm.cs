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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        CustomerORM cOrm=new CustomerORM();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cOrm.Select();
            cmbMStatus.DataSource = Enum.GetNames(typeof(MaritalStatus));
            cmbGender.DataSource = Enum.GetNames(typeof(Gender));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers cs=new Customers();
            cs.Name = txtName.Text;
            cs.Surname = txtSurname.Text;
            cs.CompanyName = txtCompany.Text;
            cs.IDCARDNo = mskIDCARD.Text;
            cs.PhoneNo = mskPhone.Text;
            cs.BirthdayDate = dtpBirthday.Value;
            cs.MaritalStatus =(MaritalStatus) Enum.Parse(typeof(MaritalStatus),cmbMStatus.SelectedItem.ToString());
            cs.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.SelectedItem.ToString());

            bool result = cOrm.Insert(cs);

            if (result)
            {
                dataGridView1.DataSource = cOrm.Select();
                MessageBox.Show("Customer added successful!");

            }
            else
            {
                MessageBox.Show("Customer added not successful!");
            }
        }
    }
}
