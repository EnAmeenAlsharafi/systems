namespace Rental_House_Management_Sytem
{
    partial class contract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contract));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_house = new System.Windows.Forms.ComboBox();
            this.cmbTenant = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_rent = new System.Windows.Forms.TextBox();
            this.cmb_pay_terms = new System.Windows.Forms.ComboBox();
            this.cmb_con_duration = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.contract_sing = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.startday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_house);
            this.groupBox1.Controls.Add(this.cmbTenant);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label11.Location = new System.Drawing.Point(7, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tenant Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(483, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "House Name:";
            // 
            // cmb_house
            // 
            this.cmb_house.FormattingEnabled = true;
            this.cmb_house.Location = new System.Drawing.Point(653, 31);
            this.cmb_house.Name = "cmb_house";
            this.cmb_house.Size = new System.Drawing.Size(168, 31);
            this.cmb_house.TabIndex = 1;
            this.cmb_house.SelectionChangeCommitted += new System.EventHandler(this.cmb_house_SelectionChangeCommitted);
            this.cmb_house.SelectedValueChanged += new System.EventHandler(this.cmb_house_SelectedValueChanged);
            // 
            // cmbTenant
            // 
            this.cmbTenant.FormattingEnabled = true;
            this.cmbTenant.Location = new System.Drawing.Point(186, 28);
            this.cmbTenant.Name = "cmbTenant";
            this.cmbTenant.Size = new System.Drawing.Size(168, 31);
            this.cmbTenant.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_total_rent);
            this.groupBox2.Controls.Add(this.cmb_pay_terms);
            this.groupBox2.Controls.Add(this.cmb_con_duration);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.contract_sing);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.endday);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.startday);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Location = new System.Drawing.Point(24, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(34, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "House Total Rent:";
            // 
            // txt_total_rent
            // 
            this.txt_total_rent.Location = new System.Drawing.Point(224, 49);
            this.txt_total_rent.Name = "txt_total_rent";
            this.txt_total_rent.ReadOnly = true;
            this.txt_total_rent.Size = new System.Drawing.Size(189, 29);
            this.txt_total_rent.TabIndex = 39;
            // 
            // cmb_pay_terms
            // 
            this.cmb_pay_terms.FormattingEnabled = true;
            this.cmb_pay_terms.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cmb_pay_terms.Location = new System.Drawing.Point(682, 52);
            this.cmb_pay_terms.Name = "cmb_pay_terms";
            this.cmb_pay_terms.Size = new System.Drawing.Size(200, 31);
            this.cmb_pay_terms.TabIndex = 38;
            // 
            // cmb_con_duration
            // 
            this.cmb_con_duration.FormattingEnabled = true;
            this.cmb_con_duration.Items.AddRange(new object[] {
            "6",
            "12"});
            this.cmb_con_duration.Location = new System.Drawing.Point(224, 198);
            this.cmb_con_duration.Name = "cmb_con_duration";
            this.cmb_con_duration.Size = new System.Drawing.Size(189, 31);
            this.cmb_con_duration.TabIndex = 37;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(224, 277);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 31);
            this.cmbStatus.TabIndex = 36;
            // 
            // contract_sing
            // 
            this.contract_sing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contract_sing.Location = new System.Drawing.Point(682, 280);
            this.contract_sing.Name = "contract_sing";
            this.contract_sing.Size = new System.Drawing.Size(200, 29);
            this.contract_sing.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(469, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Date Contract Sign:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label8.Location = new System.Drawing.Point(28, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status:";
            // 
            // endday
            // 
            this.endday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endday.Location = new System.Drawing.Point(682, 200);
            this.endday.Name = "endday";
            this.endday.Size = new System.Drawing.Size(200, 29);
            this.endday.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(469, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "End Day:";
            // 
            // startday
            // 
            this.startday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startday.Location = new System.Drawing.Point(682, 132);
            this.startday.Name = "startday";
            this.startday.Size = new System.Drawing.Size(200, 29);
            this.startday.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(469, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Strat Day:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(469, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Payment Terms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(28, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contract Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(28, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contract Number:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(224, 114);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(189, 29);
            this.txtid.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simpleButton1);
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Location = new System.Drawing.Point(161, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "oprationse";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(184, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(162, 58);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Check A partement";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Appearance.BackColor2 = System.Drawing.Color.Crimson;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(18, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(415, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 58);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Contract";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contract
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("contract.IconOptions.SvgImage")));
            this.Name = "contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = " ";
            this.Load += new System.EventHandler(this.contract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_house;
        private System.Windows.Forms.ComboBox cmbTenant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker startday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker contract_sing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ComboBox cmb_pay_terms;
        private System.Windows.Forms.ComboBox cmb_con_duration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total_rent;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}