namespace PETROLIMEX.Forms
{
    partial class frmReportVehiceRegisted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportVehiceRegisted));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbvehicleType = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbbType = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txbPlate = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnExcel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnTimKiem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dgvVehicleRegisted = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAgasPumpPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePumping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAgasPutdown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgPathPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgPathPumping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgPathPutdown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picNhacCo = new System.Windows.Forms.PictureBox();
            this.picBopCo = new System.Windows.Forms.PictureBox();
            this.picGacCo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRegisted)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhacCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBopCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGacCo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbvehicleType);
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.txbPlate);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 73);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(136, 44);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(146, 23);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(136, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(146, 23);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Value = new System.DateTime(2023, 5, 20, 10, 10, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(915, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biển số";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(429, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trạng thái thanh toán";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(664, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trạng thái xe";
            // 
            // cbbvehicleType
            // 
            this.cbbvehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbvehicleType.BackColor = System.Drawing.Color.Transparent;
            this.cbbvehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbvehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbvehicleType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbvehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbvehicleType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbbvehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbvehicleType.ItemHeight = 30;
            this.cbbvehicleType.Location = new System.Drawing.Point(664, 23);
            this.cbbvehicleType.Name = "cbbvehicleType";
            this.cbbvehicleType.Size = new System.Drawing.Size(220, 36);
            this.cbbvehicleType.TabIndex = 2;
            this.cbbvehicleType.SelectedIndexChanged += new System.EventHandler(this.cbbvehicleType_SelectedIndexChanged);
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.BackColor = System.Drawing.Color.Transparent;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbType.ItemHeight = 30;
            this.cbbType.Location = new System.Drawing.Point(429, 23);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(220, 36);
            this.cbbType.TabIndex = 2;
            // 
            // txbPlate
            // 
            this.txbPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPlate.DefaultText = "";
            this.txbPlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPlate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPlate.Location = new System.Drawing.Point(915, 23);
            this.txbPlate.Name = "txbPlate";
            this.txbPlate.PasswordChar = '\0';
            this.txbPlate.PlaceholderText = "";
            this.txbPlate.SelectedText = "";
            this.txbPlate.Size = new System.Drawing.Size(233, 36);
            this.txbPlate.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.BorderRadius = 5;
            this.btnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcel.FillColor = System.Drawing.Color.SlateGray;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(12, 23);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(94, 36);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.SlateGray;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1178, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 36);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvVehicleRegisted
            // 
            this.dgvVehicleRegisted.AllowUserToAddRows = false;
            this.dgvVehicleRegisted.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVehicleRegisted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicleRegisted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicleRegisted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicleRegisted.ColumnHeadersHeight = 62;
            this.dgvVehicleRegisted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehicleRegisted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CreateDate,
            this.StationID,
            this.PumpID,
            this.TimeAgasPumpPickup,
            this.TimePumping,
            this.TimeAgasPutdown,
            this.Etag,
            this.PlateNumber,
            this.Price,
            this.Volume,
            this.Amount,
            this.StatusPayment,
            this.ImgPathPickup,
            this.ImgPathPumping,
            this.ImgPathPutdown});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicleRegisted.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicleRegisted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleRegisted.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVehicleRegisted.Location = new System.Drawing.Point(0, 294);
            this.dgvVehicleRegisted.Name = "dgvVehicleRegisted";
            this.dgvVehicleRegisted.ReadOnly = true;
            this.dgvVehicleRegisted.RowHeadersVisible = false;
            this.dgvVehicleRegisted.RowTemplate.Height = 25;
            this.dgvVehicleRegisted.Size = new System.Drawing.Size(1336, 383);
            this.dgvVehicleRegisted.TabIndex = 0;
            this.dgvVehicleRegisted.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicleRegisted.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVehicleRegisted.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVehicleRegisted.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVehicleRegisted.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVehicleRegisted.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicleRegisted.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehicleRegisted.ThemeStyle.HeaderStyle.Height = 62;
            this.dgvVehicleRegisted.ThemeStyle.ReadOnly = true;
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.Height = 25;
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVehicleRegisted.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVehicleRegisted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleRegisted_CellClick);
            this.dgvVehicleRegisted.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvVehicleRegisted_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Thời gian";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 150;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "StationID";
            this.StationID.HeaderText = "ID Trạm xăng ";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            this.StationID.Width = 93;
            // 
            // PumpID
            // 
            this.PumpID.DataPropertyName = "PumpID";
            this.PumpID.HeaderText = "ID Vòi Bơm";
            this.PumpID.Name = "PumpID";
            this.PumpID.ReadOnly = true;
            this.PumpID.Width = 93;
            // 
            // TimeAgasPumpPickup
            // 
            this.TimeAgasPumpPickup.DataPropertyName = "TimeAgasPumpPickup";
            this.TimeAgasPumpPickup.HeaderText = "Thời điểm nhấc cò";
            this.TimeAgasPumpPickup.Name = "TimeAgasPumpPickup";
            this.TimeAgasPumpPickup.ReadOnly = true;
            this.TimeAgasPumpPickup.Width = 120;
            // 
            // TimePumping
            // 
            this.TimePumping.DataPropertyName = "TimePumping";
            this.TimePumping.HeaderText = "Thời điểm bơm xăng";
            this.TimePumping.Name = "TimePumping";
            this.TimePumping.ReadOnly = true;
            this.TimePumping.Width = 120;
            // 
            // TimeAgasPutdown
            // 
            this.TimeAgasPutdown.DataPropertyName = "TimeAgasPutdown";
            this.TimeAgasPutdown.HeaderText = "Thời điểm gác cò";
            this.TimeAgasPutdown.Name = "TimeAgasPutdown";
            this.TimeAgasPutdown.ReadOnly = true;
            this.TimeAgasPutdown.Width = 120;
            // 
            // Etag
            // 
            this.Etag.DataPropertyName = "Etag";
            this.Etag.HeaderText = "Mã Etag";
            this.Etag.Name = "Etag";
            this.Etag.ReadOnly = true;
            this.Etag.Width = 93;
            // 
            // PlateNumber
            // 
            this.PlateNumber.DataPropertyName = "PlateNumber";
            this.PlateNumber.HeaderText = "Biển số";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.Width = 93;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 93;
            // 
            // Volume
            // 
            this.Volume.DataPropertyName = "Volume";
            this.Volume.HeaderText = "Khối lượng (lít)";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Width = 93;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Tổng tiền";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // StatusPayment
            // 
            this.StatusPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusPayment.DataPropertyName = "StatusPayment";
            this.StatusPayment.HeaderText = "Trạng thái";
            this.StatusPayment.Name = "StatusPayment";
            this.StatusPayment.ReadOnly = true;
            // 
            // ImgPathPickup
            // 
            this.ImgPathPickup.DataPropertyName = "ImgPathPickup";
            this.ImgPathPickup.HeaderText = "PathNhacCo";
            this.ImgPathPickup.Name = "ImgPathPickup";
            this.ImgPathPickup.ReadOnly = true;
            this.ImgPathPickup.Visible = false;
            // 
            // ImgPathPumping
            // 
            this.ImgPathPumping.DataPropertyName = "ImgPathPumping";
            this.ImgPathPumping.HeaderText = "PathBopCo";
            this.ImgPathPumping.Name = "ImgPathPumping";
            this.ImgPathPumping.ReadOnly = true;
            this.ImgPathPumping.Visible = false;
            // 
            // ImgPathPutdown
            // 
            this.ImgPathPutdown.DataPropertyName = "ImgPathPutdown";
            this.ImgPathPutdown.HeaderText = "PathGacCo";
            this.ImgPathPutdown.Name = "ImgPathPutdown";
            this.ImgPathPutdown.ReadOnly = true;
            this.ImgPathPutdown.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.picNhacCo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBopCo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picGacCo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1336, 216);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // picNhacCo
            // 
            this.picNhacCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNhacCo.Location = new System.Drawing.Point(3, 3);
            this.picNhacCo.Name = "picNhacCo";
            this.picNhacCo.Size = new System.Drawing.Size(439, 190);
            this.picNhacCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhacCo.TabIndex = 0;
            this.picNhacCo.TabStop = false;
            // 
            // picBopCo
            // 
            this.picBopCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBopCo.Location = new System.Drawing.Point(448, 3);
            this.picBopCo.Name = "picBopCo";
            this.picBopCo.Size = new System.Drawing.Size(439, 190);
            this.picBopCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBopCo.TabIndex = 1;
            this.picBopCo.TabStop = false;
            // 
            // picGacCo
            // 
            this.picGacCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGacCo.Location = new System.Drawing.Point(893, 3);
            this.picGacCo.Name = "picGacCo";
            this.picGacCo.Size = new System.Drawing.Size(440, 190);
            this.picGacCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGacCo.TabIndex = 2;
            this.picGacCo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời điểm nhấc vòi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(448, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời điểm đang bơm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(893, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời điểm gác vòi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 289);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1336, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // frmReportVehiceRegisted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 677);
            this.Controls.Add(this.dgvVehicleRegisted);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportVehiceRegisted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo xe vào đổ xăng ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportVehiceRegisted_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRegisted)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhacCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBopCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGacCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txbPlate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnExcel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTimKiem;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvVehicleRegisted;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbbType;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbbvehicleType;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picNhacCo;
        private Splitter splitter1;
        private PictureBox picBopCo;
        private PictureBox picGacCo;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn StationID;
        private DataGridViewTextBoxColumn PumpID;
        private DataGridViewTextBoxColumn TimeAgasPumpPickup;
        private DataGridViewTextBoxColumn TimePumping;
        private DataGridViewTextBoxColumn TimeAgasPutdown;
        private DataGridViewTextBoxColumn Etag;
        private DataGridViewTextBoxColumn PlateNumber;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn StatusPayment;
        private DataGridViewTextBoxColumn ImgPathPickup;
        private DataGridViewTextBoxColumn ImgPathPumping;
        private DataGridViewTextBoxColumn ImgPathPutdown;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
    }
}