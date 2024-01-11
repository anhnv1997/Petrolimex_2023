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
    public partial class ucController : UserControl
    {
        public ucController()
        {
            InitializeComponent();
        }

        private void ucController_Load(object sender, EventArgs e)
        {
            cbbCommunicationType.Items.Add("0");
            cbbCommunicationType.Items.Add("1");

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
            sb.Append($"insert into tblController ");
            sb.Append($"values ('{Guid.NewGuid()}','{txbControllerName.Text}', '{txbCode.Text}', '{txbDescription.Text}', '{txbComport.Text}', ");
            sb.Append($"'{txbBaudrate.Text}', '{cbbCommunicationType.Text}', ");
            sb.Append($"(select PCID from tblPC where ComputerName = '{cbbPCname.Text}'), '{txbType.Text}') ");

            if (!StaticPool.mdb.ExecuteCommand(sb.ToString()))
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
