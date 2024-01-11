using PetrolimexTools;
using PetrolimexTools.tblData;
using System.Data;

namespace PetrolimexConfig.UC
{
    public partial class ucAddPC : UserControl
    {
        public string pcID = "";
        public bool isModify = false;
        public ucAddPC()
        {
            InitializeComponent();

        }
        public ucAddPC(string id = "", bool isModify = false)
        {
            InitializeComponent();

            this.isModify = isModify;
            this.pcID = id;
            lblTitle.Text = "Sửa PC";

            string cmd = $"Select * from tblPC where PCID = '{id}'";
            DataTable dt = StaticPool.mdb.FillData(cmd);

            if(dt != null && dt.Rows.Count > 0)
            {
                txbPCName.Text = dt.Rows[0]["ComputerName"].ToString();
                txbIP.Text = dt.Rows[0]["IPAdress"].ToString();
                txbPathImage.Text = dt.Rows[0]["PicPath"].ToString();
                txbDescription.Text = dt.Rows[0]["Description"].ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!this.isModify)
            {
                string cmd = $"Insert into tblPC(PCID,ComputerName,IPAdress,Description,PicPath) values ('{Guid.NewGuid()}', '{txbPCName.Text}', '{txbIP.Text}', '{txbDescription.Text}', '{txbPathImage.Text}')";
                if (!StaticPool.mdb.ExecuteCommand(cmd))
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                string cmd = $"update tblPC set ComputerName = '{txbPCName.Text}', IPAdress = '{txbIP.Text}', Description = '{txbDescription.Text}', PicPath = '{txbPathImage.Text}' " +
                    $" where PCID = '{pcID}'";

                if (StaticPool.mdb.ExecuteCommand(cmd))
                {
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            
        }

        private void txbPCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void txbIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPathImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
