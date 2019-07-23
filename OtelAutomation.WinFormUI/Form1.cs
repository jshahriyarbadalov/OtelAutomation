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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UnitTypeForm ut = new UnitTypeForm();
        private void unitTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ut.IsDisposed)
            {
                ut=new UnitTypeForm();
            }

            ut.MdiParent = this;
            ut.Show();
        }

        CashForm cashf=new CashForm();

        private void cashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cashf.IsDisposed)
            {
                cashf=new CashForm();
            }

            cashf.MdiParent = this;
            cashf.Show();
        }
        CategoryForm ctgf=new CategoryForm();
        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ctgf.IsDisposed)
            {
                ctgf =new CategoryForm();
            }

            ctgf.MdiParent = this;
            ctgf.Show();
        }
        ProductsForm pf=new ProductsForm();
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
            {
                pf=new ProductsForm();
            }

            pf.MdiParent = this;
            pf.Show();

        }
        RoomTurForm rtf=new RoomTurForm();
        private void roomTurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtf.IsDisposed)
            {
                rtf=new RoomTurForm();
            }

            rtf.MdiParent = this;
            rtf.Show();
        }
        RoomsForm rf=new RoomsForm();
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rf.IsDisposed)
            {
                rf=new RoomsForm();
            }

            rf.MdiParent = this;
            rf.Show();
        }
        SpecificationForm sf=new SpecificationForm();
        private void specificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
            {
                sf=new SpecificationForm();
            }

            sf.MdiParent = this;
            sf.Show();
        }
        RoomSpecificationForm rsf=new RoomSpecificationForm();
        private void roomSpecificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rsf.IsDisposed)
            {
                rsf=new RoomSpecificationForm();
            }

            rsf.MdiParent = this;
            rsf.Show();
        }
        CustomerForm csF=new CustomerForm();
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (csF.IsDisposed)
            {
                csF=new CustomerForm();
            }

            csF.MdiParent = this;
            csF.Show();
        }
        StaffsForm staffs=new StaffsForm();
        private void staffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (staffs.IsDisposed)
            {
                staffs=new StaffsForm();
            }

            staffs.MdiParent = this;
            staffs.Show();
        }

        SaleForm slf=new SaleForm();
        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (slf.IsDisposed)
            {
                slf=new SaleForm();
            }

            slf.MdiParent = this;
            slf.Show();
        }
    }
}
