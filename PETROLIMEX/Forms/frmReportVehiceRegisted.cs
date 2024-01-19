using System.Data;
using System.Text;
using iPGSTools.Helper;
using PetrolimexTools;
using PetrolimexTools.Helper;

namespace PETROLIMEX.Forms
{
    public partial class frmReportVehiceRegisted : Form
    {
        public frmReportVehiceRegisted()
        {
            InitializeComponent();
        }
        private string[] TypeVehicle = new string[]
        {
            "","Xe đã đăng ký","Xe chưa đăng ký"
        };
        private string[] TypeLooking = new string[]
        {
            "","Xe chưa thanh toán","Xe thanh toán thất bại","Xe thanh toán thành công"
        };
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelperv2.Logger_Application_Progress($"Bắt đầu nhấn nút tìm kiếm", LogHelperv2.SaveLogFolder);
                string case0 = "Chưa thanh toán";
                string case1 = "Thanh toán thất bại";
                string case2 = "Thanh toán thành công";

                StringBuilder sb = new StringBuilder();
                sb.Append($"select CreateDate, StationID, PumpID, TimeAgasPumpPickup, TimePumping, TimeAgasPutdown, Etag, PlateNumber, Price, Volume, Amount, ImgPathPickup, ImgPathPumping, ImgPathPutdown, ");
                sb.Append("CASE ");
                sb.Append($"   WHEN StatusPayment = 0 THEN N'{case0}' ");
                sb.Append($"   WHEN StatusPayment = 1 THEN N'{case1}' ");
                sb.Append($"   WHEN StatusPayment = 2 THEN N'{case2}' ");
                sb.Append("   ELSE 'Unknown' ");
                sb.Append("END AS StatusPayment, ");
                sb.Append("Describe, ");
                sb.Append("CASE WHEN StatusCode = '00' THEN N'Tạo hóa đơn thành công' WHEN StatusCode = '01' THEN N'Tạo hóa đơn thất bại' WHEN StatusCode = '02' THEN N'Ngoại lệ' END AS StatusCodeInvoice, ");
                sb.Append("HD.reason as ReasonInvoice ");
                sb.Append($"from tblMainEvent left join tblCreateInvoice as HD on tblMainEvent.InvoiceID = convert(nvarchar(50), HD.IDInvoice) ");
                sb.Append($"where IsDelete = '{0}' ");

                // Loại xe đăng ký 
                if (cbbvehicleType.Text.Trim() == TypeVehicle[1])  // Last Name
                {
                    sb.Append($"and IsPlateValid = '{true}' ");
                }
                else if (cbbvehicleType.Text.Trim() == TypeVehicle[2])
                {
                    sb.Append($"and IsPlateValid = '{false}' ");
                }

                // Loai thanh toán 
                if (cbbType.Text.Trim() == TypeLooking[1])  // Last Name
                {
                    sb.Append($"and StatusPayment = '{0}' ");
                }
                else if (cbbType.Text.Trim() == TypeLooking[2])
                {
                    sb.Append($"and StatusPayment = '{1}' ");
                }
                else if (cbbType.Text.Trim() == TypeLooking[3])
                {
                    sb.Append($"and StatusPayment = '{2}' ");
                }

                if (txbPlate.Text != "")
                {
                    sb.Append($"and PlateNumber like '%{txbPlate.Text}%' ");
                }
                //sb.Append($" and TimeAgasPumpPickup != '' and TimePumping != '' and TimeAgasPutdown != '' and PlateNumber != '' ");
                sb.Append($" and CreateDate between '{dtpFrom.Value}' and '{dtpTo.Value}'");
                sb.Append($" order by CreateDate DESC");

                DataTable dt = StaticPool.mdb.FillData(sb.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    LogHelperv2.Logger_Application_Progress($"Tìm kiếm thành công có dữ liệu", LogHelperv2.SaveLogFolder);

                    dgvVehicleRegisted.DataSource = dt;
                    dgvVehicleRegisted.Columns["Amount"].DefaultCellStyle.Format = "N0";
                    dgvVehicleRegisted.Columns["Price"].DefaultCellStyle.Format = "N0";

                }
                else
                {
                    LogHelperv2.Logger_Application_Progress($"Tìm kiếm thất bại ko có dữ liệu", LogHelperv2.SaveLogFolder);

                    dgvVehicleRegisted.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_Application_Progress($"Tìm kiếm exception + {ex.ToString()}", LogHelperv2.SaveLogFolder);
            }
            


            
        }

