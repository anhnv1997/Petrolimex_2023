namespace PETROLIMEX.Forms
{
    partial class frmFakeEtag
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
            this.txbAddEtag = new System.Windows.Forms.TextBox();
            this.btnAddEtag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAddEtag
            // 
            this.txbAddEtag.Location = new System.Drawing.Point(64, 38);
            this.txbAddEtag.Name = "txbAddEtag";
            this.txbAddEtag.Size = new System.Drawing.Size(188, 23);
            this.txbAddEtag.TabIndex = 0;
            this.txbAddEtag.Text = "3416214B880E700001941070";
            // 
            // btnAddEtag
            // 
            this.btnAddEtag.Location = new System.Drawing.Point(119, 77);
            this.btnAddEtag.Name = "btnAddEtag";
            this.btnAddEtag.Size = new System.Drawing.Size(75, 23);
            this.btnAddEtag.TabIndex = 1;
            this.btnAddEtag.Text = "Thêm Etag";
            this.btnAddEtag.UseVisualStyleBackColor = true;
            this.btnAddEtag.Click += new System.EventHandler(this.btnAddEtag_Click);
            // 
            // frmFakeEtag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 143);
            this.Controls.Add(this.btnAddEtag);
            this.Controls.Add(this.txbAddEtag);
            this.Name = "frmFakeEtag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFakeEtag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbAddEtag;
        private Button btnAddEtag;
    }
}