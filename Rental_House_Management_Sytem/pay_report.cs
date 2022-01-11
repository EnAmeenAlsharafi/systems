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
    public partial class pay_report : DevExpress.XtraEditors.XtraForm
    {
        public pay_report()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        private void pay_report_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dtFrom.Value.ToString("yyyy-MM-dd");
            string date2 = dtTo.Value.ToString("yyyy-MM-dd");
            tb = db.readData("select payment_id as'payment number', tenant.name as 'tenant name',house.house_Name as 'house name',amount,pay_from as'payment from',pay_to as'payment to',date as 'payment date' from tenant,house,payment where tenant.tenant_id=payment.tenant_id and house.house_id=payment.house_id and convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'", "");
            if (tb.Rows.Count >= 1)
            {
                decimal sum = 0;
                DgvSearch.DataSource = tb;
                for (int i = 0; i <= tb.Rows.Count - 1; i++)
                {

                    sum += Convert.ToDecimal(tb.Rows[i][3]);
                }
                //لتقريب الى رقمين عشرين
                txtTotel.Text = Math.Round(sum, 2).ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            tb.Clear();
            //  DgvSearch.DataBindings();
            txtTotel.Text=null;

        }

        private void txtTotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}