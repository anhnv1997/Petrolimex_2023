namespace iPGSTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panelCamera = new Panel();
            menuStrip1 = new MenuStrip();
            ToolStripHeThong = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ToolStripThoat = new ToolStripMenuItem();
            ToolStripBaoCao = new ToolStripMenuItem();
            ToolStripRegisted = new ToolStripMenuItem();
            button1 = new Button();
            panel1 = new Panel();
            picEnableOpenApp = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            btnTestAPI = new Button();
            lblConnectStatus = new Label();
            pnlTop = new Panel();
            splitter2 = new Splitter();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tabEvent = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            VehiclePayment2 = new TabPage();
            dgvAutoPaymentVehicle = new DataGridView();
            STTPayment = new DataGridViewTextBoxColumn();
            DateTimePayment = new DataGridViewTextBoxColumn();
            dgvAutoPayment_plate = new DataGridViewTextBoxColumn();
            dgvAutoPayment_status = new DataGridViewTextBoxColumn();
            dgvAutoPayment_volume = new DataGridViewTextBoxColumn();
            dgvAutoPayment_amount = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            isFinishPayment = new DataGridViewCheckBoxColumn();
            Etag2 = new TabPage();
            dgvEtag = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            STTEtag = new DataGridViewTextBoxColumn();
            DateTimeEtag = new DataGridViewTextBoxColumn();
            Etag = new DataGridViewTextBoxColumn();
            PlateEtag = new DataGridViewTextBoxColumn();
            VehicleN = new TabPage();
            dgvNotRegisted = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            EtagStatus = new DataGridViewTextBoxColumn();
            Plate = new DataGridViewTextBoxColumn();
            EventError = new TabPage();
            dgvEventError = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            STTEvent = new DataGridViewTextBoxColumn();
            TimeEvent = new DataGridViewTextBoxColumn();
            NameEvent = new DataGridViewTextBoxColumn();
            EventHD = new DataGridViewTextBoxColumn();
            splitter1 = new Splitter();
            contextMenuStrip1 = new ContextMenuStrip(components);
            clearToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEnableOpenApp).BeginInit();
            pnlTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabEvent.SuspendLayout();
            VehiclePayment2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutoPaymentVehicle).BeginInit();
            Etag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtag).BeginInit();
            VehicleN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotRegisted).BeginInit();
            EventError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventError).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCamera
            // 
            panelCamera.BackColor = SystemColors.Control;
            panelCamera.Dock = DockStyle.Fill;
            panelCamera.Location = new Point(0, 30);
            panelCamera.Name = "panelCamera";
            panelCamera.Size = new Size(898, 218);
            panelCamera.TabIndex = 0;
            panelCamera.Paint += panelCamera_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripHeThong, ToolStripBaoCao });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1219, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripHeThong
            // 
            ToolStripHeThong.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem, ToolStripThoat });
            ToolStripHeThong.Image = (Image)resources.GetObject("ToolStripHeThong.Image");
            ToolStripHeThong.Name = "ToolStripHeThong";
            ToolStripHeThong.Size = new Size(99, 24);
            ToolStripHeThong.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(133, 24);
            thoátToolStripMenuItem.Text = "Phím tắt";
            // 
            // ToolStripThoat
            // 
            ToolStripThoat.Name = "ToolStripThoat";
            ToolStripThoat.Size = new Size(133, 24);
            ToolStripThoat.Text = "Thoát";
            ToolStripThoat.Click += ToolStripThoat_Click;
            // 
            // ToolStripBaoCao
            // 
            ToolStripBaoCao.DropDownItems.AddRange(new ToolStripItem[] { ToolStripRegisted });
            ToolStripBaoCao.Image = (Image)resources.GetObject("ToolStripBaoCao.Image");
            ToolStripBaoCao.Name = "ToolStripBaoCao";
            ToolStripBaoCao.Size = new Size(91, 24);
            ToolStripBaoCao.Text = "Báo cáo";
            ToolStripBaoCao.Click += ToolStripBaoCao_Click;
            // 
            // ToolStripRegisted
            // 
            ToolStripRegisted.Image = (Image)resources.GetObject("ToolStripRegisted.Image");
            ToolStripRegisted.Name = "ToolStripRegisted";
            ToolStripRegisted.Size = new Size(181, 24);
            ToolStripRegisted.Text = "Xe vào đổ xăng";
            ToolStripRegisted.Click += ToolStripRegisted_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(950, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 0;
            button1.Text = "FakeEtag";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(picEnableOpenApp);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTestAPI);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblConnectStatus);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 559);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 32);
            panel1.TabIndex = 3;
            // 
            // picEnableOpenApp
            // 
            picEnableOpenApp.Dock = DockStyle.Left;
            picEnableOpenApp.Image = (Image)resources.GetObject("picEnableOpenApp.Image");
            picEnableOpenApp.Location = new Point(75, 0);
            picEnableOpenApp.Margin = new Padding(3, 4, 3, 4);
            picEnableOpenApp.Name = "picEnableOpenApp";
            picEnableOpenApp.Size = new Size(34, 32);
            picEnableOpenApp.SizeMode = PictureBoxSizeMode.Zoom;
            picEnableOpenApp.TabIndex = 3;
            picEnableOpenApp.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(1045, -1);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "Test Detect";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1137, 5);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Version 2.2.8";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTestAPI
            // 
            btnTestAPI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTestAPI.Location = new Point(851, 0);
            btnTestAPI.Margin = new Padding(3, 4, 3, 4);
            btnTestAPI.Name = "btnTestAPI";
            btnTestAPI.Size = new Size(91, 29);
            btnTestAPI.TabIndex = 0;
            btnTestAPI.Text = "TestAPI";
            btnTestAPI.UseVisualStyleBackColor = true;
            btnTestAPI.Visible = false;
            btnTestAPI.Click += btnTestAPI_Click;
            // 
            // lblConnectStatus
            // 
            lblConnectStatus.Dock = DockStyle.Left;
            lblConnectStatus.Location = new Point(0, 0);
            lblConnectStatus.Name = "lblConnectStatus";
            lblConnectStatus.Size = new Size(75, 32);
            lblConnectStatus.TabIndex = 0;
            lblConnectStatus.Text = "Disconnect";
            lblConnectStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(panelCamera);
            pnlTop.Controls.Add(splitter2);
            pnlTop.Controls.Add(panel2);
            pnlTop.Controls.Add(menuStrip1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1219, 248);
            pnlTop.TabIndex = 5;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(898, 30);
            splitter2.Margin = new Padding(3, 4, 3, 4);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(6, 218);
            splitter2.TabIndex = 3;
            splitter2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(904, 30);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 0, 0, 0);
            panel2.Size = new Size(315, 218);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabEvent
            // 
            tabEvent.Controls.Add(VehiclePayment2);
            tabEvent.Controls.Add(Etag2);
            tabEvent.Controls.Add(VehicleN);
            tabEvent.Controls.Add(EventError);
            tabEvent.Dock = DockStyle.Fill;
            tabEvent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabEvent.ItemSize = new Size(190, 40);
            tabEvent.Location = new Point(0, 255);
            tabEvent.Margin = new Padding(3, 4, 3, 4);
            tabEvent.Name = "tabEvent";
            tabEvent.SelectedIndex = 0;
            tabEvent.Size = new Size(1219, 304);
            tabEvent.TabButtonHoverState.BorderColor = Color.Empty;
            tabEvent.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tabEvent.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabEvent.TabButtonHoverState.ForeColor = Color.White;
            tabEvent.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabEvent.TabButtonIdleState.BorderColor = Color.Empty;
            tabEvent.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tabEvent.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabEvent.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tabEvent.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabEvent.TabButtonSelectedState.BorderColor = Color.Empty;
            tabEvent.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tabEvent.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabEvent.TabButtonSelectedState.ForeColor = Color.White;
            tabEvent.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabEvent.TabButtonSize = new Size(190, 40);
            tabEvent.TabIndex = 4;
            tabEvent.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            tabEvent.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // VehiclePayment2
            // 
            VehiclePayment2.Controls.Add(dgvAutoPaymentVehicle);
            VehiclePayment2.Location = new Point(4, 44);
            VehiclePayment2.Margin = new Padding(3, 4, 3, 4);
            VehiclePayment2.Name = "VehiclePayment2";
            VehiclePayment2.Padding = new Padding(3, 4, 3, 4);
            VehiclePayment2.Size = new Size(1211, 256);
            VehiclePayment2.TabIndex = 0;
            VehiclePayment2.Text = "Xe chờ thanh toán";
            VehiclePayment2.UseVisualStyleBackColor = true;
            // 
            // dgvAutoPaymentVehicle
            // 
            dgvAutoPaymentVehicle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dgvAutoPaymentVehicle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAutoPaymentVehicle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAutoPaymentVehicle.BackgroundColor = Color.White;
            dgvAutoPaymentVehicle.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAutoPaymentVehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAutoPaymentVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutoPaymentVehicle.Columns.AddRange(new DataGridViewColumn[] { STTPayment, DateTimePayment, dgvAutoPayment_plate, dgvAutoPayment_status, dgvAutoPayment_volume, dgvAutoPayment_amount, Payment, isFinishPayment });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAutoPaymentVehicle.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAutoPaymentVehicle.Dock = DockStyle.Fill;
            dgvAutoPaymentVehicle.Location = new Point(3, 4);
            dgvAutoPaymentVehicle.Name = "dgvAutoPaymentVehicle";
            dgvAutoPaymentVehicle.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAutoPaymentVehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAutoPaymentVehicle.RowHeadersVisible = false;
            dgvAutoPaymentVehicle.RowHeadersWidth = 60;
            dgvAutoPaymentVehicle.RowTemplate.Height = 29;
            dgvAutoPaymentVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutoPaymentVehicle.Size = new Size(1205, 248);
            dgvAutoPaymentVehicle.TabIndex = 0;
            // 
            // STTPayment
            // 
            STTPayment.HeaderText = "STT";
            STTPayment.Name = "STTPayment";
            STTPayment.ReadOnly = true;
            STTPayment.Width = 50;
            // 
            // DateTimePayment
            // 
            DateTimePayment.HeaderText = "Giờ Vào";
            DateTimePayment.Name = "DateTimePayment";
            DateTimePayment.ReadOnly = true;
            DateTimePayment.Width = 150;
            // 
            // dgvAutoPayment_plate
            // 
            dgvAutoPayment_plate.HeaderText = "Biển số xe";
            dgvAutoPayment_plate.Name = "dgvAutoPayment_plate";
            dgvAutoPayment_plate.ReadOnly = true;
            dgvAutoPayment_plate.Width = 150;
            // 
            // dgvAutoPayment_status
            // 
            dgvAutoPayment_status.HeaderText = "Trạng Thái";
            dgvAutoPayment_status.Name = "dgvAutoPayment_status";
            dgvAutoPayment_status.ReadOnly = true;
            dgvAutoPayment_status.Width = 200;
            // 
            // dgvAutoPayment_volume
            // 
            dgvAutoPayment_volume.HeaderText = "Khối lượng (lít)";
            dgvAutoPayment_volume.Name = "dgvAutoPayment_volume";
            dgvAutoPayment_volume.ReadOnly = true;
            dgvAutoPayment_volume.Width = 150;
            // 
            // dgvAutoPayment_amount
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAutoPayment_amount.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAutoPayment_amount.HeaderText = "Thành Tiền";
            dgvAutoPayment_amount.Name = "dgvAutoPayment_amount";
            dgvAutoPayment_amount.ReadOnly = true;
            dgvAutoPayment_amount.Width = 150;
            // 
            // Payment
            // 
            Payment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Payment.HeaderText = "Thanh toán";
            Payment.Name = "Payment";
            Payment.ReadOnly = true;
            // 
            // isFinishPayment
            // 
            isFinishPayment.FalseValue = "";
            isFinishPayment.HeaderText = "Hoàn thành";
            isFinishPayment.Name = "isFinishPayment";
            isFinishPayment.ReadOnly = true;
            isFinishPayment.Resizable = DataGridViewTriState.True;
            isFinishPayment.SortMode = DataGridViewColumnSortMode.Automatic;
            isFinishPayment.TrueValue = "";
            isFinishPayment.Width = 120;
            // 
            // Etag2
            // 
            Etag2.Controls.Add(dgvEtag);
            Etag2.Location = new Point(4, 44);
            Etag2.Margin = new Padding(3, 4, 3, 4);
            Etag2.Name = "Etag2";
            Etag2.Padding = new Padding(3, 4, 3, 4);
            Etag2.Size = new Size(1211, 256);
            Etag2.TabIndex = 1;
            Etag2.Text = "Xe đã đăng ký dịch vụ";
            Etag2.UseVisualStyleBackColor = true;
            // 
            // dgvEtag
            // 
            dgvEtag.AllowUserToAddRows = false;
            dgvEtag.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvEtag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvEtag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvEtag.BorderStyle = BorderStyle.FixedSingle;
            dgvEtag.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEtag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvEtag.ColumnHeadersHeight = 26;
            dgvEtag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEtag.Columns.AddRange(new DataGridViewColumn[] { STTEtag, DateTimeEtag, Etag, PlateEtag });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvEtag.DefaultCellStyle = dataGridViewCellStyle8;
            dgvEtag.Dock = DockStyle.Fill;
            dgvEtag.Location = new Point(3, 4);
            dgvEtag.Margin = new Padding(3, 4, 3, 4);
            dgvEtag.Name = "dgvEtag";
            dgvEtag.ReadOnly = true;
            dgvEtag.RowHeadersVisible = false;
            dgvEtag.RowTemplate.Height = 25;
            dgvEtag.Size = new Size(1205, 248);
            dgvEtag.TabIndex = 3;
            dgvEtag.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEtag.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEtag.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEtag.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEtag.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEtag.ThemeStyle.BackColor = Color.White;
            dgvEtag.ThemeStyle.GridColor = SystemColors.ControlDark;
            dgvEtag.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEtag.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvEtag.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEtag.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEtag.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEtag.ThemeStyle.HeaderStyle.Height = 26;
            dgvEtag.ThemeStyle.ReadOnly = true;
            dgvEtag.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEtag.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEtag.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEtag.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEtag.ThemeStyle.RowsStyle.Height = 25;
            dgvEtag.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEtag.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // STTEtag
            // 
            STTEtag.FillWeight = 121.8274F;
            STTEtag.HeaderText = "STT";
            STTEtag.Name = "STTEtag";
            STTEtag.ReadOnly = true;
            STTEtag.Width = 60;
            // 
            // DateTimeEtag
            // 
            DateTimeEtag.FillWeight = 92.72421F;
            DateTimeEtag.HeaderText = "Thời gian";
            DateTimeEtag.Name = "DateTimeEtag";
            DateTimeEtag.ReadOnly = true;
            DateTimeEtag.Width = 300;
            // 
            // Etag
            // 
            Etag.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Etag.FillWeight = 92.72421F;
            Etag.HeaderText = "Mã Etag";
            Etag.Name = "Etag";
            Etag.ReadOnly = true;
            // 
            // PlateEtag
            // 
            PlateEtag.FillWeight = 92.72421F;
            PlateEtag.HeaderText = "Biển số đăng ký";
            PlateEtag.Name = "PlateEtag";
            PlateEtag.ReadOnly = true;
            PlateEtag.Width = 165;
            // 
            // VehicleN
            // 
            VehicleN.Controls.Add(dgvNotRegisted);
            VehicleN.Location = new Point(4, 44);
            VehicleN.Margin = new Padding(3, 4, 3, 4);
            VehicleN.Name = "VehicleN";
            VehicleN.Size = new Size(1211, 256);
            VehicleN.TabIndex = 2;
            VehicleN.Text = "        Xe chưa đăng ký dịch vụ";
            VehicleN.UseVisualStyleBackColor = true;
            // 
            // dgvNotRegisted
            // 
            dgvNotRegisted.AllowUserToAddRows = false;
            dgvNotRegisted.AllowUserToDeleteRows = false;
            dgvNotRegisted.BackgroundColor = Color.White;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvNotRegisted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvNotRegisted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotRegisted.Columns.AddRange(new DataGridViewColumn[] { STT, Time, EtagStatus, Plate });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvNotRegisted.DefaultCellStyle = dataGridViewCellStyle10;
            dgvNotRegisted.Dock = DockStyle.Fill;
            dgvNotRegisted.Location = new Point(0, 0);
            dgvNotRegisted.Margin = new Padding(3, 4, 3, 4);
            dgvNotRegisted.Name = "dgvNotRegisted";
            dgvNotRegisted.ReadOnly = true;
            dgvNotRegisted.RowHeadersVisible = false;
            dgvNotRegisted.RowTemplate.Height = 25;
            dgvNotRegisted.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotRegisted.Size = new Size(1211, 256);
            dgvNotRegisted.TabIndex = 0;
            dgvNotRegisted.CellMouseClick += dgvNotRegisted_CellMouseClick;
            dgvNotRegisted.RowsAdded += dgvNotRegisted_RowsAdded;
            dgvNotRegisted.MouseClick += dgvNotRegisted_MouseClick;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // Time
            // 
            Time.HeaderText = "Thời gian";
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 300;
            // 
            // EtagStatus
            // 
            EtagStatus.HeaderText = "Mã Etag ";
            EtagStatus.Name = "EtagStatus";
            EtagStatus.ReadOnly = true;
            EtagStatus.Width = 300;
            // 
            // Plate
            // 
            Plate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Plate.HeaderText = "Biển số";
            Plate.Name = "Plate";
            Plate.ReadOnly = true;
            // 
            // EventError
            // 
            EventError.Controls.Add(dgvEventError);
            EventError.Location = new Point(4, 44);
            EventError.Margin = new Padding(3, 4, 3, 4);
            EventError.Name = "EventError";
            EventError.Size = new Size(1211, 256);
            EventError.TabIndex = 3;
            EventError.Text = "Sự kiện lỗi";
            EventError.UseVisualStyleBackColor = true;
            // 
            // dgvEventError
            // 
            dgvEventError.AllowUserToAddRows = false;
            dgvEventError.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.White;
            dgvEventError.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvEventError.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvEventError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvEventError.ColumnHeadersHeight = 22;
            dgvEventError.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEventError.Columns.AddRange(new DataGridViewColumn[] { STTEvent, TimeEvent, NameEvent, EventHD });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvEventError.DefaultCellStyle = dataGridViewCellStyle13;
            dgvEventError.Dock = DockStyle.Fill;
            dgvEventError.GridColor = Color.FromArgb(231, 229, 255);
            dgvEventError.Location = new Point(0, 0);
            dgvEventError.Margin = new Padding(3, 4, 3, 4);
            dgvEventError.Name = "dgvEventError";
            dgvEventError.ReadOnly = true;
            dgvEventError.RowHeadersVisible = false;
            dgvEventError.RowTemplate.Height = 25;
            dgvEventError.Size = new Size(1211, 256);
            dgvEventError.TabIndex = 0;
            dgvEventError.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEventError.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEventError.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEventError.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEventError.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEventError.ThemeStyle.BackColor = Color.White;
            dgvEventError.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEventError.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEventError.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEventError.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dgvEventError.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEventError.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEventError.ThemeStyle.HeaderStyle.Height = 22;
            dgvEventError.ThemeStyle.ReadOnly = true;
            dgvEventError.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEventError.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEventError.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dgvEventError.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEventError.ThemeStyle.RowsStyle.Height = 25;
            dgvEventError.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEventError.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // STTEvent
            // 
            STTEvent.HeaderText = "STT";
            STTEvent.Name = "STTEvent";
            STTEvent.ReadOnly = true;
            // 
            // TimeEvent
            // 
            TimeEvent.HeaderText = "Thời gian";
            TimeEvent.Name = "TimeEvent";
            TimeEvent.ReadOnly = true;
            TimeEvent.Width = 265;
            // 
            // NameEvent
            // 
            NameEvent.HeaderText = "Tên sự kiện";
            NameEvent.Name = "NameEvent";
            NameEvent.ReadOnly = true;
            NameEvent.Width = 264;
            // 
            // EventHD
            // 
            EventHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventHD.HeaderText = "Trạng thái lỗi";
            EventHD.Name = "EventHD";
            EventHD.ReadOnly = true;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.Control;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 248);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1219, 7);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 28);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(112, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 591);
            Controls.Add(tabEvent);
            Controls.Add(splitter1);
            Controls.Add(pnlTop);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm theo dõi thanh toán tự động ";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEnableOpenApp).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabEvent.ResumeLayout(false);
            VehiclePayment2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAutoPaymentVehicle).EndInit();
            Etag2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEtag).EndInit();
            VehicleN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotRegisted).EndInit();
            EventError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventError).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCamera;
        private Panel panel1;
        private Label lblConnectStatus;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripBaoCao;
        private ToolStripMenuItem ToolStripRegisted;
        private Panel pnlTop;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabEvent;
        private TabPage VehiclePayment2;
        private DataGridView dgvAutoPaymentVehicle;
        private DataGridViewTextBoxColumn STTPayment;
        private DataGridViewTextBoxColumn DateTimePayment;
        private DataGridViewTextBoxColumn dgvAutoPayment_plate;
        private DataGridViewTextBoxColumn dgvAutoPayment_status;
        private DataGridViewTextBoxColumn dgvAutoPayment_volume;
        private DataGridViewTextBoxColumn dgvAutoPayment_amount;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewCheckBoxColumn isFinishPayment;
        private TabPage Etag2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvEtag;
        private TabPage VehicleN;
        private DataGridView dgvNotRegisted;
        private TabPage EventError;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvEventError;
        private DataGridViewTextBoxColumn STTEvent;
        private DataGridViewTextBoxColumn TimeEvent;
        private DataGridViewTextBoxColumn NameEvent;
        private DataGridViewTextBoxColumn EventHD;
        private Splitter splitter1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Splitter splitter2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private DataGridViewTextBoxColumn STTEtag;
        private DataGridViewTextBoxColumn DateTimeEtag;
        private DataGridViewTextBoxColumn Etag;
        private DataGridViewTextBoxColumn PlateEtag;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn EtagStatus;
        private DataGridViewTextBoxColumn Plate;
        private Label label1;
        private Button button2;
        private Button btnTestAPI;
        private ToolStripMenuItem ToolStripHeThong;
        private ToolStripMenuItem ToolStripThoat;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private PictureBox picEnableOpenApp;
        private System.Windows.Forms.Timer timer1;
    }
}