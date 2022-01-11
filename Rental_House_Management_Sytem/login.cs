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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();


        private void btn_login_Click(object sender, EventArgs e)
        {
            tb = db.readData("select * from users", "");
            string user_name = tb.Rows[0][1].ToString();
            string password = tb.Rows[0][2].ToString();
            if(txt_userName.Text==user_name && txt_password.Text==password)
            {
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("your userName or password is not correct");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}