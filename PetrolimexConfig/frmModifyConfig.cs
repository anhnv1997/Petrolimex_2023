using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolimexConfig
{
    public partial class frmModifyConfig : Form
    {
        public frmModifyConfig(UserControl uc)
        {
            InitializeComponent();

            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void frmUserConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
