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
    public partial class StaffsForm : Form
    {
        public StaffsForm()
        {
            InitializeComponent();
        }

        StaffORM stOrm=new StaffORM();

        private void StaffsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stOrm.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staffs st=new Staffs();
            st.Name = txtName.Text;
            st.Surname = txtSurname.Text;
            st.IDCARDNo = mskIDCARD.Text;
            st.PhoneNo = mskPhone.Text;
            st.Address = txtAddress.Text;
            st.BirthdayDate = dtpBirthday.Value;
            st.DateOfEntry = dtpJobStart.Value;
            st.Salary = numSalary.Value;
            st.Username = txtUsername.Text;
            st.Password = txtPassword.Text;

            bool result = stOrm.Insert(st);
            if(result)
            {
                MessageBox.Show("Staff added successful!");
                dataGridView1.DataSource = stOrm.Select();
            }
            else
            {
                MessageBox.Show("Staff added not successful!");
            }
        }
    }
}
