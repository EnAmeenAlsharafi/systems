using System;
using System.Data;
using System.Windows.Forms;

namespace Rental_House_Management_Sytem
{
    public partial class tenant : DevExpress.XtraEditors.XtraForm
    {
        public tenant()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        public void Autonumber()
        {
           
            tb = db.readData("select max(tenant_id) from tenant", "");
            if(tb.Rows[0][0].ToString()==DBNull.Value.ToString())
            {
                txtid.Text = "1";
            }
            else
            {
               
               
                txtid.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();

                dtDate.Text = DateTime.Now.ToShortDateString();
                txtname.Clear();
                txtoccuption.Clear();
                txtphone.Clear();
                txtemail.Clear();
                btnAdd.Enabled = true;
                btnnew.Enabled = true;
                btnsearch.Enabled = true;
                btnDelete.Enabled = false;

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
                txtid.Text = tb.Rows[row][0].ToString();
                txtname.Text = tb.Rows[row][1].ToString();
                txtphone.Text = tb.Rows[row][2].ToString();
                txtoccuption.Text = tb.Rows[row][3].ToString();
                txtemail.Text = tb.Rows[row][4].ToString();
                this.Text = tb.Rows[row][5].ToString();
                DateTime df = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtDate.Value = df;  
            }
            btnAdd.Enabled = false;
            btnnew.Enabled = true;
            btnsearch.Enabled = true;
            btnDelete.Enabled = true;

        }
        private void tenant_Load(object sender, EventArgs e)
        {
            Autonumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                 string d = dtDate.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("insert into tenant values(" + txtid.Text + ",'" + txtname.Text + "','" + txtphone.Text + "','" + txtoccuption.Text + "','" + txtemail.Text + "','" + d + "')", "Data hase been successfully entered");
                Autonumber();
                
            }
            catch (Exception ex)
            {

            }
           
            
        }

        private void datereg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(tenant_id) from tenant", "");
            if(Convert.ToInt32(tb.Rows[0][0])-1==row)
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(row==0)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(tenant_id) from tenant", "");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Autonumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tb.Clear();
            db.ExecuteData("delete from tenant where tenant_id="+txtid.Text+"", "Data has been deleted");
            txtid.Clear();
            txtname.Clear();
            txtoccuption.Clear();
            txtphone.Clear();
            txtemail.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        { 
            DataTable search = new DataTable();
            search.Clear();
            search = db.readData("select * from tenant where name like'%"+txtsearch.Text+"%' ", "");
            try
            {
                txtid.Text = search.Rows[0][0].ToString();
                txtname.Text = search.Rows[0][1].ToString();
                txtphone.Text = search.Rows[0][2].ToString();
                txtoccuption.Text = search.Rows[0][3].ToString();
                txtemail.Text = search.Rows[0][4].ToString();
               this.Text = search.Rows[0][5].ToString();
                DateTime df = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtDate.Value = df;
            }
            catch  (Exception){ }
            
            
        }
        
    }
}