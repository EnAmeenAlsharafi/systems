using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_House_Management_Sytem
{
    public partial class tenant_in : Form
    {
        public tenant_in()
        {
            InitializeComponent();
        }
        public void Atoufill()
        {
            cmb_stat_keyholder.SelectedIndex = 0;
            cmb_numBulb.SelectedIndex = 0;
            cmb_stat_bul.SelectedIndex = 0;
            cmb_stat_paint.SelectedIndex = 0;
            cmb_stat_windo.SelectedIndex = 0;
            cmb_stat_toil.SelectedIndex = 0;
            cmb_stat_toilDor.SelectedIndex = 0;
            cmb_stat_wach.SelectedIndex = 0;
            cmb_stat_door.SelectedIndex = 0;
        }
        Database db = new Database();
        DataTable tb = new DataTable();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tenant_in_Load(object sender, EventArgs e)
        {
            Atoufill();
            txt_contractId.Text = Properties.Settings.Default.contrqctId.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            db.readData("insert into tenant_in values(" + txt_contractId.Text + ",'"+cmb_stat_keyholder+"','"+cmb_numBulb+"',"+cmb_stat_bul+",'"+cmb_stat_paint.Text+"','"+cmb_stat_windo.Text+"','"+cmb_stat_toil.Text+"','"+cmb_stat_wach.Text+"','"+cmb_stat_door.Text+"','"+cmb_stat_toilDor.Text+"',"+txt_water_un.Text+",)", "A partement has been checked");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
