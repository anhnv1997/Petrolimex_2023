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
    public partial class ucStation : UserControl
    {
        public string ID = "";
        public bool isModify = false;
        public ucStation()
        {
            InitializeComponent();
        }
        public ucStation(string id = "", bool isModify = false)
        {
            InitializeComponent();
            this.isModify = isModify;
            this.ID = id;
            lblTitle.Text = "Sửa Station";

            string cmd = $"Select *, tblPC.ComputerName from tblStation inner join tblPC on tblStation.PCID = tblPC.PCID where ID = '{id}' ";
            DataTable dt = StaticPool.mdb.FillData(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                txbStationID.Text = dt.Rows[0]["AgasStationID"].ToString();
                txbStationName.Text = dt.Rows[0]["StationName"].ToString();
                cbbPCname.Text = dt.Rows[0]["ComputerName"].ToString();
                txbDescription.Text = dt.Rows[0]["Description"].ToString();
            }
        }

        private void ucStation_Load(object sender, EventArgs e)
        {
            string cmd = $"select * from tblPC";
            DataTable dt = StaticPool.mdb.FillData(cmd);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbPCname.Items.Add(dr["ComputerName"]);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tim = $"select PCID from tblPC where ComputerName = '{cbbPCname.Text}'";
            DataTable dt = StaticPool.mdb.FillData(tim);

            if(dt != null && dt.Rows.Count > 0)
            {
                string PCID = dt.Rows[0]["PCID"].ToString();
                string cmd = $"Insert into tblStation values ('{Guid.NewGuid()}', '{txbStationID.Text}', '{txbStationName.Text}', '{PCID}', '{txbDescription.Text}')";
                if (!StaticPool.mdb.ExecuteCommand(cmd))
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    MessageBox.Show("Thành công!","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
