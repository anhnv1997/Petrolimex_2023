namespace PETROLIMEX.Databases
{
    public class dataAutoPayment
    {
        public string IDVehicle { get; set; } = "";
        public int STTPayment { get; set; } = 0;
        public string DateTimePayment { get; set; } = "";
        public string Location { get; set; } = "";
        public string dgvAutoPayment_plate { get; set; } = "";
        public string dgvAutoPayment_status { get; set; } = "";
        public long dgvAutoPayment_volume { get; set; } = 0;
        public long dgvAutoPayment_amount { get; set; } = 0;
        public string Payment { get; set; } = "";
        public string CreateInvoice { get; set; } = "";
        public bool isFinishPayment { get; set; } = false;


        public void CreatDGV(DataGridView dgv)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "IDVehicle", Name = "IDVehicle", DataPropertyName = "IDVehicle", Visible = false});
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", Name = "STTPayment" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Giờ Vào", Name = "DateTimePayment" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Vị trí", Name = "Location" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Biển số xe", Name = "dgvAutoPayment_plate" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng Thái", Name = "dgvAutoPayment_status" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Khối lượng", Name = "dgvAutoPayment_volume" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thành Tiền", Name = "dgvAutoPayment_amount" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thanh toán", Name = "Payment" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hóa Đơn", Name = "CreateInvoice" });
            dgv.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Hoàn thành", Name = "isFinishPayment" });
        }
        public void AddDGV(DataGridView dgv, dataAutoPayment data)
        {
        }
    }
}
