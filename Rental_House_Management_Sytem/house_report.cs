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
    public partial class house_report : DevExpress.XtraEditors.XtraForm
    {
        public house_report()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dtFrom.Value.ToString("yyyy-MM-dd");
            string date2 = dtTo.Value.ToString("yyyy-MM-dd");
            tb = db.readData("select house_id as'house number', house_Name as 'house name',rent_per_month as 'house rent',status from house ", "");
            if (tb.Rows.Count >= 1)
            {
                
                DgvSearch.DataSource = tb;
              
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            tb.Clear();
            //  DgvSearch.DataBindings();
            txtTotel.Text = null;
        }

        private void house_report_Load(object sender, EventArgs e)
        {

        }
    }
}