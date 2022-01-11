using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rental_House_Management_Sytem
{
    public partial class Dashbord : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
       
        public void Total()
        {
           tb= db.readData("select count(house_id) from house", "");
            lab_Total_House.Text = "Total Number of Houses :" + tb.Rows[0][0].ToString();
            tb = db.readData("select count(contract_id) from contract", "");
            lab_contract.Text = "Total Number of Contract :" + tb.Rows[0][0].ToString();
            tb = db.readData("select count(tenant_id) from tenant", "");
            lab_tenant.Text = "Total Number of Tenants :" + tb.Rows[0][0].ToString();
            tb = db.readData("select count(house_id) from house", "");
            lab_Total_House.Text = "Total Number of Houses :" + tb.Rows[0][0].ToString();
            tb = db.readData("select sum(amount) from payment", "");
            lab_payaid.Text = "Total Income :$" + tb.Rows[0][0].ToString();
            tb = db.readData("select count(house_id) from house where status='Empty'", "");
            lab_empty.Text = " Empty Houses :" + tb.Rows[0][0].ToString();
            tb = db.readData("select count(house_id) from house where status='Occupied'", "");
            lab_accupaid.Text = " Occupied Houses :" + tb.Rows[0][0].ToString();
            tb = db.readData("select distinct count(tenant.tenant_id) from tenant,payment where tenant.tenant_id =payment.tenant_id", "");
            lab_unpaid.Text = " Unpaid Houses :" + tb.Rows[0][0].ToString();

        }
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            House frm = new House();
            frm.ShowDialog();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            tenants frm = new tenants();
            frm.ShowDialog();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            tenant_in frm = new tenant_in();
            frm.ShowDialog();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            tenant_out frm = new tenant_out();
            frm.ShowDialog();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            contract frm = new contract();
            frm.ShowDialog();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            frm_payment frm = new frm_payment();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            Total();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void Dashbord_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void fluentDesignFormContainer1_MouseHover(object sender, EventArgs e)
        {
            Total();
            int i = 0;
            login frm = new login();
            if (Properties.Settings.Default.log==0)
            {
                
                frm.ShowDialog();
                Properties.Settings.Default.log++;
            }
            else 
            {
                frm.Close();
            }
           
            
           
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            pay_report frm = new pay_report();
            frm.ShowDialog();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            house_report frm = new house_report();
            frm.ShowDialog();
        }
    }
}
