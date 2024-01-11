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
            this.lblCameraName = new System.Windows.Forms.Label();
            this.panelCameraView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCameraName
            // 
            this.lblCameraName.AutoSize = true;
            this.lblCameraName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCameraName.Location = new System.Drawing.Point(1, 4);
            this.lblCameraName.Name = "lblCameraName";
            this.lblCameraName.Size = new System.Drawing.Size(38, 15);
            this.lblCameraName.TabIndex = 0;
            this.lblCameraName.Text = "label1";
            // 
            // panelCameraView
            // 
            this.panelCameraView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCameraView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCameraView.Location = new System.Drawing.Point(1, 19);
            this.panelCameraView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCameraView.Name = "panelCameraView";
            this.panelCameraView.Size = new System.Drawing.Size(434, 299);
            this.panelCameraView.TabIndex = 1;
            // 
            // ucCameraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelCameraView);
            this.Controls.Add(this.lblCameraName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCameraView";
            this.Padding = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.Size = new System.Drawing.Size(436, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCameraName;
        private Panel panelCameraView;
    }
}
