using System.Windows.Forms;

namespace PetrolimexConfig
{
    partial class frmSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPing = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbAuthMode = new System.Windows.Forms.ComboBox();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtSqlServerName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPaymentServer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numApiPort = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAgasUrl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabConnectionConfig = new System.Windows.Forms.TabPage();
            this.tabAPIConfig = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLprServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbCreateInvoicePort = new System.Windows.Forms.TextBox();
            this.txbCreateInvoiceHost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbbComparePlate = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbTimeRepeatRefuel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txbCountDetect = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txbTimeDelayDetect = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txbTimeClearList = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.tabSystemDevice = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPC = new System.Windows.Forms.TabPage();
            this.dgvPC = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.PCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePC = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnThem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabStation = new System.Windows.Forms.TabPage();
            this.dgvStation = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.IDStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgasStationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteStation = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.dgvLocation = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControllerEtagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siticoneButton7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton8 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabController = new System.Windows.Forms.TabPage();
            this.dgvController = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.siticoneButton10 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton11 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.dgvCamera = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.siticoneButton13 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton14 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabPump = new System.Windows.Forms.TabPage();
            this.dgvPump = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.siticoneButton16 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton17 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numApiPort)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.siticoneTabControl1.SuspendLayout();
            this.tabConnectionConfig.SuspendLayout();
            this.tabAPIConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.tabSystemDevice.SuspendLayout();
            this.tabPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvController)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPump)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(265, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Auth Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(265, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(269, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnPing);
            this.groupBox1.Controls.Add(this.cbAuthMode);
            this.groupBox1.Controls.Add(this.txtSqlPassword);
            this.groupBox1.Controls.Add(this.txtSqlUsername);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.txtSqlServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1066, 633);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Connection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetrolimexConfig.Properties.Resources._true;
            this.pictureBox1.Location = new System.Drawing.Point(687, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPing
            // 
            this.btnPing.BorderRadius = 10;
            this.btnPing.BorderThickness = 2;
            this.btnPing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPing.ForeColor = System.Drawing.Color.White;
            this.btnPing.Location = new System.Drawing.Point(687, 248);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(85, 81);
            this.btnPing.TabIndex = 6;
            this.btnPing.Text = "Ping";
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // cbAuthMode
            // 
            this.cbAuthMode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbAuthMode.FormattingEnabled = true;
            this.cbAuthMode.Items.AddRange(new object[] {
            "SQL Auth",
            "Window Auth"});
            this.cbAuthMode.Location = new System.Drawing.Point(384, 210);
            this.cbAuthMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAuthMode.Name = "cbAuthMode";
            this.cbAuthMode.Size = new System.Drawing.Size(266, 29);
            this.cbAuthMode.TabIndex = 3;
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSqlPassword.Location = new System.Drawing.Point(384, 300);
            this.txtSqlPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(266, 29);
            this.txtSqlPassword.TabIndex = 5;
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSqlUsername.Location = new System.Drawing.Point(384, 255);
            this.txtSqlUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(266, 29);
            this.txtSqlUsername.TabIndex = 4;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDatabaseName.Location = new System.Drawing.Point(384, 165);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(266, 29);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // txtSqlServerName
            // 
            this.txtSqlServerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSqlServerName.Location = new System.Drawing.Point(384, 120);
            this.txtSqlServerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlServerName.Name = "txtSqlServerName";
            this.txtSqlServerName.Size = new System.Drawing.Size(266, 29);
            this.txtSqlServerName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1176, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPaymentServer);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.numApiPort);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(47, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(492, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API";
            // 
            // txtPaymentServer
            // 
            this.txtPaymentServer.Location = new System.Drawing.Point(89, 47);
            this.txtPaymentServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentServer.Name = "txtPaymentServer";
            this.txtPaymentServer.Size = new System.Drawing.Size(380, 23);
            this.txtPaymentServer.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "PayServer";
            // 
            // numApiPort
            // 
            this.numApiPort.Location = new System.Drawing.Point(89, 20);
            this.numApiPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numApiPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numApiPort.Name = "numApiPort";
            this.numApiPort.Size = new System.Drawing.Size(94, 23);
            this.numApiPort.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Port";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAgasUrl);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(47, 100);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(492, 80);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AutoPaymentLog";
            // 
            // txtAgasUrl
            // 
            this.txtAgasUrl.Location = new System.Drawing.Point(89, 48);
            this.txtAgasUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgasUrl.Name = "txtAgasUrl";
            this.txtAgasUrl.Size = new System.Drawing.Size(380, 23);
            this.txtAgasUrl.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "url";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 21);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 23);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Port";
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.tabConnectionConfig);
            this.siticoneTabControl1.Controls.Add(this.tabAPIConfig);
            this.siticoneTabControl1.Controls.Add(this.tabSystem);
            this.siticoneTabControl1.Controls.Add(this.tabSQL);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 60);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1260, 647);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 60);
            this.siticoneTabControl1.TabIndex = 4;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.SelectedIndexChanged += new System.EventHandler(this.siticoneTabControl1_SelectedIndexChanged);
            // 
            // tabConnectionConfig
            // 
            this.tabConnectionConfig.Controls.Add(this.groupBox1);
            this.tabConnectionConfig.Location = new System.Drawing.Point(184, 4);
            this.tabConnectionConfig.Name = "tabConnectionConfig";
            this.tabConnectionConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionConfig.Size = new System.Drawing.Size(1072, 639);
            this.tabConnectionConfig.TabIndex = 0;
            this.tabConnectionConfig.Text = "Connection Config";
            this.tabConnectionConfig.UseVisualStyleBackColor = true;
            // 
            // tabAPIConfig
            // 
            this.tabAPIConfig.Controls.Add(this.groupBox4);
            this.tabAPIConfig.Controls.Add(this.groupBox2);
            this.tabAPIConfig.Controls.Add(this.groupBox6);
            this.tabAPIConfig.Controls.Add(this.groupBox5);
            this.tabAPIConfig.Location = new System.Drawing.Point(184, 4);
            this.tabAPIConfig.Name = "tabAPIConfig";
            this.tabAPIConfig.Size = new System.Drawing.Size(1072, 639);
            this.tabAPIConfig.TabIndex = 3;
            this.tabAPIConfig.Text = "API";
            this.tabAPIConfig.UseVisualStyleBackColor = true;
            this.tabAPIConfig.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLprServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(47, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(492, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LPR api";
            // 
            // txtLprServer
            // 
            this.txtLprServer.Location = new System.Drawing.Point(89, 48);
            this.txtLprServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLprServer.Name = "txtLprServer";
            this.txtLprServer.Size = new System.Drawing.Size(380, 23);
            this.txtLprServer.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "LPR api";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbCreateInvoicePort);
            this.groupBox6.Controls.Add(this.txbCreateInvoiceHost);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Location = new System.Drawing.Point(47, 182);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(492, 80);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CreateInvoice";
            // 
            // txbCreateInvoicePort
            // 
            this.txbCreateInvoicePort.Location = new System.Drawing.Point(89, 18);
            this.txbCreateInvoicePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCreateInvoicePort.Name = "txbCreateInvoicePort";
            this.txbCreateInvoicePort.Size = new System.Drawing.Size(94, 23);
            this.txbCreateInvoicePort.TabIndex = 15;
            // 
            // txbCreateInvoiceHost
            // 
            this.txbCreateInvoiceHost.Location = new System.Drawing.Point(89, 48);
            this.txbCreateInvoiceHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCreateInvoiceHost.Name = "txbCreateInvoiceHost";
            this.txbCreateInvoiceHost.Size = new System.Drawing.Size(380, 23);
            this.txbCreateInvoiceHost.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 15);
            this.label23.TabIndex = 3;
            this.label23.Text = "Host";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 15);
            this.label22.TabIndex = 3;
            this.label22.Text = "Port";
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.groupBox7);
            this.tabSystem.Controls.Add(this.label9);
            this.tabSystem.Controls.Add(this.groupBox3);
            this.tabSystem.Controls.Add(this.groupBox8);
            this.tabSystem.Controls.Add(this.groupBox9);
            this.tabSystem.Location = new System.Drawing.Point(184, 4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(1072, 639);
            this.tabSystem.TabIndex = 4;
            this.tabSystem.Text = "Hệ thống";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbbComparePlate);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(93, 263);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(544, 72);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // cbbComparePlate
            // 
            this.cbbComparePlate.BackColor = System.Drawing.Color.Transparent;
            this.cbbComparePlate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbComparePlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbComparePlate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbComparePlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbComparePlate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbComparePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbComparePlate.ItemHeight = 30;
            this.cbbComparePlate.Items.AddRange(new object[] {
            "So sánh >= 4 kí tự"});
            this.cbbComparePlate.Location = new System.Drawing.Point(199, 22);
            this.cbbComparePlate.Name = "cbbComparePlate";
            this.cbbComparePlate.Size = new System.Drawing.Size(273, 36);
            this.cbbComparePlate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại so sánh BS :";
            this.label8.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbTimeRepeatRefuel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(93, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txbTimeRepeatRefuel
            // 
            this.txbTimeRepeatRefuel.Location = new System.Drawing.Point(273, 22);
            this.txbTimeRepeatRefuel.Name = "txbTimeRepeatRefuel";
            this.txbTimeRepeatRefuel.Size = new System.Drawing.Size(100, 23);
            this.txbTimeRepeatRefuel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thời gian cho phép đổ lại (không cần vào lại) ";
            this.label7.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txbCountDetect);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.txbTimeDelayDetect);
            this.groupBox8.Location = new System.Drawing.Point(93, 58);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(237, 100);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Detect";
            // 
            // txbCountDetect
            // 
            this.txbCountDetect.Location = new System.Drawing.Point(131, 22);
            this.txbCountDetect.Name = "txbCountDetect";
            this.txbCountDetect.Size = new System.Drawing.Size(100, 23);
            this.txbCountDetect.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Count Detect";
            this.label20.Click += new System.EventHandler(this.label19_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "TimeDelayDetect (ms)";
            this.label21.Click += new System.EventHandler(this.label19_Click);
            // 
            // txbTimeDelayDetect
            // 
            this.txbTimeDelayDetect.Location = new System.Drawing.Point(131, 59);
            this.txbTimeDelayDetect.Name = "txbTimeDelayDetect";
            this.txbTimeDelayDetect.Size = new System.Drawing.Size(100, 23);
            this.txbTimeDelayDetect.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txbTimeClearList);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Location = new System.Drawing.Point(354, 58);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(268, 100);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "WaitingList";
            // 
            // txbTimeClearList
            // 
            this.txbTimeClearList.Location = new System.Drawing.Point(147, 33);
            this.txbTimeClearList.Name = "txbTimeClearList";
            this.txbTimeClearList.Size = new System.Drawing.Size(100, 23);
            this.txbTimeClearList.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 15);
            this.label24.TabIndex = 1;
            this.label24.Text = "TimeClearList (minute)";
            this.label24.Click += new System.EventHandler(this.label19_Click);
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.tabSystemDevice);
            this.tabSQL.Location = new System.Drawing.Point(184, 4);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(1072, 639);
            this.tabSQL.TabIndex = 5;
            this.tabSQL.Text = "Cấu hình thiết bị";
            this.tabSQL.UseVisualStyleBackColor = true;
            // 
            // tabSystemDevice
            // 
            this.tabSystemDevice.Controls.Add(this.tabPC);
            this.tabSystemDevice.Controls.Add(this.tabStation);
            this.tabSystemDevice.Controls.Add(this.tabLocation);
            this.tabSystemDevice.Controls.Add(this.tabController);
            this.tabSystemDevice.Controls.Add(this.tabCamera);
            this.tabSystemDevice.Controls.Add(this.tabPump);
            this.tabSystemDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSystemDevice.ItemSize = new System.Drawing.Size(140, 60);
            this.tabSystemDevice.Location = new System.Drawing.Point(3, 3);
            this.tabSystemDevice.Name = "tabSystemDevice";
            this.tabSystemDevice.SelectedIndex = 0;
            this.tabSystemDevice.Size = new System.Drawing.Size(1066, 633);
            this.tabSystemDevice.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabSystemDevice.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSystemDevice.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSystemDevice.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabSystemDevice.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSystemDevice.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabSystemDevice.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSystemDevice.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSystemDevice.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabSystemDevice.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSystemDevice.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabSystemDevice.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabSystemDevice.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSystemDevice.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabSystemDevice.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabSystemDevice.TabButtonSize = new System.Drawing.Size(140, 60);
            this.tabSystemDevice.TabIndex = 2;
            this.tabSystemDevice.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSystemDevice.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabSystemDevice.SelectedIndexChanged += new System.EventHandler(this.siticoneTabControl2_SelectedIndexChanged);
            // 
            // tabPC
            // 
            this.tabPC.Controls.Add(this.dgvPC);
            this.tabPC.Controls.Add(this.panel1);
            this.tabPC.Location = new System.Drawing.Point(4, 64);
            this.tabPC.Name = "tabPC";
            this.tabPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPC.Size = new System.Drawing.Size(1058, 565);
            this.tabPC.TabIndex = 0;
            this.tabPC.Text = "PC";
            this.tabPC.UseVisualStyleBackColor = true;
            // 
            // dgvPC
            // 
            this.dgvPC.AllowUserToAddRows = false;
            this.dgvPC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPC.ColumnHeadersHeight = 40;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCID,
            this.ComputerName,
            this.IPAdress,
            this.PicPath,
            this.Description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPC.GridColor = System.Drawing.Color.Black;
            this.dgvPC.Location = new System.Drawing.Point(3, 64);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.ReadOnly = true;
            this.dgvPC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPC.RowHeadersVisible = false;
            this.dgvPC.RowTemplate.Height = 25;
            this.dgvPC.Size = new System.Drawing.Size(1052, 498);
            this.dgvPC.TabIndex = 3;
            this.dgvPC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPC.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvPC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPC.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPC.ThemeStyle.ReadOnly = true;
            this.dgvPC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPC.ThemeStyle.RowsStyle.Height = 25;
            this.dgvPC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPC_CellContentClick);
            this.dgvPC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPC_CellDoubleClick);
            // 
            // PCID
            // 
            this.PCID.DataPropertyName = "PCID";
            this.PCID.HeaderText = "ID";
            this.PCID.Name = "PCID";
            this.PCID.ReadOnly = true;
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "Tên máy tính";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.ReadOnly = true;
            // 
            // IPAdress
            // 
            this.IPAdress.DataPropertyName = "IPAdress";
            this.IPAdress.HeaderText = "Địa chỉ IP";
            this.IPAdress.Name = "IPAdress";
            this.IPAdress.ReadOnly = true;
            // 
            // PicPath
            // 
            this.PicPath.DataPropertyName = "PicPath";
            this.PicPath.HeaderText = "Đường dẫn ảnh";
            this.PicPath.Name = "PicPath";
            this.PicPath.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Ghi chú";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeletePC);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 61);
            this.panel1.TabIndex = 4;
            // 
            // btnDeletePC
            // 
            this.btnDeletePC.BorderRadius = 10;
            this.btnDeletePC.BorderThickness = 1;
            this.btnDeletePC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletePC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletePC.FillColor = System.Drawing.Color.Transparent;
            this.btnDeletePC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePC.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePC.Location = new System.Drawing.Point(141, 13);
            this.btnDeletePC.Name = "btnDeletePC";
            this.btnDeletePC.Size = new System.Drawing.Size(132, 45);
            this.btnDeletePC.TabIndex = 0;
            this.btnDeletePC.Text = "Xóa";
            this.btnDeletePC.Click += new System.EventHandler(this.btnDeletePC_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderThickness = 1;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(3, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabStation
            // 
            this.tabStation.Controls.Add(this.dgvStation);
            this.tabStation.Controls.Add(this.panel3);
            this.tabStation.Location = new System.Drawing.Point(4, 64);
            this.tabStation.Name = "tabStation";
            this.tabStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabStation.Size = new System.Drawing.Size(1058, 565);
            this.tabStation.TabIndex = 1;
            this.tabStation.Text = "Station";
            this.tabStation.UseVisualStyleBackColor = true;
            // 
            // dgvStation
            // 
            this.dgvStation.AllowUserToAddRows = false;
            this.dgvStation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvStation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStation.ColumnHeadersHeight = 40;
            this.dgvStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStation,
            this.AgasStationID,
            this.StationName,
            this.PCIDD,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStation.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStation.GridColor = System.Drawing.Color.Black;
            this.dgvStation.Location = new System.Drawing.Point(3, 64);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.ReadOnly = true;
            this.dgvStation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStation.RowHeadersVisible = false;
            this.dgvStation.RowTemplate.Height = 25;
            this.dgvStation.Size = new System.Drawing.Size(1052, 498);
            this.dgvStation.TabIndex = 5;
            this.dgvStation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStation.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvStation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvStation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStation.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStation.ThemeStyle.ReadOnly = true;
            this.dgvStation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvStation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStation.ThemeStyle.RowsStyle.Height = 25;
            this.dgvStation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStation_CellDoubleClick);
            // 
            // IDStation
            // 
            this.IDStation.DataPropertyName = "ID";
            this.IDStation.HeaderText = "ID";
            this.IDStation.Name = "IDStation";
            this.IDStation.ReadOnly = true;
            // 
            // AgasStationID
            // 
            this.AgasStationID.DataPropertyName = "AgasStationID";
            this.AgasStationID.HeaderText = "AgasStationID";
            this.AgasStationID.Name = "AgasStationID";
            this.AgasStationID.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "StationName";
            this.StationName.HeaderText = "StationName";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // PCIDD
            // 
            this.PCIDD.DataPropertyName = "PCID";
            this.PCIDD.HeaderText = "PCID";
            this.PCIDD.Name = "PCIDD";
            this.PCIDD.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteStation);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 61);
            this.panel3.TabIndex = 6;
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.BorderRadius = 10;
            this.btnDeleteStation.BorderThickness = 1;
            this.btnDeleteStation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteStation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteStation.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteStation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteStation.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStation.Location = new System.Drawing.Point(141, 13);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(132, 45);
            this.btnDeleteStation.TabIndex = 0;
            this.btnDeleteStation.Text = "Xóa";
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(3, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.dgvLocation);
            this.tabLocation.Controls.Add(this.panel4);
            this.tabLocation.Location = new System.Drawing.Point(4, 64);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(1058, 565);
            this.tabLocation.TabIndex = 2;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // dgvLocation
            // 
            this.dgvLocation.AllowUserToAddRows = false;
            this.dgvLocation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvLocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLocation.ColumnHeadersHeight = 40;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationID,
            this.LocationName,
            this.dataGridViewTextBoxColumn8,
            this.Camera1,
            this.Camera2,
            this.PumpID,
            this.ControllerEtagID,
            this.Column2,
            this.IsActive});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocation.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocation.GridColor = System.Drawing.Color.Black;
            this.dgvLocation.Location = new System.Drawing.Point(0, 61);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.ReadOnly = true;
            this.dgvLocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLocation.RowHeadersVisible = false;
            this.dgvLocation.RowTemplate.Height = 25;
            this.dgvLocation.Size = new System.Drawing.Size(1058, 504);
            this.dgvLocation.TabIndex = 5;
            this.dgvLocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLocation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocation.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvLocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLocation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvLocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLocation.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLocation.ThemeStyle.ReadOnly = true;
            this.dgvLocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvLocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocation.ThemeStyle.RowsStyle.Height = 25;
            this.dgvLocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // LocationID
            // 
            this.LocationID.DataPropertyName = "LocationID";
            this.LocationID.HeaderText = "LocationID";
            this.LocationID.Name = "LocationID";
            this.LocationID.ReadOnly = true;
            // 
            // LocationName
            // 
            this.LocationName.DataPropertyName = "LocationName";
            this.LocationName.HeaderText = "LocationName";
            this.LocationName.Name = "LocationName";
            this.LocationName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PCID";
            this.dataGridViewTextBoxColumn8.HeaderText = "PCID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Camera1
            // 
            this.Camera1.DataPropertyName = "Camera1";
            this.Camera1.HeaderText = "Camera1";
            this.Camera1.Name = "Camera1";
            this.Camera1.ReadOnly = true;
            // 
            // Camera2
            // 
            this.Camera2.DataPropertyName = "Camera2";
            this.Camera2.HeaderText = "Camera2";
            this.Camera2.Name = "Camera2";
            this.Camera2.ReadOnly = true;
            // 
            // PumpID
            // 
            this.PumpID.DataPropertyName = "PumpID";
            this.PumpID.HeaderText = "PumpID";
            this.PumpID.Name = "PumpID";
            this.PumpID.ReadOnly = true;
            // 
            // ControllerEtagID
            // 
            this.ControllerEtagID.DataPropertyName = "ControllerEtagID";
            this.ControllerEtagID.HeaderText = "ControllerEtagID";
            this.ControllerEtagID.Name = "ControllerEtagID";
            this.ControllerEtagID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.siticoneButton7);
            this.panel4.Controls.Add(this.siticoneButton8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 61);
            this.panel4.TabIndex = 6;
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.BorderRadius = 10;
            this.siticoneButton7.BorderThickness = 1;
            this.siticoneButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton7.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton7.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton7.Location = new System.Drawing.Point(141, 13);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton7.TabIndex = 0;
            this.siticoneButton7.Text = "Xóa";
            // 
            // siticoneButton8
            // 
            this.siticoneButton8.BorderRadius = 10;
            this.siticoneButton8.BorderThickness = 1;
            this.siticoneButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton8.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton8.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton8.Location = new System.Drawing.Point(3, 13);
            this.siticoneButton8.Name = "siticoneButton8";
            this.siticoneButton8.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton8.TabIndex = 0;
            this.siticoneButton8.Text = "Thêm";
            this.siticoneButton8.Click += new System.EventHandler(this.siticoneButton8_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.dgvController);
            this.tabController.Controls.Add(this.panel5);
            this.tabController.Location = new System.Drawing.Point(4, 64);
            this.tabController.Name = "tabController";
            this.tabController.Size = new System.Drawing.Size(1058, 565);
            this.tabController.TabIndex = 3;
            this.tabController.Text = "Controller";
            this.tabController.UseVisualStyleBackColor = true;
            // 
            // dgvController
            // 
            this.dgvController.AllowUserToAddRows = false;
            this.dgvController.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvController.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvController.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvController.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvController.ColumnHeadersHeight = 40;
            this.dgvController.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvController.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Type});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvController.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvController.GridColor = System.Drawing.Color.Black;
            this.dgvController.Location = new System.Drawing.Point(0, 61);
            this.dgvController.Name = "dgvController";
            this.dgvController.ReadOnly = true;
            this.dgvController.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvController.RowHeadersVisible = false;
            this.dgvController.RowTemplate.Height = 25;
            this.dgvController.Size = new System.Drawing.Size(1058, 504);
            this.dgvController.TabIndex = 5;
            this.dgvController.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvController.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvController.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvController.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvController.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvController.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvController.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvController.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvController.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvController.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvController.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvController.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvController.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvController.ThemeStyle.ReadOnly = true;
            this.dgvController.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvController.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvController.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvController.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvController.ThemeStyle.RowsStyle.Height = 25;
            this.dgvController.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvController.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn13.HeaderText = "Code";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn14.HeaderText = "Description";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Comport";
            this.dataGridViewTextBoxColumn15.HeaderText = "Comport";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Baudrate";
            this.Column1.HeaderText = "Baudrate";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CommunicationType";
            this.Column3.HeaderText = "CommunicationType";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PCID";
            this.Column4.HeaderText = "PCID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.siticoneButton10);
            this.panel5.Controls.Add(this.siticoneButton11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1058, 61);
            this.panel5.TabIndex = 6;
            // 
            // siticoneButton10
            // 
            this.siticoneButton10.BorderRadius = 10;
            this.siticoneButton10.BorderThickness = 1;
            this.siticoneButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton10.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton10.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton10.Location = new System.Drawing.Point(141, 13);
            this.siticoneButton10.Name = "siticoneButton10";
            this.siticoneButton10.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton10.TabIndex = 0;
            this.siticoneButton10.Text = "Xóa";
            // 
            // siticoneButton11
            // 
            this.siticoneButton11.BorderRadius = 10;
            this.siticoneButton11.BorderThickness = 1;
            this.siticoneButton11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton11.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton11.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton11.Location = new System.Drawing.Point(3, 13);
            this.siticoneButton11.Name = "siticoneButton11";
            this.siticoneButton11.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton11.TabIndex = 0;
            this.siticoneButton11.Text = "Thêm";
            this.siticoneButton11.Click += new System.EventHandler(this.siticoneButton11_Click);
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.dgvCamera);
            this.tabCamera.Controls.Add(this.panel6);
            this.tabCamera.Location = new System.Drawing.Point(4, 64);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Size = new System.Drawing.Size(1058, 565);
            this.tabCamera.TabIndex = 4;
            this.tabCamera.Text = "Camera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // dgvCamera
            // 
            this.dgvCamera.AllowUserToAddRows = false;
            this.dgvCamera.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvCamera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCamera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCamera.ColumnHeadersHeight = 40;
            this.dgvCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCamera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCamera.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCamera.GridColor = System.Drawing.Color.Black;
            this.dgvCamera.Location = new System.Drawing.Point(0, 61);
            this.dgvCamera.Name = "dgvCamera";
            this.dgvCamera.ReadOnly = true;
            this.dgvCamera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCamera.RowHeadersVisible = false;
            this.dgvCamera.RowTemplate.Height = 25;
            this.dgvCamera.Size = new System.Drawing.Size(1058, 504);
            this.dgvCamera.TabIndex = 5;
            this.dgvCamera.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCamera.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCamera.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCamera.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCamera.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCamera.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCamera.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvCamera.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCamera.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCamera.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCamera.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCamera.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCamera.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCamera.ThemeStyle.ReadOnly = true;
            this.dgvCamera.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCamera.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCamera.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCamera.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCamera.ThemeStyle.RowsStyle.Height = 25;
            this.dgvCamera.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCamera.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CameraID";
            this.dataGridViewTextBoxColumn16.HeaderText = "CameraID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CameraName";
            this.dataGridViewTextBoxColumn17.HeaderText = "CameraName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "HttpURL";
            this.dataGridViewTextBoxColumn18.HeaderText = "HttpURL";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "HttpPort";
            this.dataGridViewTextBoxColumn19.HeaderText = "HttpPort";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "RtspPort";
            this.dataGridViewTextBoxColumn20.HeaderText = "RtspPort";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserName";
            this.Column5.HeaderText = "UserName";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Password";
            this.Column6.HeaderText = "Password";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PCID";
            this.Column7.HeaderText = "PCID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FrameRate";
            this.Column8.HeaderText = "FrameRate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Resolution";
            this.Column9.HeaderText = "Resolution";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Channel";
            this.Column10.HeaderText = "Channel";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "CameraType";
            this.Column11.HeaderText = "CameraType";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "StreamType";
            this.Column12.HeaderText = "StreamType";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "SDK";
            this.Column13.HeaderText = "SDK";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Cgi";
            this.Column14.HeaderText = "Cgi";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "EnableRecording";
            this.Column15.HeaderText = "EnableRecording";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "PositionIndex";
            this.Column16.HeaderText = "PositionIndex";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "ResizeImage";
            this.Column17.HeaderText = "ResizeImage";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Description";
            this.Column18.HeaderText = "Description";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.siticoneButton13);
            this.panel6.Controls.Add(this.siticoneButton14);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1058, 61);
            this.panel6.TabIndex = 6;
            // 
            // siticoneButton13
            // 
            this.siticoneButton13.BorderRadius = 10;
            this.siticoneButton13.BorderThickness = 1;
            this.siticoneButton13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton13.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton13.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton13.Location = new System.Drawing.Point(141, 13);
            this.siticoneButton13.Name = "siticoneButton13";
            this.siticoneButton13.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton13.TabIndex = 0;
            this.siticoneButton13.Text = "Xóa";
            // 
            // siticoneButton14
            // 
            this.siticoneButton14.BorderRadius = 10;
            this.siticoneButton14.BorderThickness = 1;
            this.siticoneButton14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton14.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton14.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton14.Location = new System.Drawing.Point(3, 13);
            this.siticoneButton14.Name = "siticoneButton14";
            this.siticoneButton14.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton14.TabIndex = 0;
            this.siticoneButton14.Text = "Thêm";
            this.siticoneButton14.Click += new System.EventHandler(this.siticoneButton14_Click);
            // 
            // tabPump
            // 
            this.tabPump.Controls.Add(this.dgvPump);
            this.tabPump.Controls.Add(this.panel7);
            this.tabPump.Location = new System.Drawing.Point(4, 64);
            this.tabPump.Name = "tabPump";
            this.tabPump.Size = new System.Drawing.Size(1058, 565);
            this.tabPump.TabIndex = 5;
            this.tabPump.Text = "Pump";
            this.tabPump.UseVisualStyleBackColor = true;
            // 
            // dgvPump
            // 
            this.dgvPump.AllowUserToAddRows = false;
            this.dgvPump.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvPump.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPump.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPump.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPump.ColumnHeadersHeight = 40;
            this.dgvPump.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPump.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn24});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPump.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPump.GridColor = System.Drawing.Color.Black;
            this.dgvPump.Location = new System.Drawing.Point(0, 61);
            this.dgvPump.Name = "dgvPump";
            this.dgvPump.ReadOnly = true;
            this.dgvPump.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPump.RowHeadersVisible = false;
            this.dgvPump.RowTemplate.Height = 25;
            this.dgvPump.Size = new System.Drawing.Size(1058, 504);
            this.dgvPump.TabIndex = 5;
            this.dgvPump.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPump.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPump.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPump.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPump.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPump.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPump.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvPump.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPump.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPump.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPump.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPump.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPump.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPump.ThemeStyle.ReadOnly = true;
            this.dgvPump.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPump.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPump.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPump.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPump.ThemeStyle.RowsStyle.Height = 25;
            this.dgvPump.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPump.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn21.HeaderText = "ID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "PumpID";
            this.dataGridViewTextBoxColumn22.HeaderText = "PumpID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PCID";
            this.dataGridViewTextBoxColumn23.HeaderText = "PCID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn25.HeaderText = "Description";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn24.HeaderText = "IsActive";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.siticoneButton16);
            this.panel7.Controls.Add(this.siticoneButton17);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1058, 61);
            this.panel7.TabIndex = 6;
            // 
            // siticoneButton16
            // 
            this.siticoneButton16.BorderRadius = 10;
            this.siticoneButton16.BorderThickness = 1;
            this.siticoneButton16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton16.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton16.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton16.Location = new System.Drawing.Point(141, 13);
            this.siticoneButton16.Name = "siticoneButton16";
            this.siticoneButton16.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton16.TabIndex = 0;
            this.siticoneButton16.Text = "Xóa";
            // 
            // siticoneButton17
            // 
            this.siticoneButton17.BorderRadius = 10;
            this.siticoneButton17.BorderThickness = 1;
            this.siticoneButton17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton17.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton17.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton17.Location = new System.Drawing.Point(3, 13);
            this.siticoneButton17.Name = "siticoneButton17";
            this.siticoneButton17.Size = new System.Drawing.Size(132, 45);
            this.siticoneButton17.TabIndex = 0;
            this.siticoneButton17.Text = "Thêm";
            this.siticoneButton17.Click += new System.EventHandler(this.siticoneButton17_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.siticoneTabControl1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1260, 647);
            this.pnlBody.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 36);
            this.panel2.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 27);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "phút";
            this.label9.Click += new System.EventHandler(this.label19_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numApiPort)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabConnectionConfig.ResumeLayout(false);
            this.tabAPIConfig.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabSQL.ResumeLayout(false);
            this.tabSystemDevice.ResumeLayout(false);
            this.tabPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabStation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvController)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPump.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPump)).EndInit();
            this.panel7.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cbAuthMode;
        private TextBox txtSqlPassword;
        private TextBox txtSqlUsername;
        private TextBox txtDatabaseName;
        private TextBox txtSqlServerName;
        private Button btnSave;
        private GroupBox groupBox4;
        private NumericUpDown numApiPort;
        private Label label14;
        private TextBox txtPaymentServer;
        private Label label13;
        private GroupBox groupBox5;
        private TextBox txtAgasUrl;
        private Label label16;
        private NumericUpDown numericUpDown1;
        private Label label17;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage tabConnectionConfig;
        private TabPage tabAPIConfig;
        private Panel pnlBody;
        private Panel panel2;
        private TabPage tabSystem;
        private Label label20;
        private TextBox txbCountDetect;
        private Label label21;
        private TextBox txbTimeDelayDetect;
        private GroupBox groupBox6;
        private TextBox txbCreateInvoiceHost;
        private Label label22;
        private TextBox txbCreateInvoicePort;
        private Label label23;
        private Label label24;
        private TextBox txbTimeClearList;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private TabPage tabSQL;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabSystemDevice;
        private TabPage tabPC;
        private TabPage tabStation;
        private TabPage tabLocation;
        private TabPage tabController;
        private TabPage tabCamera;
        private TabPage tabPump;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvPC;
        private Panel panel1;
        private DataGridViewTextBoxColumn PCID;
        private DataGridViewTextBoxColumn ComputerName;
        private DataGridViewTextBoxColumn IPAdress;
        private DataGridViewTextBoxColumn PicPath;
        private DataGridViewTextBoxColumn Description;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDeletePC;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThem;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvStation;
        private Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDeleteStation;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvLocation;
        private Panel panel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton8;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvController;
        private Panel panel5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton10;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton11;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCamera;
        private Panel panel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton12;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton13;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton14;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvPump;
        private Panel panel7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton15;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton16;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton17;
        private DataGridViewTextBoxColumn LocationID;
        private DataGridViewTextBoxColumn LocationName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Camera1;
        private DataGridViewTextBoxColumn Camera2;
        private DataGridViewTextBoxColumn PumpID;
        private DataGridViewTextBoxColumn ControllerEtagID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Button btnRefresh;
        private PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPing;
        private GroupBox groupBox2;
        private TextBox txtLprServer;
        private Label label6;
        private DataGridViewTextBoxColumn IDStation;
        private DataGridViewTextBoxColumn AgasStationID;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn PCIDD;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GroupBox groupBox3;
        private TextBox txbTimeRepeatRefuel;
        private Label label7;
        private GroupBox groupBox7;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbbComparePlate;
        private Label label8;
        private Label label9;
    }
}