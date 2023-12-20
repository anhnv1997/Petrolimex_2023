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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAuthMode = new System.Windows.Forms.ComboBox();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtSqlServerName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCameraDetectType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLprServer = new System.Windows.Forms.TextBox();
            this.txtCameraPassword = new System.Windows.Forms.TextBox();
            this.txtCameraUsername = new System.Windows.Forms.TextBox();
            this.numCameraPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCameraIp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numControllerPort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtControllerIp = new System.Windows.Forms.TextBox();
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
            this.tabCameraC = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabAPIConfig = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbCreateInvoicePort = new System.Windows.Forms.TextBox();
            this.txbCreateInvoiceHost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txbCountDetect = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txbTimeDelayDetect = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txbTimeClearList = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.siticoneTabControl2 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPC = new System.Windows.Forms.TabPage();
            this.tabStation = new System.Windows.Forms.TabPage();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.tabController = new System.Windows.Forms.TabPage();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.tabPump = new System.Windows.Forms.TabPage();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneTextBox5 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneTextBox6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.siticoneTextBox7 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.siticoneTextBox8 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.siticoneTextBox9 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.siticoneTextBox10 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.siticoneTextBox11 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.siticoneTextBox12 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.siticoneTextBox13 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCameraPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControllerPort)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numApiPort)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.siticoneTabControl1.SuspendLayout();
            this.tabConnectionConfig.SuspendLayout();
            this.tabCameraC.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabAPIConfig.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.siticoneTabControl2.SuspendLayout();
            this.tabPC.SuspendLayout();
            this.tabStation.SuspendLayout();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Auth Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(690, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Connection";
            // 
            // cbAuthMode
            // 
            this.cbAuthMode.FormattingEnabled = true;
            this.cbAuthMode.Items.AddRange(new object[] {
            "SQL Auth",
            "Window Auth"});
            this.cbAuthMode.Location = new System.Drawing.Point(138, 96);
            this.cbAuthMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAuthMode.Name = "cbAuthMode";
            this.cbAuthMode.Size = new System.Drawing.Size(266, 23);
            this.cbAuthMode.TabIndex = 3;
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(138, 147);
            this.txtSqlPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(266, 23);
            this.txtSqlPassword.TabIndex = 5;
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Location = new System.Drawing.Point(138, 122);
            this.txtSqlUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(266, 23);
            this.txtSqlUsername.TabIndex = 4;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(138, 72);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(266, 23);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // txtSqlServerName
            // 
            this.txtSqlServerName.Location = new System.Drawing.Point(138, 47);
            this.txtSqlServerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlServerName.Name = "txtSqlServerName";
            this.txtSqlServerName.Size = new System.Drawing.Size(266, 23);
            this.txtSqlServerName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCameraDetectType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLprServer);
            this.groupBox2.Controls.Add(this.txtCameraPassword);
            this.groupBox2.Controls.Add(this.txtCameraUsername);
            this.groupBox2.Controls.Add(this.numCameraPort);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCameraIp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(690, 439);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera";
            // 
            // cbCameraDetectType
            // 
            this.cbCameraDetectType.FormattingEnabled = true;
            this.cbCameraDetectType.Items.AddRange(new object[] {
            "Docker",
            "FutechSDK"});
            this.cbCameraDetectType.Location = new System.Drawing.Point(173, 131);
            this.cbCameraDetectType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCameraDetectType.Name = "cbCameraDetectType";
            this.cbCameraDetectType.Size = new System.Drawing.Size(211, 23);
            this.cbCameraDetectType.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Server";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Loại nhận dạng";
            // 
            // txtLprServer
            // 
            this.txtLprServer.Location = new System.Drawing.Point(173, 157);
            this.txtLprServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLprServer.Name = "txtLprServer";
            this.txtLprServer.Size = new System.Drawing.Size(210, 23);
            this.txtLprServer.TabIndex = 6;
            // 
            // txtCameraPassword
            // 
            this.txtCameraPassword.Location = new System.Drawing.Point(173, 104);
            this.txtCameraPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCameraPassword.Name = "txtCameraPassword";
            this.txtCameraPassword.Size = new System.Drawing.Size(210, 23);
            this.txtCameraPassword.TabIndex = 4;
            this.txtCameraPassword.UseSystemPasswordChar = true;
            // 
            // txtCameraUsername
            // 
            this.txtCameraUsername.Location = new System.Drawing.Point(173, 79);
            this.txtCameraUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCameraUsername.Name = "txtCameraUsername";
            this.txtCameraUsername.Size = new System.Drawing.Size(210, 23);
            this.txtCameraUsername.TabIndex = 3;
            // 
            // numCameraPort
            // 
            this.numCameraPort.Location = new System.Drawing.Point(173, 55);
            this.numCameraPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCameraPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCameraPort.Name = "numCameraPort";
            this.numCameraPort.Size = new System.Drawing.Size(209, 23);
            this.numCameraPort.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "IP";
            // 
            // txtCameraIp
            // 
            this.txtCameraIp.Location = new System.Drawing.Point(173, 30);
            this.txtCameraIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCameraIp.Name = "txtCameraIp";
            this.txtCameraIp.Size = new System.Drawing.Size(210, 23);
            this.txtCameraIp.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numControllerPort);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtControllerIp);
            this.groupBox3.Location = new System.Drawing.Point(62, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(360, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bộ điều khiển";
            // 
            // numControllerPort
            // 
            this.numControllerPort.Location = new System.Drawing.Point(89, 44);
            this.numControllerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numControllerPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numControllerPort.Name = "numControllerPort";
            this.numControllerPort.Size = new System.Drawing.Size(265, 23);
            this.numControllerPort.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Port";
            // 
            // txtControllerIp
            // 
            this.txtControllerIp.Location = new System.Drawing.Point(89, 20);
            this.txtControllerIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtControllerIp.Name = "txtControllerIp";
            this.txtControllerIp.Size = new System.Drawing.Size(266, 23);
            this.txtControllerIp.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(958, 5);
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
            this.siticoneTabControl1.Controls.Add(this.tabCameraC);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabAPIConfig);
            this.siticoneTabControl1.Controls.Add(this.tabSystem);
            this.siticoneTabControl1.Controls.Add(this.tabSQL);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 60);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1042, 593);
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
            // 
            // tabConnectionConfig
            // 
            this.tabConnectionConfig.Controls.Add(this.groupBox1);
            this.tabConnectionConfig.Location = new System.Drawing.Point(184, 4);
            this.tabConnectionConfig.Name = "tabConnectionConfig";
            this.tabConnectionConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionConfig.Size = new System.Drawing.Size(696, 445);
            this.tabConnectionConfig.TabIndex = 0;
            this.tabConnectionConfig.Text = "Connection Config";
            this.tabConnectionConfig.UseVisualStyleBackColor = true;
            // 
            // tabCameraC
            // 
            this.tabCameraC.Controls.Add(this.groupBox2);
            this.tabCameraC.Location = new System.Drawing.Point(184, 4);
            this.tabCameraC.Name = "tabCameraC";
            this.tabCameraC.Padding = new System.Windows.Forms.Padding(3);
            this.tabCameraC.Size = new System.Drawing.Size(696, 445);
            this.tabCameraC.TabIndex = 1;
            this.tabCameraC.Text = "Camera Config";
            this.tabCameraC.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(696, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Controller Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabAPIConfig
            // 
            this.tabAPIConfig.Controls.Add(this.groupBox4);
            this.tabAPIConfig.Controls.Add(this.groupBox6);
            this.tabAPIConfig.Controls.Add(this.groupBox5);
            this.tabAPIConfig.Location = new System.Drawing.Point(184, 4);
            this.tabAPIConfig.Name = "tabAPIConfig";
            this.tabAPIConfig.Size = new System.Drawing.Size(854, 585);
            this.tabAPIConfig.TabIndex = 3;
            this.tabAPIConfig.Text = "API";
            this.tabAPIConfig.UseVisualStyleBackColor = true;
            this.tabAPIConfig.Click += new System.EventHandler(this.tabPage4_Click);
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
            this.tabSystem.Controls.Add(this.groupBox8);
            this.tabSystem.Controls.Add(this.groupBox9);
            this.tabSystem.Controls.Add(this.groupBox7);
            this.tabSystem.Location = new System.Drawing.Point(184, 4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(854, 585);
            this.tabSystem.TabIndex = 4;
            this.tabSystem.Text = "Hệ thống";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txbCountDetect);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.txbTimeDelayDetect);
            this.groupBox8.Location = new System.Drawing.Point(281, 20);
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
            this.groupBox9.Location = new System.Drawing.Point(141, 145);
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtStationID);
            this.groupBox7.Controls.Add(this.txtStationName);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Location = new System.Drawing.Point(22, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 100);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PLX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "PLX Stationid";
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(119, 27);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(100, 23);
            this.txtStationID.TabIndex = 0;
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(119, 56);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(100, 23);
            this.txtStationName.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "PLX StationName";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.siticoneTabControl1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1042, 593);
            this.pnlBody.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 36);
            this.panel2.TabIndex = 6;
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.siticoneTabControl2);
            this.tabSQL.Location = new System.Drawing.Point(184, 4);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(854, 585);
            this.tabSQL.TabIndex = 5;
            this.tabSQL.Text = "Cấu hình thiết bị";
            this.tabSQL.UseVisualStyleBackColor = true;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(199, 40);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox1.TabIndex = 0;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Location = new System.Drawing.Point(199, 94);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox2.TabIndex = 0;
            // 
            // siticoneTextBox3
            // 
            this.siticoneTextBox3.DefaultText = "";
            this.siticoneTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.Location = new System.Drawing.Point(545, 30);
            this.siticoneTextBox3.Name = "siticoneTextBox3";
            this.siticoneTextBox3.PasswordChar = '\0';
            this.siticoneTextBox3.PlaceholderText = "";
            this.siticoneTextBox3.SelectedText = "";
            this.siticoneTextBox3.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox3.TabIndex = 0;
            // 
            // siticoneTextBox4
            // 
            this.siticoneTextBox4.DefaultText = "";
            this.siticoneTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.Location = new System.Drawing.Point(545, 86);
            this.siticoneTextBox4.Name = "siticoneTextBox4";
            this.siticoneTextBox4.PasswordChar = '\0';
            this.siticoneTextBox4.PlaceholderText = "";
            this.siticoneTextBox4.SelectedText = "";
            this.siticoneTextBox4.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox4.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(89, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "PC Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(113, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "PC IP";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(459, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "StationID";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(445, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 17);
            this.label28.TabIndex = 1;
            this.label28.Text = "Path Image";
            // 
            // siticoneTabControl2
            // 
            this.siticoneTabControl2.Controls.Add(this.tabPC);
            this.siticoneTabControl2.Controls.Add(this.tabStation);
            this.siticoneTabControl2.Controls.Add(this.tabLocation);
            this.siticoneTabControl2.Controls.Add(this.tabController);
            this.siticoneTabControl2.Controls.Add(this.tabCamera);
            this.siticoneTabControl2.Controls.Add(this.tabPump);
            this.siticoneTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl2.ItemSize = new System.Drawing.Size(140, 60);
            this.siticoneTabControl2.Location = new System.Drawing.Point(3, 3);
            this.siticoneTabControl2.Name = "siticoneTabControl2";
            this.siticoneTabControl2.SelectedIndex = 0;
            this.siticoneTabControl2.Size = new System.Drawing.Size(848, 579);
            this.siticoneTabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl2.TabButtonSize = new System.Drawing.Size(140, 60);
            this.siticoneTabControl2.TabIndex = 2;
            this.siticoneTabControl2.TabMenuBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.siticoneTabControl2.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPC
            // 
            this.tabPC.Controls.Add(this.siticoneDataGridView1);
            this.tabPC.Controls.Add(this.siticoneButton1);
            this.tabPC.Controls.Add(this.siticoneTextBox1);
            this.tabPC.Controls.Add(this.label29);
            this.tabPC.Controls.Add(this.label28);
            this.tabPC.Controls.Add(this.siticoneTextBox2);
            this.tabPC.Controls.Add(this.label27);
            this.tabPC.Controls.Add(this.siticoneTextBox3);
            this.tabPC.Controls.Add(this.label26);
            this.tabPC.Controls.Add(this.siticoneTextBox5);
            this.tabPC.Controls.Add(this.siticoneTextBox4);
            this.tabPC.Controls.Add(this.label25);
            this.tabPC.Location = new System.Drawing.Point(4, 64);
            this.tabPC.Name = "tabPC";
            this.tabPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPC.Size = new System.Drawing.Size(840, 511);
            this.tabPC.TabIndex = 0;
            this.tabPC.Text = "PC";
            this.tabPC.UseVisualStyleBackColor = true;
            // 
            // tabStation
            // 
            this.tabStation.Controls.Add(this.siticoneButton2);
            this.tabStation.Controls.Add(this.siticoneTextBox6);
            this.tabStation.Controls.Add(this.label30);
            this.tabStation.Controls.Add(this.siticoneTextBox7);
            this.tabStation.Controls.Add(this.label32);
            this.tabStation.Controls.Add(this.siticoneTextBox8);
            this.tabStation.Controls.Add(this.label33);
            this.tabStation.Controls.Add(this.siticoneTextBox9);
            this.tabStation.Controls.Add(this.label34);
            this.tabStation.Location = new System.Drawing.Point(4, 64);
            this.tabStation.Name = "tabStation";
            this.tabStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabStation.Size = new System.Drawing.Size(840, 511);
            this.tabStation.TabIndex = 1;
            this.tabStation.Text = "Station";
            this.tabStation.UseVisualStyleBackColor = true;
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.siticoneTextBox10);
            this.tabLocation.Controls.Add(this.label31);
            this.tabLocation.Controls.Add(this.siticoneTextBox11);
            this.tabLocation.Controls.Add(this.label35);
            this.tabLocation.Controls.Add(this.siticoneTextBox12);
            this.tabLocation.Controls.Add(this.label36);
            this.tabLocation.Controls.Add(this.siticoneTextBox13);
            this.tabLocation.Controls.Add(this.label37);
            this.tabLocation.Location = new System.Drawing.Point(4, 64);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(840, 511);
            this.tabLocation.TabIndex = 2;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // tabController
            // 
            this.tabController.Location = new System.Drawing.Point(4, 64);
            this.tabController.Name = "tabController";
            this.tabController.Size = new System.Drawing.Size(840, 511);
            this.tabController.TabIndex = 3;
            this.tabController.Text = "Controller";
            this.tabController.UseVisualStyleBackColor = true;
            // 
            // tabCamera
            // 
            this.tabCamera.Location = new System.Drawing.Point(4, 64);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Size = new System.Drawing.Size(840, 511);
            this.tabCamera.TabIndex = 4;
            this.tabCamera.Text = "Camera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // tabPump
            // 
            this.tabPump.Location = new System.Drawing.Point(4, 64);
            this.tabPump.Name = "tabPump";
            this.tabPump.Size = new System.Drawing.Size(840, 511);
            this.tabPump.TabIndex = 5;
            this.tabPump.Text = "Pump";
            this.tabPump.UseVisualStyleBackColor = true;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.Green;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(298, 161);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(101, 45);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Save";
            // 
            // siticoneTextBox5
            // 
            this.siticoneTextBox5.DefaultText = "";
            this.siticoneTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox5.Location = new System.Drawing.Point(545, 146);
            this.siticoneTextBox5.Name = "siticoneTextBox5";
            this.siticoneTextBox5.PasswordChar = '\0';
            this.siticoneTextBox5.PlaceholderText = "";
            this.siticoneTextBox5.SelectedText = "";
            this.siticoneTextBox5.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox5.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(445, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Description";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.Green;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(526, 272);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(101, 45);
            this.siticoneButton2.TabIndex = 13;
            this.siticoneButton2.Text = "Save";
            // 
            // siticoneTextBox6
            // 
            this.siticoneTextBox6.DefaultText = "";
            this.siticoneTextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox6.Location = new System.Drawing.Point(180, 27);
            this.siticoneTextBox6.Name = "siticoneTextBox6";
            this.siticoneTextBox6.PasswordChar = '\0';
            this.siticoneTextBox6.PlaceholderText = "";
            this.siticoneTextBox6.SelectedText = "";
            this.siticoneTextBox6.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox6.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(80, 207);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 17);
            this.label30.TabIndex = 8;
            this.label30.Text = "Description";
            // 
            // siticoneTextBox7
            // 
            this.siticoneTextBox7.DefaultText = "";
            this.siticoneTextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox7.Location = new System.Drawing.Point(180, 81);
            this.siticoneTextBox7.Name = "siticoneTextBox7";
            this.siticoneTextBox7.PasswordChar = '\0';
            this.siticoneTextBox7.PlaceholderText = "";
            this.siticoneTextBox7.SelectedText = "";
            this.siticoneTextBox7.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox7.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(94, 151);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 17);
            this.label32.TabIndex = 10;
            this.label32.Text = "PC Name";
            // 
            // siticoneTextBox8
            // 
            this.siticoneTextBox8.DefaultText = "";
            this.siticoneTextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox8.Location = new System.Drawing.Point(180, 142);
            this.siticoneTextBox8.Name = "siticoneTextBox8";
            this.siticoneTextBox8.PasswordChar = '\0';
            this.siticoneTextBox8.PlaceholderText = "";
            this.siticoneTextBox8.SelectedText = "";
            this.siticoneTextBox8.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox8.TabIndex = 5;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(94, 91);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 17);
            this.label33.TabIndex = 11;
            this.label33.Text = "StationID";
            // 
            // siticoneTextBox9
            // 
            this.siticoneTextBox9.DefaultText = "";
            this.siticoneTextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.Location = new System.Drawing.Point(180, 207);
            this.siticoneTextBox9.Name = "siticoneTextBox9";
            this.siticoneTextBox9.PasswordChar = '\0';
            this.siticoneTextBox9.PlaceholderText = "";
            this.siticoneTextBox9.SelectedText = "";
            this.siticoneTextBox9.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox9.TabIndex = 6;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(70, 36);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 17);
            this.label34.TabIndex = 12;
            this.label34.Text = "Station Name";
            // 
            // siticoneTextBox10
            // 
            this.siticoneTextBox10.DefaultText = "";
            this.siticoneTextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox10.Location = new System.Drawing.Point(234, 40);
            this.siticoneTextBox10.Name = "siticoneTextBox10";
            this.siticoneTextBox10.PasswordChar = '\0';
            this.siticoneTextBox10.PlaceholderText = "";
            this.siticoneTextBox10.SelectedText = "";
            this.siticoneTextBox10.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox10.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(134, 220);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 17);
            this.label31.TabIndex = 17;
            this.label31.Text = "Description";
            // 
            // siticoneTextBox11
            // 
            this.siticoneTextBox11.DefaultText = "";
            this.siticoneTextBox11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox11.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox11.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox11.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox11.Location = new System.Drawing.Point(234, 94);
            this.siticoneTextBox11.Name = "siticoneTextBox11";
            this.siticoneTextBox11.PasswordChar = '\0';
            this.siticoneTextBox11.PlaceholderText = "";
            this.siticoneTextBox11.SelectedText = "";
            this.siticoneTextBox11.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox11.TabIndex = 14;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label35.Location = new System.Drawing.Point(148, 164);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 17);
            this.label35.TabIndex = 18;
            this.label35.Text = "PC Name";
            // 
            // siticoneTextBox12
            // 
            this.siticoneTextBox12.DefaultText = "";
            this.siticoneTextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox12.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox12.Location = new System.Drawing.Point(234, 155);
            this.siticoneTextBox12.Name = "siticoneTextBox12";
            this.siticoneTextBox12.PasswordChar = '\0';
            this.siticoneTextBox12.PlaceholderText = "";
            this.siticoneTextBox12.SelectedText = "";
            this.siticoneTextBox12.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox12.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(148, 104);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(64, 17);
            this.label36.TabIndex = 19;
            this.label36.Text = "StationID";
            // 
            // siticoneTextBox13
            // 
            this.siticoneTextBox13.DefaultText = "";
            this.siticoneTextBox13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox13.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox13.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTextBox13.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox13.Location = new System.Drawing.Point(234, 220);
            this.siticoneTextBox13.Name = "siticoneTextBox13";
            this.siticoneTextBox13.PasswordChar = '\0';
            this.siticoneTextBox13.PlaceholderText = "";
            this.siticoneTextBox13.SelectedText = "";
            this.siticoneTextBox13.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox13.TabIndex = 16;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(124, 49);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 17);
            this.label37.TabIndex = 20;
            this.label37.Text = "Location name";
            // 
            // siticoneDataGridView1
            // 
            this.siticoneDataGridView1.AllowUserToAddRows = false;
            this.siticoneDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PCName,
            this.PCIP,
            this.StationID,
            this.StationName,
            this.PathImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(12, 227);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.ReadOnly = true;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowTemplate.Height = 25;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(822, 253);
            this.siticoneDataGridView1.TabIndex = 3;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = true;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PCName
            // 
            this.PCName.HeaderText = "Máy tính";
            this.PCName.Name = "PCName";
            this.PCName.ReadOnly = true;
            // 
            // PCIP
            // 
            this.PCIP.HeaderText = "IP";
            this.PCIP.Name = "PCIP";
            this.PCIP.ReadOnly = true;
            // 
            // StationID
            // 
            this.StationID.HeaderText = "StationID";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Station Name";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // PathImage
            // 
            this.PathImage.HeaderText = "Path Image";
            this.PathImage.Name = "PathImage";
            this.PathImage.ReadOnly = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCameraPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControllerPort)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numApiPort)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabConnectionConfig.ResumeLayout(false);
            this.tabCameraC.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabAPIConfig.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabSQL.ResumeLayout(false);
            this.siticoneTabControl2.ResumeLayout(false);
            this.tabPC.ResumeLayout(false);
            this.tabPC.PerformLayout();
            this.tabStation.ResumeLayout(false);
            this.tabStation.PerformLayout();
            this.tabLocation.ResumeLayout(false);
            this.tabLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
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
        private GroupBox groupBox2;
        private ComboBox cbCameraDetectType;
        private Label label10;
        private NumericUpDown numCameraPort;
        private Label label8;
        private TextBox txtCameraIp;
        private Label label6;
        private GroupBox groupBox3;
        private NumericUpDown numControllerPort;
        private Label label7;
        private Label label9;
        private TextBox txtControllerIp;
        private TextBox txtCameraPassword;
        private TextBox txtCameraUsername;
        private Label label12;
        private Label label11;
        private Button btnSave;
        private GroupBox groupBox4;
        private NumericUpDown numApiPort;
        private Label label14;
        private TextBox txtPaymentServer;
        private Label label13;
        private Label label15;
        private TextBox txtLprServer;
        private GroupBox groupBox5;
        private TextBox txtAgasUrl;
        private Label label16;
        private NumericUpDown numericUpDown1;
        private Label label17;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage tabConnectionConfig;
        private TabPage tabCameraC;
        private TabPage tabPage3;
        private TabPage tabAPIConfig;
        private Panel pnlBody;
        private Panel panel2;
        private TabPage tabSystem;
        private Label label18;
        private TextBox txtStationID;
        private Label label19;
        private TextBox txtStationName;
        private Label label20;
        private TextBox txbCountDetect;
        private Label label21;
        private TextBox txbTimeDelayDetect;
        private GroupBox groupBox6;
        private TextBox txbCreateInvoiceHost;
        private Label label22;
        private TextBox txbCreateInvoicePort;
        private Label label23;
        private GroupBox groupBox7;
        private Label label24;
        private TextBox txbTimeClearList;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private TabPage tabSQL;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl2;
        private TabPage tabPC;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Label label28;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Label label27;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox3;
        private Label label26;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox4;
        private Label label25;
        private TabPage tabStation;
        private TabPage tabLocation;
        private TabPage tabController;
        private TabPage tabCamera;
        private TabPage tabPump;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PCName;
        private DataGridViewTextBoxColumn PCIP;
        private DataGridViewTextBoxColumn StationID;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn PathImage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Label label29;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox6;
        private Label label30;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox7;
        private Label label32;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox8;
        private Label label33;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox9;
        private Label label34;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox10;
        private Label label31;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox11;
        private Label label35;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox12;
        private Label label36;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox13;
        private Label label37;
    }
}