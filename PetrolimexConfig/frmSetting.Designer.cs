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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbCreateInvoicePort = new System.Windows.Forms.TextBox();
            this.txbCreateInvoiceHost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbTimeClearList = new System.Windows.Forms.TextBox();
            this.txbTimeDelayDetect = new System.Windows.Forms.TextBox();
            this.txbCountDetect = new System.Windows.Forms.TextBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
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
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(565, 299);
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
            this.groupBox2.Size = new System.Drawing.Size(565, 299);
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
            this.btnSave.Location = new System.Drawing.Point(564, 5);
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
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabPage4);
            this.siticoneTabControl1.Controls.Add(this.tabPage5);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(759, 313);
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
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 4;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Camera Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(571, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Controller Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(571, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "API";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(571, 305);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Other";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "PLX Stationid";
            // 
            // txbTimeClearList
            // 
            this.txbTimeClearList.Location = new System.Drawing.Point(147, 33);
            this.txbTimeClearList.Name = "txbTimeClearList";
            this.txbTimeClearList.Size = new System.Drawing.Size(100, 23);
            this.txbTimeClearList.TabIndex = 0;
            // 
            // txbTimeDelayDetect
            // 
            this.txbTimeDelayDetect.Location = new System.Drawing.Point(131, 59);
            this.txbTimeDelayDetect.Name = "txbTimeDelayDetect";
            this.txbTimeDelayDetect.Size = new System.Drawing.Size(100, 23);
            this.txbTimeDelayDetect.TabIndex = 0;
            // 
            // txbCountDetect
            // 
            this.txbCountDetect.Location = new System.Drawing.Point(131, 22);
            this.txbCountDetect.Name = "txbCountDetect";
            this.txbCountDetect.Size = new System.Drawing.Size(100, 23);
            this.txbCountDetect.TabIndex = 0;
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(119, 56);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(100, 23);
            this.txtStationName.TabIndex = 0;
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(119, 27);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(100, 23);
            this.txtStationID.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.siticoneTabControl1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(759, 313);
            this.pnlBody.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 36);
            this.panel2.TabIndex = 6;
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
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 313);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel pnlBody;
        private Panel panel2;
        private TabPage tabPage5;
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
    }
}