using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETROLIMEX.Forms
{
    public partial class frmFakeEtag : Form
    {
        public string Etag { get; set; } = string.Empty;
        public frmFakeEtag()
        {
            InitializeComponent();
        }

        private void btnAddEtag_Click(object sender, EventArgs e)
        {
            Etag = txbAddEtag.Text;

            this.DialogResult =  DialogResult.OK;
            this.Close();
        }
    }
}
