using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Rental_House_Management_Sytem
{
    public partial class frm_payment : DevExpress.XtraEditors.XtraForm
    {
        public frm_payment()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        public void AutoNember()
        {

            tb = db.readData("select max(payment_id) from payment", "");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtNum.Text = "1";
            }
            else
            {
                txtNum.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();

                nup_amount.Value = 0;
                dtFrom.Text = DateTime.Now.ToShortDateString();
                dateTo.Text = DateTime.Now.ToShortDateString();

            }
        }

        public void fillHouse()
        {
            cmbHouse.DataSource = db.readData("select * from contract,house where contract.house_id= house.house_id ", "");
            cmbHouse.DisplayMember = "house_Name";
            cmbHouse.ValueMember = "house_id";
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            AutoNember();
            fillHouse();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            try
            {
                
               
                tbl = db.readData("select distinct tenant.tenant_id from tenant,contract,house where tenant.tenant_id=contract.contract_id and contract.contract_id=" + cmbHouse.SelectedValue + " ", "");
                string tenant_id = tbl.Rows[0][0].ToString(); 
                string dateFrom = dtFrom.Value.ToString("dd/MM/yyyy");
                string dsteto = dateTo.Value.ToString("dd/MM/yyyy");
                string date = date_sing.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("insert into payment values("+txtNum.Text+ ","+ tenant_id + ","+ nup_amount .Value+ ",'"+dateFrom+"','"+ dsteto + "','"+date+"')", "Payment Has been Payed successfully");
                AutoNember();
            }
            catch (Exception )
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void nup_amount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.readData("select distinct tenant.name from tenant,contract,house where tenant.tenant_id=contract.contract_id and contract.contract_id=" + cmbHouse.SelectedValue+" ", "");
            txt_tenant.Text = tbl.Rows[0][0].ToString();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}