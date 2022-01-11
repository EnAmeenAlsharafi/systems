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
using System.Data.SqlClient;

namespace Rental_House_Management_Sytem
{
    public partial class tenants : DevExpress.XtraEditors.XtraForm
    {
        public tenants()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        public void AutoNember()
        {

            tb = db.readData("select max(tenant_id) from tenant", "");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();
                date_reg.Text = DateTime.Now.ToShortDateString();
                txt_name.Clear();
                txt_phone.Clear();
                txt_email.Clear();
                txt_occupation.Clear();
                txtsearch.Clear();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                btnnew.Enabled = true;
            }
        }
        int row;
        public void show()
        {
            tb.Clear();
            tb = db.readData("select * from tenant", "");
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("There is No Data");
            }
            else
            {
                txt_id.Text = tb.Rows[row][0].ToString();
                txt_name.Text = tb.Rows[row][1].ToString();
                txt_phone.Text = tb.Rows[row][2].ToString();
                txt_occupation.Text = tb.Rows[row][3].ToString();
                txt_email.Text = tb.Rows[row][4].ToString();
                this.Text = tb.Rows[row][5].ToString();
                DateTime df = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                date_reg.Value = df;
            }
            btnAdd.Enabled = false;
            btnnew.Enabled = true;
            btnsearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            search.Clear();
            search = db.readData("select * from tenant where name like'%" + txtsearch.Text + "%' ", "");
            try
            {
                txt_id.Text = search.Rows[0][0].ToString();
                txt_name.Text = search.Rows[0][1].ToString();
                txt_phone.Text = search.Rows[0][2].ToString();
                txt_occupation.Text = search.Rows[0][3].ToString();
                txt_email.Text = search.Rows[0][4].ToString();
                string date = search.Rows[0][5].ToString();
                DateTime df = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                date_reg.Value = df;
            }
            catch (Exception) { }
        }
        
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tenants_Load(object sender, EventArgs e)
        {
            AutoNember();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tb.Clear();
                string d = date_reg.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("insert into tenant values(" + txt_id.Text + ",'" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_occupation.Text + "','" + txt_email.Text + "','" + d + "','Inactive')", "Data hase been successfully entered");
                Properties.Settings.Default.tenantId = Convert.ToInt32(txt_id.Text);
                AutoNember();

            }
            catch (Exception ex)
            {

            }

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(tenant_id) from tenant", "");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            show();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            AutoNember();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(tenant_id) from tenant", "");
            if (Convert.ToInt32(tb.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tb.Clear();
                tb = db.readData("select count(tenant_id) from tenant", "");
                row = Convert.ToInt32(tb.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tb.Clear();
            db.ExecuteData("delete from tenant where tenant_id=" + txt_id.Text + "", "Data has been deleted");
            txt_id.Clear();
            txt_name.Clear();
            txt_occupation.Clear();
            txt_phone.Clear();
            txt_email.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = date_reg.Value.ToString("dd/MM/yyyy");
            db.ExecuteData(" update tenant set name='"+txt_name.Text+"',phone='"+txt_phone.Text+ "',occupation='" + txt_occupation.Text+"',email='"+txt_email.Text+"',datereg='"+date+"' where tenant_id="+txt_id.Text+"", "Date has been Updated successfully");
            AutoNember();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            contract frm = new contract();
            frm.ShowDialog();
        }
    }
}