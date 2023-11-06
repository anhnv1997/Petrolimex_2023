namespace iPGSTools.Usercontrols
{
    partial class ucCameraView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCameraName = new Label();
            panelCameraView = new Panel();
            SuspendLayout();
            // 
            // lblCameraName
            // 
            lblCameraName.AutoSize = true;
            lblCameraName.Dock = DockStyle.Top;
            lblCameraName.Location = new Point(1, 5);
            lblCameraName.Name = "lblCameraName";
            lblCameraName.Size = new Size(50, 20);
            lblCameraName.TabIndex = 0;
            lblCameraName.Text = "label1";
            // 
            // panelCameraView
            // 
            panelCameraView.BorderStyle = BorderStyle.FixedSingle;
            panelCameraView.Dock = DockStyle.Fill;
            panelCameraView.Location = new Point(1, 25);
            panelCameraView.Name = "panelCameraView";
            panelCameraView.Size = new Size(595, 337);
            panelCameraView.TabIndex = 1;
            // 
            // ucCameraView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelCameraView);
            Controls.Add(lblCameraName);
            Name = "ucCameraView";
            Padding = new Padding(1, 5, 1, 1);
            Size = new Size(597, 363);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCameraName;
        private Panel panelCameraView;
    }
}
