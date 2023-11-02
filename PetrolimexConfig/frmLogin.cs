using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetrolimexConfig
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbPass.Text == "Kztek123456")
            {
                frmSetting frm = new frmSetting();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                txbPass.Text = "";
            }
        }

       
        
    }
}