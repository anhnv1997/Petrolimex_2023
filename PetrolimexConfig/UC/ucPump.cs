using PetrolimexTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolimexConfig.UC
{
    public partial class ucPump : UserControl
    {
        public ucPump()
        {
            InitializeComponent();
        }

        private void ucPump_Load(object sender, EventArgs e)
        {
            string cmd = $"select * from tblPC";
            DataTable dt = StaticPool.mdb.FillData(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbPCname.Items.Add(dr["ComputerName"]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmd = $"insert into tblPump values ('{Guid.NewGuid()}', '{txbPumpID.Text}', (select PCID from tblPC where ComputerName = '{cbbPCname.Text}'), '{txbDescription.Text}', '{(bool)(ckbIsActive.Checked)}')";

            if (!StaticPool.mdb.ExecuteCommand(cmd))
            {
                MessageBox.Show("Lỗi");

            }
            else
            {
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }
    }
}
