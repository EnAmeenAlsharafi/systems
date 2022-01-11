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
    public partial class frm_Dshaboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_Dshaboard()
        {
            InitializeComponent();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Dshaboard_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click_1(object sender, EventArgs e)
        {
            House h = new House();
            h.ShowDialog();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            tenants frm = new tenants();
            frm.ShowDialog();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            contract frm = new contract();
            frm.ShowDialog();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            tenant_out frm = new tenant_out();
            frm.ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            tenant_in frm = new tenant_in();
            frm.ShowDialog();
        }
    }
}
