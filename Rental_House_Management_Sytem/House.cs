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
    public partial class House : DevExpress.XtraEditors.XtraForm
    {
        public House()
        {
            InitializeComponent();
        }
        Dashbord dash = new Dashbord();
        Database db = new Database();
        DataTable tb = new DataTable();
        public void AutoNember()
        {

           tb= db.readData("select max(house_id) from house", "");
            if((tb.Rows[0][0].ToString()==DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tb.Rows[0][0] )+1).ToString();
                txtName.Clear();
                txtAmount.Clear();
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
            tb = db.readData("select * from house", "");
          if(tb.Rows.Count<=0)
            {
                MessageBox.Show("there is no data");
            }
          else
            {
                txtID.Text = tb.Rows[row][0].ToString();
                txtName.Text = tb.Rows[row][1].ToString();
                txtAmount.Text = tb.Rows[row][2].ToString();
                cmbStatus.Text = tb.Rows[row][3].ToString();
                btnnew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true; 
                btnAdd.Enabled = false;
            }
        }
        private void House_Load(object sender, EventArgs e)
        {
            AutoNember();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void House_ID_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtName.Text=="")
                {
                    MessageBox.Show("please enter house name");
                }
                else if(txtAmount.Text=="")
                {
                    MessageBox.Show("please enter house Amount");
                }
                else
                {
                    db.ExecuteData("insert into house values(" + txtID.Text + ",'" + txtName.Text + "','" + txtAmount.Text + "','" + cmbStatus.SelectedItem + "')", "Data hase been successfully entered");
                }
                

            }
            catch (Exception)
            {
                
            }
            AutoNember();
            dash.Total();


        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            AutoNember();
            btnnew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false; ;
            btnAdd.Enabled = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tb.Clear();
          tb = db.readData("select count(house_id)from house", "");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update house set house_Name='" + txtName.Text + "' ,rent_per_month='" + txtAmount.Text + "',status='" + cmbStatus.SelectedItem + "' where house_id=" + txtID.Text + "", "Date has been updated successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete Data","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            db.ExecuteData("delete from house where house_id="+txtID.Text+"", "data delete");
            AutoNember();  
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(row==0)
            {
                tb.Clear();
                tb = db.readData("select count(house_id)from house", "");
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
            tb = db.readData("select count(house_id)from house", "");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable tb1 = new DataTable();
            if (txtsearch.Text=="")
            {
                MessageBox.Show("please enter house name");
            } else
            {
                tb1.Clear();
                tb1 = db.readData("select * from house where house_Name like'%"+txtsearch.Text+"%' ", "");
                txtID.Text = tb1.Rows[0][0].ToString();
                txtName.Text = tb1.Rows[0][1].ToString();
                txtAmount.Text = tb1.Rows[0][2].ToString();
                cmbStatus.Text = tb1.Rows[0][3].ToString();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            dash.Total();
            dash.Update();
        }
    }
}