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
    public partial class contract : DevExpress.XtraEditors.XtraForm
    {
        public contract()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        int row;
        public void Autonumber()
        {
            tb = db.readData("Select max(contract_id) from contract", "");
            if (tb.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtid.Text = "1";
            }
            else
            {
                txtid.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();
                startday.Text = DateTime.Now.ToShortDateString();
                endday.Text = DateTime.Now.ToShortDateString();
                contract_sing.Text = DateTime.Now.ToShortDateString();
                btnAdd.Enabled = true;
               
               
               

          
            }
        }
       
        public void fillHouse()
        {
            cmb_house.DataSource = db.readData("select * from house where status='Empty'", "");
            cmb_house.DisplayMember = "house_Name";
            cmb_house.ValueMember = "house_id";
            btnAdd.Enabled = true;
           
        }
        public void fillTenant()
        {
           
           cmbTenant.DataSource = db.readData("select * from tenant where status_contract='Inactive' ", string.Empty);
            
            cmbTenant.DisplayMember = "name";
            cmbTenant.ValueMember = "tenant_id";
            btnAdd.Enabled = true;
         
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contract_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.tenantId.ToString();
            Autonumber();
            fillHouse();
            fillTenant();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string startDay = startday.Value.ToString("dd/MM/yyyy");
            string endDay = endday.Value.ToString("dd/MM/yyyy");
            string con_sing = contract_sing.Value.ToString("dd/MM/yyyy");
            int totle = Convert.ToInt32(txt_total_rent.Text);
            int term = Convert.ToInt32(cmb_pay_terms.SelectedItem);
            float rent_per_term = totle / term;
            String status = "Occupied";
            db.ExecuteData("insert into contract values(" + txtid.Text + ","+cmbTenant.SelectedValue+","+cmb_house.SelectedValue+",'"+cmb_con_duration.SelectedItem+"',"+totle+",'"+cmb_pay_terms.SelectedItem+"',"+rent_per_term+",'"+startDay+"','"+endDay+"','"+con_sing+"','"+cmbStatus.SelectedItem+"')", "Data hase been successfully entered");
            db.ExecuteData(" update house set status= '"+status+"' where house_id=" + cmb_house.SelectedValue+"", "");
            db.ExecuteData("update tenant set status_contract='"+cmbStatus.SelectedItem+"'where tenant_id="+cmbTenant.SelectedValue+" ", "");
            Properties.Settings.Default.contrqctId = Convert.ToInt32(txtid.Text);
              txtid.Clear();
            txt_total_rent.Clear();

            Autonumber();
            fillHouse();
            fillTenant();

        }

        private void cmb_house_SelectedValueChanged(object sender, EventArgs e)
        {
        
        }

        private void cmb_house_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.readData("select * from house where house_id=" + cmb_house.SelectedValue + " ", "");
            txt_total_rent.Text =  tbl.Rows[0][2].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            tenant_in frm = new tenant_in();
            frm.ShowDialog();
                   }
    }
}