        private void frmReportVehiceRegisted_Load(object sender, EventArgs e)
        {
            cbbvehicleType.Items.Clear();
            cbbType.Items.Clear();
            for (int i = 0; i < TypeVehicle.Length; i++)
            {
                cbbvehicleType.Items.Add(TypeVehicle[i]);
            }

            for (int i = 0; i < TypeLooking.Length; i++)
            {
                cbbType.Items.Add(TypeLooking[i]);
            }

            dtpFrom.Value = DateTime.Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0);
            dtpTo.Value = DateTime.Now;
            //LoadDGV();
        }

        private void LoadDGV()
        {
            string caseAm = "Không đăng ký";
            string case0 = "Chưa thanh toán";
            string case1 = "Thanh toán thất bại";
            string case2 = "Thanh toán thành công";

            StringBuilder sb = new StringBuilder();
            sb.Append($"select CreateDate, StationID, PumpID, TimeAgasPumpPickup, TimePumping, TimeAgasPutdown, Etag, PlateNumber, Price, Volume, Amount, ");
            sb.Append("CASE ");
            sb.Append($"   WHEN StatusPayment = -1 THEN N'{caseAm}' ");
            sb.Append($"   WHEN StatusPayment = 0 THEN N'{case0}' ");
            sb.Append($"   WHEN StatusPayment = 1 THEN N'{case1}' ");
            sb.Append($"   WHEN StatusPayment = 2 THEN N'{case2}' ");
            sb.Append("   ELSE 'Unknown' ");
            sb.Append("END AS StatusPayment ");
            sb.Append($"from tblMainEvent ");
            sb.Append($"where IsPlateValid = '{true}'");

            DataTable dt = StaticPool.mdb.FillData(sb.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvVehicleRegisted.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVehicleRegisted_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvVehicleRegisted != null && dgvVehicleRegisted.Rows.Count > 0)
            {
                for (int i = 0; i <= dgvVehicleRegisted.Rows.Count - 1; i++)
                {
                    // Trỏ hàng hiện tại đến hàng theo ID textbox 
                    dgvVehicleRegisted.Rows[i].Cells[0].Value = (i + 1).ToString();

                    if (dgvVehicleRegisted.Rows[i].Cells["StatusPayment"].Value.ToString() == "Thanh toán thất bại")
                    {
                        dgvVehicleRegisted.Rows[i].Cells["StatusPayment"].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void cbbvehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbvehicleType.SelectedIndex == 2)
            {
                cbbType.Visible = false;
                label2.Visible = false;
            }
            else
            {
                cbbType.Visible = true;
                label2.Visible = true;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelTools.CreatReportFile(dgvVehicleRegisted, "Báo cáo thanh toán đổ xăng Petrolimex");
        }

        private void dgvVehicleRegisted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            int i;
            i = dgvVehicleRegisted.CurrentRow.Index;
            //frm.Invoke(new Action(() =>
            //{
            //    frm.pictureBox1.Image = Image.FromFile(ImgPath);
            //}));
            //string a = dgvVehicleRegisted.Rows[i].Cells["ImgPathPickup"].Value.ToString();
            //string b = dgvVehicleRegisted.Rows[i].Cells["ImgPathPumping"].Value.ToString();
            //string c = dgvVehicleRegisted.Rows[i].Cells["ImgPathPutdown"].Value.ToString();
            //picNhacCo.Image = Image.FromFile(dgvVehicleRegisted.Rows[i].Cells["ImgPathPickup"].Value.ToString());
            //picBopCo.Image = Image.FromFile(dgvVehicleRegisted.Rows[i].Cells["ImgPathPumping"].Value.ToString());
            //picGacCo.Image = Image.FromFile(dgvVehicleRegisted.Rows[i].Cells["ImgPathPutdown"].Value.ToString());
            picNhacCo.Image = null;
            picBopCo.Image = null;
            picGacCo.Image = null;

            string imagePathPickup = dgvVehicleRegisted.Rows[i].Cells["ImgPathPickup"].Value.ToString();
            string imagePathPumping = dgvVehicleRegisted.Rows[i].Cells["ImgPathPumping"].Value.ToString();
            string imagePathPutdown = dgvVehicleRegisted.Rows[i].Cells["ImgPathPutdown"].Value.ToString();
            
            if (!string.IsNullOrEmpty(imagePathPickup) && File.Exists(imagePathPickup))
            {
                picNhacCo.Image = Image.FromFile(imagePathPickup);
            }
            if (!string.IsNullOrEmpty(imagePathPumping) && File.Exists(imagePathPumping))
            {
                picBopCo.Image = Image.FromFile(imagePathPumping);
            }
            if (!string.IsNullOrEmpty(imagePathPutdown) && File.Exists(imagePathPutdown))
            {
                picGacCo.Image = Image.FromFile(imagePathPutdown);
            }
        }
    }
}
