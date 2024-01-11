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
    public partial class ucLocation : UserControl
    {
        public ucLocation()
        {
            InitializeComponent();
        }
        private void ucLocation_Load(object sender, EventArgs e)
        {
            ckbIsActive.Checked = true;

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
            StringBuilder sb = new StringBuilder();
            sb.Append($"insert into tblLocation ");
            sb.Append($"values ('{Guid.NewGuid()}','{txbLocationName.Text}', ");
            sb.Append($"(select PCID from tblPC where ComputerName = '{cbbPCname.Text}'), ");
            sb.Append($"(select CameraID from tblCamera where CameraName = '{txbCamera1.Text}'), ");
            sb.Append($"'', '{txbPumpID.Text}', (select ID from tblController where Name = '{txbController.Text}'), '{txbDescription.Text}', '{(bool)ckbIsActive.Checked}')");

            if (!StaticPool.mdb.ExecuteCommand(sb.ToString()))
            {
                MessageBox.Show("Lỗi");

            }
            else
            {
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }

        private void cbbPCname_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbController.Items.Clear();
            string cmd = $"select name, tblPC.ComputerName  from tblController inner join tblPC on tblController.PCID = tblPC.PCID where tblPC.ComputerName = '{cbbPCname.Text}' ";
            DataTable dt = StaticPool.mdb.FillData(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                    txbController.Items.Add(dr["Name"]);
                }
            }

            txbCamera1.Items.Clear();
            string cmd2 = $"select tblCamera.CameraName, tblPC.ComputerName  from tblCamera inner join tblPC on tblCamera.PCID = tblPC.PCID where tblPC.ComputerName = '{cbbPCname.Text}'";
            DataTable dt2 = StaticPool.mdb.FillData(cmd2);

            if (dt2 != null && dt2.Rows.Count > 0)
            {

                foreach (DataRow dr in dt2.Rows)
                {
                    txbCamera1.Items.Add(dr["CameraName"]);
                }
            }
        }

        private void txbCamera2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbCamera1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbController_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbLocationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txbPumpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
