using OtelAutomation.Facade;
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

namespace OtelAutomation.WinFormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffORM sfOrm=new StaffORM();
            Staffs st=new Staffs();
            st.Username = txtUsername.Text;
            st.Password = txtPassword.Text;
            Staffs active = sfOrm.Enter(st);

            if (active == null)
            {
                MessageBox.Show("Username or Password incorrect. Please check!");
            }
            else
            {
                StaffORM.ActiveUser = active;
                Form1 f=new Form1();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
