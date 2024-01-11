using CardDispenserLibrary;
using Futech.LPR;
using Kztek.Cameras;
using Kztek.LPR;
using iPGSTools.Models;
using static iPGSTools.Models.GasModel;
using static CardDispenserLibrary.MT116Controller;
using iPGSTools.Helper;
using iPGSTools.Databases;
using PETROLIMEX.Forms;
using System.Collections.Concurrent;
using PETROLIMEX.Helper;
using PETROLIMEX.Usercontrols;
using iPGS_ETOWN.UserControls;
using Timer = System.Windows.Forms.Timer;
using static PetrolimexTools.Model.QueryEtagResponse;
using PetrolimexTools.Helper;
using static PetrolimexTools.Model.Vehicle;
using PetrolimexTools;
using PetrolimexTools.Model;
using PETROLIMEX.Models;

namespace iPGSTools
{
    public partial class Form1 : Form
    {
        #region Properties
        public static Camera cameraPanaroma = new Camera();

        public static Form1 frm;
        public static Configuration configs = new Configuration();
        private ICardDispenser controller;
        private static int current_LPR_Index = 0;

        //public static string plateNumber = string.Empty;    // public
        //public static string ImgPath = string.Empty;

        public static ucGridview<ucLocationView>? ucGridviewGates;
        public static List<ucLocationView> listUcLocation = new List<ucLocationView>();
        #endregion

        public static Dictionary<string, ConcurrentQueue<GasModel>> locationQueueDictionary = new Dictionary<string, ConcurrentQueue<GasModel>>();
        public static Dictionary<string, Timer> locationTimerDictionary = new Dictionary<string, Timer>();

        private bool IsEnableAutoOpenApp = true;
        // **************************** Đây là nhánh Multilane ************************************************
        #region Forms
        public Form1()
        {
            try
            {
                InitializeComponent();
                frm = this;

                // Khơi tạo Location(camera..)
                InitLocationView();


            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Form1 ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private void InitLocationView()
        {
            int count = StaticPool.NumberLocation;
            int width = panel3.Width / count;
            ucGridviewGates = new ucGridview<ucLocationView>(1000, 5, 5);

            foreach (var location in StaticPool.listLocationConfig)
            {
                ucLocationView uc = new ucLocationView(location);
                ucGridviewGates.AddItem(uc);
                listUcLocation.Add(uc);

                string name = location.LocationName;
                // Khởi tạo queue
                ConcurrentQueue<GasModel> gasModelQueue = new ConcurrentQueue<GasModel>();
                locationQueueDictionary.Add(name, gasModelQueue);

                // Khởi tạo timer
                InitializeTimer(name, gasModelQueue);
            }
            ucGridviewGates.Dock = DockStyle.Fill;
            ucGridviewGates.BringToFront();

            panel3.Controls.Add(ucGridviewGates);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
                dgvNotRegisted.ContextMenuStrip = contextMenuStrip1;


                if (PETROLIMEX.Properties.Settings.Default.SplitPosition > 0)
                {
                    splitter1.SplitPosition = PETROLIMEX.Properties.Settings.Default.SplitPosition;
                }
                if (PETROLIMEX.Properties.Settings.Default.SplitPosition2 > 0)
                {
                    splitter2.SplitPosition = PETROLIMEX.Properties.Settings.Default.SplitPosition2;
                }
                //StartCameraView(ucCam);
                CreateLPREngine();

                if (ConnectCardReader())
                {
                    LogHelperv2.Logger_SystemInfor($"ConnectCardReader thành công", LogHelperv2.SaveLogFolder);

                    controller.onEvent += Controller_onEvent;
                    controller.PollingStart();
                }
                InitDataGridView();

            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Form1_Load ex: {ex}", LogHelperv2.SaveLogFolder);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    FISHelper.StopPollingAuthorize();
                });

                //Application.Exit();
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Form1_FormClosing ex: {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnTestDetect.Visible = !btnTestDetect.Visible;
                cbbDetechTest.Visible = !cbbDetechTest.Visible;

                cbbDetechTest.Items.Clear();
                if (cbbDetechTest.Visible == true)
                {
                    foreach (var item in StaticPool.listLocationConfig)
                    {
                        string name = item.LocationName;
                        cbbDetechTest.Items.Add(name);
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                button1.Visible = !button1.Visible;
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnTestAPI.Visible = !btnTestAPI.Visible;

            }
            else if (e.Control && e.KeyCode == Keys.F4)
            {
                IsEnableAutoOpenApp = !IsEnableAutoOpenApp;
                picEnableOpenApp.Visible = !picEnableOpenApp.Visible;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogHelperv2.Logger_CONTROLLER_Error($"Đóng form Form1_FormClosed với isEnableAutoApp = {IsEnableAutoOpenApp}", LogHelperv2.SaveLogFolder);

            if (IsEnableAutoOpenApp)
            {
                Application.Restart();
            }
        }

        private void InitDataGridView()
        {
            dgvAutoPaymentVehicle.RowTemplate.Height = 100;
        }

        #endregion
        private bool ConnectCardReader()
        {
            try
            {
                if (!NetWorkTools.IsPingSuccess(StaticPool.controllerInfo.controllerIP, 100))
                {
                    MessageBox.Show("Không Thể Ping Đến Thiết Bị, Hãy Kiểm Tra Lại", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                controller = ICardDispenserFactory.GetCardDispenser(EM_CardDispenser.v5);
                controller.ControllerInfor.IpAddress = StaticPool.controllerInfo.controllerIP;   // 1. 250
                controller.ControllerInfor.Comport = StaticPool.controllerInfo.controllerIP;
                controller.ControllerInfor.Port = StaticPool.controllerInfo.controllerPort;
                controller.ControllerInfor.Baudrate = 100;
                if (controller.Connect())
                {
                    lblConnectStatus.Text = "Connected";
                    LogHelperv2.Logger_CONTROLLER_Infor($"Kết nối CardReader thành công", LogHelperv2.SaveLogFolder);
                }
                else
                {
                    lblConnectStatus.Text = "Disconnect";
                    MessageBox.Show("Kết Nối Đến Thiết Bị Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Form1_FormClosing ex: {ex}", LogHelperv2.SaveLogFolder);
                return false;
            }
            // Check dải mạng

            // Check ping

        }
        #region Controls In Form
        private void panelCamera_SizeChanged(object sender, EventArgs e)
        {

            PETROLIMEX.Properties.Settings.Default.SplitPosition = splitter1.SplitPosition;
            //PETROLIMEX.Properties.Settings.Default.SplitPosition = splitter2.SplitPosition;

            PETROLIMEX.Properties.Settings.Default.Save();
        }
        #endregion

        #region Private Function

        //private void StartCameraView(ucCameraView ucCamera)
        //{
        //    try
        //    {
        //        panelCamera?.Invoke(new Action(() =>
        //        {
        //            panelCamera.Controls.Add(ucCamera);
        //            ucCamera?.Invoke(() =>
        //            {
        //                ucCamera.StartViewer(StaticPool.listCamera[1], CameraErrorFunc, CameraDoubleClickFunc);
        //            });
        //        }));
        //    }
        //    catch (Exception ex)
        //    {
        //        LogHelperv2.Logger_CONTROLLER_Error($"Exception StartCameraView ex: {ex}", LogHelperv2.SaveLogFolder);
        //        MessageBox.Show($"Exception StartCameraView: {ex}");
        //    }

        //}
        private void CameraErrorFunc(object sender, string errorString)
        {

        }
        private void CameraDoubleClickFunc(object sender, EventArgs e)
        {
        }

        void CreateLPREngine()
        {
            try
            {
                StaticPool.carANPR1 = new CarANPR();
                StaticPool.carANPR1.NewError += CarANPR1_NewError; ;
                StaticPool.carANPR1.LPREngineProductKey = "demo";
                StaticPool.carANPR1.EnableLPREngine2 = true;
                StaticPool.carANPR1.CreateLPREngine();
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception CreateLPREngine ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }
        private void CarANPR1_NewError(object sender, Kztek.LPR.ErrorEventArgs e)
        {
        }
        private bool CheckExitEtag(string cardNumber)
        {
            try
            {

                foreach (DataGridViewRow row in dgvEtag.Rows)
                {
                    string etagValue = row.Cells["Etag"].Value?.ToString();

                    if (cardNumber == etagValue)
                    {
                        return false;
                    }
                }

                foreach (DataGridViewRow row in dgvNotRegisted.Rows)
                {
                    string etagValue = row.Cells["EtagStatus"].Value?.ToString();

                    if (cardNumber == etagValue)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception CheckExitEtag ex = {ex}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        // SỰ KIỆN ĐẦU ĐỌC ETAG
        private async void Controller_onEvent(object? sender, MT116Controller.MT116EventArgs e)
        {
            try
            {
                if (e.CardNumber == null || e.CardNumber == "")
                {
                    LogHelperv2.Logger_CONTROLLER_Error($" Mã etag = rỗng ", LogHelperv2.SaveLogFolder);
                    return;
                }
                //LogHelperv2.Logger_CONTROLLER_Infor($"Nhận thành công sự kiện Etag chưa check trùng: {e.CardNumber}", LogHelperv2.SaveLogFolder);

                // Fix cung
                //e.CardNumber = "3416214B880E700001941070";   // A Nguyên Fixx
                //e.CardNumber = "3416214B880E700001941111";  

                if (!CheckExitEtag(e.CardNumber)) return;

                //-- check ben dang ky thanh toan
                LogHelperv2.Logger_CONTROLLER_Infor($"Nhận thành công sự kiện Etag đã check trùng: {e.CardNumber}", LogHelperv2.SaveLogFolder);

                string etag = e.CardNumber;
                string feaprequestid = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string etagid = "01";
                string stationid = StaticPool.StationID;

                if (string.IsNullOrEmpty(stationid))
                {
                    MessageBox.Show("Chưa nhập id cửa hàng");
                    return;
                }
                //string stationid = "81817";   // Cửa hàng PLX 30
                //string stationid = "8508718"; // Cửa hàng PLX 148

                Vehicle vehicle = await FISHelper.QueryEtag(etag, etagid, feaprequestid, stationid);
                vehicle.etag = etag;

                if (vehicle == null)
                {
                    AddDGVEventError("Etag: " + etag, MLS.Etag.APIQueryEtagFail, "");
                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.Etag.APIQueryEtagFail, "", etag);
                    return;
                }
                else
                {
                    if (vehicle.autopayment == EmAutoPayment.KhongThanhToanTuDong)
                    {
                        LogHelperv2.Logger_CONTROLLER_Infor($"Mã eTag:{etag} ko đăng ký thanh toán tự động", LogHelperv2.SaveLogFolder);
                        AddDGVNotEtag(etag, vehicle);
                    }
                    else if (vehicle.autopayment == EmAutoPayment.CoThanhToanTuDong)
                    {
                        LogHelperv2.Logger_CONTROLLER_Infor($"Mã eTag:{etag} có đăng ký thanh toán tự động", LogHelperv2.SaveLogFolder);

                        //Staticpool.vehicleWithAutoPayments.Add(vehicle);

                        AddDGVEtag(etag, vehicle);
                        AddDGVPayment(vehicle);
                    }

                    // Lưu dữ liệu DB
                    if (!MyQuery.InsertQueryEtag(vehicle))
                    {
                        // Lưu lỗi vào bảng Log hoặc return
                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.Etag.InserttblQueryEtagFail, "", etag);
                    }
                }
            }
            catch (Exception exx)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Controller_onEvent ex = {exx}", LogHelperv2.SaveLogFolder);
            }
            finally
            {
                Refresh();
            }
        }

        public static object lockObj = new object();
        // SỰ KIỆN AGAS 
        public static async Task UpdateGasEvent(GasModel gasModel, string locationName)
        {
            try
            {
                // Ví dụ config
                /* Vị trí 1 gán camera1 Tiandy và vòi 8,9,10 
                   Vị trí 2 gán camera2 Hanse và vòi 5,6,7
                   Vị trí 3 gán camera3 Dahua và vòi 2,3,4
                 */

                // Lấy ra ID vòi có sự kiện từ agas (VD: vòi 6)

                // Tìm trong danh sách config StaticPool ứng với camera nào và vị trí nào (modelConfig {vòi 6; camera 2 ; vị trí 2})

                // Gán StaticPool.Camera = camera 2 -> Dùng cho Detech camera (hiện tại StaticPool.camera dùng trong: - StartView load form
                //                                                                                                    - Recoplate nhận dạng mỹ           
                //                                                                                                    - Detech nhận dạng kztek
                // Mỗi vị trí sử dụng 1 luồng - Các sự kiện vòi trong cùng 1 vị trí xử lý tuần tự

                LogHelperv2.Logger_CONTROLLER_Infor($"=>>>>>>>>>>>> Nhận sự kiện Agas, Sự kiện Agas chờ có số lượng: {0}", LogHelperv2.SaveLogFolder, gasModel);
                string IDAgas = Guid.NewGuid().ToString();      // IDAgas khác AgastransID

                //Take Plate

                modelDetech modelDetech = await RecognPlate(gasModel, locationName);

                // lưu sự kiện Agas vào db
                if (!MyQuery.InsertQueryAgas(gasModel, IDAgas, modelDetech.ImagePath))
                {
                    LogHelperv2.Logger_CONTROLLER_Infor("=>>>>>>>>>>>> Lưu vào db QueryAgas thất bại", LogHelperv2.SaveLogFolder, gasModel);

                    // Lưu lỗi vào tblLog
                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.Agas.InserttblAgasFail, IDAgas, "");
                }

                if(gasModel.pumpstatus == (int)EM_PumpStatus.NhacCo)
                {
                    // So sanh BS
                }
                else
                {

                }

                //Kiểm tra danh sách xe tích hợp thanh toán tự động có xe đang đổ xăng hay không
                if (StaticPool.vehicleWithAutoPayments.IsContainPlate(modelDetech.PlateNumber))
                {
                    LogHelperv2.Logger_CONTROLLER_Infor($"So sánh biển số thành công: {modelDetech.PlateNumber} - Biển số có nằm trong danh sách chờ eTag", LogHelperv2.SaveLogFolder);

                    // Lấy phương tiện ứng vs BS
                    Vehicle vehicle = StaticPool.vehicleWithAutoPayments.GetVehicleByPlate(modelDetech.PlateNumber);
                    // Vehicle.PlateNumber đã gán
                    vehicle.IDAgas = IDAgas;
                    vehicle.TimeAgas = DateTime.Now;
                    vehicle.LocationName = locationName;

                    switch (gasModel.pumpstatus)
                    {
                        case (int)EM_PumpStatus.NhacCo:
                            {
                                if (vehicle.pumpid != "")
                                {
                                    if (vehicle.pumpid != gasModel.pumpid)
                                    {
                                        // Đang có sự kiện bơm cho biển số này ở vòi khác
                                        // Hiện cảnh báo 
                                        AddDGVEventError(modelDetech.PlateNumber, MLS.NhacCo.WrongPump, locationName);
                                        LogHelperv2.Logger_CONTROLLER_Warning($"Cảnh báo sự kiện nhấc cò: vòi bơm hiện tại: {gasModel.pumpid}. Đang có sự kiện bơm cho bs: {modelDetech.PlateNumber} này với vòi bơm pumpID = {vehicle.pumpid} này!!!", LogHelperv2.SaveLogFolder, vehicle);
                                        return;
                                    }
                                    else
                                    {
                                        AddDGVEventError(modelDetech.PlateNumber, MLS.NhacCo.WrongPump, locationName);
                                        LogHelperv2.Logger_CONTROLLER_Warning($"Cảnh báo sự kiện nhấc cò: vòi bơm hiện tại: {gasModel.pumpid}. Đã có sự kiện nhấc cò cho bs: {modelDetech.PlateNumber}!!!", LogHelperv2.SaveLogFolder, vehicle);
                                        return;
                                    }
                                }
                                vehicle.VehicleStatus = Vehicle.EmVehicleStatus.NhacCo;
                                vehicle.isNhacCo = true;
                                vehicle.pumpid = gasModel.pumpid;
                                vehicle.Price = gasModel.price;
                                vehicle.Volume = 0;
                                vehicle.Amount = 0;
                                vehicle.ImgPathPickup = modelDetech.ImagePath;

                                // Dữ liệu Order
                                Order order = InitOrder(gasModel, vehicle);
                                //GỬI API TẠO ĐƠN HÀNG SANG BEAP -- CREATE ORDER
                                OrderResponse CreatOrderResponse = await FISHelper.CreateOrder(order);

                                if (CreatOrderResponse != null)
                                {
                                    LogHelperv2.Logger_CONTROLLER_Infor($"Tạo thành công đơn hàng CreateOrder etag, cập nhật Vehicle:", LogHelperv2.SaveLogFolder, vehicle);

                                    vehicle.feapresponseid = CreatOrderResponse.feapresponseid;
                                    vehicle.beaptransid = CreatOrderResponse.beaptransid;

                                    UpdateView(vehicle);

                                    // Lưu vào DB
                                    if (!MyQuery.InsertCreateOrder(vehicle, gasModel))
                                    {
                                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblCreateOrderFail, IDAgas, "");
                                    }
                                    if (!MyQuery.CheckProcessError(vehicle.platenumber))
                                    {

                                    }
                                    if (!MyQuery.InsertMainEvent(vehicle, gasModel))
                                    {
                                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblMainEventFail, IDAgas, "");
                                    }
                                }
                                else
                                {
                                    // Gửi API TẠO ĐƠN HÀNG thất bại null 
                                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.APICreateOrderFail, IDAgas, "");

                                    AddDGVEventError("Create Order", MLS.NhacCo.APICreateOrderFail, locationName);

                                    if (!MyQuery.InsertMainEvent_SaiQuyTrinh(vehicle, gasModel, MLS.NhacCo.APICreateOrderFail))
                                    {
                                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblMainEventFail, IDAgas, "");
                                    }
                                    return;
                                }
                            }
                            break;

                        case (int)EM_PumpStatus.BopCo:

                            vehicle.VehicleStatus = Vehicle.EmVehicleStatus.DangDoXang;
                            vehicle.Volume = gasModel.volume;
                            vehicle.Amount = gasModel.amount;
                            vehicle.ImgPathPumping = modelDetech.ImagePath;

                            // Kiểm tra đã đúng vòi chưa 
                            if (vehicle.pumpid == gasModel.pumpid)
                            {
                                // Kiểm tra có sự kiện nhấc cò chưa
                                if (vehicle.isNhacCo)       // Sự kiện hợp lệ 
                                {
                                    vehicle.isBopCo = true;

                                    if (!MyQuery.UpdateMainEventPumping(vehicle, gasModel))
                                    {
                                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.BopCo.UpdatettblMainEventFail_BopCo, IDAgas, "");
                                    }

                                    LogHelperv2.Logger_CONTROLLER_Infor($"Đang đổ xăng, cập nhật Vehicle:", LogHelperv2.SaveLogFolder, vehicle);

                                    UpdateView(vehicle);
                                }
                                else            // Sự kiện sai quy trình
                                {
                                    // Bơm xăng, sai quy trinh
                                    LogHelperv2.Logger_CONTROLLER_Infor($"Bơm xăng sai quy trình, Chưa có sự kiện nhấc cò", LogHelperv2.SaveLogFolder, vehicle);
                                    UpdateViewError(vehicle, MLS.BopCo.BomXangSaiQuyTrinh);
                                    DeleteViewAndListEtag(vehicle);
                                    AddDGVEventError($"Biển số {vehicle.platenumber}", MLS.BopCo.BomXangSaiQuyTrinh, locationName);

                                    if (!MyQuery.InsertMainEvent_SaiQuyTrinh(vehicle, gasModel, MLS.BopCo.BomXangSaiQuyTrinh))
                                    {
                                        MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblMainEventFail, IDAgas, "");
                                    }
                                }
                            }
                            else       // // Sự kiện sai quy trình 2
                            {
                                // Nhận sự kiện tại vòi bơm khác nhưng bắt biển số tại vòi khác
                                LogHelperv2.Logger_CONTROLLER_Infor($"Bơm xăng sai quy trình, sự kiện nhấc cò và bóp cò cùng BS nhưng của 2 vòi bơm khác nhau", LogHelperv2.SaveLogFolder, vehicle);
                                UpdateViewError(vehicle, MLS.BopCo.BomXangSaiVoi);
                                DeleteViewAndListEtag(vehicle);
                                AddDGVEventError($"Biển số {vehicle.platenumber}", MLS.BopCo.BomXangSaiVoi, locationName);

                                if (!MyQuery.InsertMainEvent_SaiQuyTrinh(vehicle, gasModel, MLS.BopCo.BomXangSaiVoi))
                                {
                                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblMainEventFail, IDAgas, "");
                                }
                            }


                            break;

                        case (int)EM_PumpStatus.GacCo:
                            {
                                vehicle.VehicleStatus = Vehicle.EmVehicleStatus.GacCo;
                                vehicle.Amount = gasModel.amount;
                                vehicle.Volume = gasModel.volume;
                                vehicle.ImgPathPutdown = modelDetech.ImagePath;

                                if (vehicle.pumpid == gasModel.pumpid)
                                {
                                    if (vehicle.isNhacCo && vehicle.isBopCo)
                                    {
                                        // Sự kiện hợp lệ
                                        vehicle.isGacCo = true;

                                        // Hiển thị đang thanh toán
                                        UpdateView(vehicle, EmPaymentStatus.DangThanhToan);

                                        //GỬI API YÊU CẦU THANH TOÁN SANG BEAP -- PAYMENT
                                        Payment payment = InitPayment(gasModel, vehicle);

                                        var paymentResponse = await FISHelper.Payment(payment);

                                        Task.Run(async () =>
                                        {
                                            bool isPayment = false;
                                            if (paymentResponse == null)
                                            {
                                                // API Null
                                                isPayment = false;
                                                LogHelperv2.Logger_CONTROLLER_Error($"Thanh toán thất bại với etag paymentResponse = null, cập nhật Vehicle:", LogHelperv2.SaveLogFolder, vehicle);

                                                UpdateView(vehicle, EmPaymentStatus.ThanhToanThatBai, "api null");
                                                DeleteViewAndListEtag(vehicle);

                                                AddDGVEventError("Payment Fail", MLS.GacCo.APIPaymentFail, locationName);
                                                // Thêm tblLog
                                                MyQuery.InsertLog(EmTypeLog.LogError, MLS.GacCo.APIPaymentFail, IDAgas, "");
                                            }
                                            else
                                            {
                                                //APi hợp lệ
                                                //vehicle.VehicleStatus = !string.IsNullOrEmpty(paymentResponse.beaptransid) ? Vehicle.EmVehicleStatus.GacCo : Vehicle.EmVehicleStatus.HuyGiaoDich;
                                                //Trả về thanh toán thành công
                                                if (paymentResponse.paystatus.Contains("SUCC"))
                                                {
                                                    isPayment = true;

                                                    LogHelperv2.Logger_CONTROLLER_Infor($"Thanh toán thành công với biển số: {vehicle.platenumber}, eTag: {vehicle.etag}", LogHelperv2.SaveLogFolder, vehicle);

                                                    StaticPool.vehicleWithAutoPayments.Remove(vehicle);


                                                    UpdateView(vehicle, EmPaymentStatus.ThanhToanThanhCong);
                                                    DeleteViewAndListEtag(vehicle);

                                                    /// GỬI KẾT QUẢ THANH TOÁN THÀNH CÔNG ĐẾN AGAS - API LOG + API TẠO HÓA ĐƠN 
                                                    await Send_API_Result_To_Agas(IDAgas, vehicle, payment, paymentResponse, locationName);


                                                }
                                                else if (paymentResponse.paystatus.Contains("FAIL"))  // Thanh toán thất bại
                                                {
                                                    isPayment = false;
                                                    vehicle.Describtion = "Nhận thanh toán FAIL từ Backend";
                                                    LogHelperv2.Logger_CONTROLLER_Error($"Thanh toán thất bại với biển số: {vehicle.platenumber}, eTag: {vehicle.etag}", LogHelperv2.SaveLogFolder, vehicle);

                                                    // Lấy lý do thất bại
                                                    string reasonFail = paymentResponse.paystatus.Substring(4);

                                                    UpdateView(vehicle, EmPaymentStatus.ThanhToanThatBai, reasonFail);
                                                    DeleteViewAndListEtag(vehicle);
                                                }
                                                else
                                                {
                                                    vehicle.Describtion = "Nhận response ngoại lệ từ Backend";
                                                    UpdateView(vehicle, EmPaymentStatus.ThanhToanThatBai, vehicle.Describtion);
                                                    DeleteViewAndListEtag(vehicle);

                                                    LogHelperv2.Logger_CONTROLLER_Error($"Thanh toán trả về ngoại lệ: {vehicle.platenumber}, eTag: {vehicle.etag}", LogHelperv2.SaveLogFolder, vehicle);
                                                }
                                                // Lưu sự kiện bảng Payment 
                                                if (!MyQuery.InsertPayment(vehicle, paymentResponse))
                                                {
                                                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.GacCo.InserttblPaymentFail, IDAgas, "");
                                                }
                                            }
                                            // Update bảng sự kiện chính MainEvent
                                            int statusPayment = isPayment ? (int)EmPaymentStatusSQL.ThanhToanThanhCong : (int)EmPaymentStatusSQL.ThanhToanThatBai;
                                            if (!MyQuery.UpdateMainEventPayment(vehicle, gasModel, statusPayment, true))
                                            {
                                                MyQuery.InsertLog(EmTypeLog.LogError, MLS.GacCo.UpdatettblMainEventFail_GacCo, IDAgas, "");

                                            }
                                        });
                                    }
                                    else
                                    {
                                        // Huy Đóng vòi, sai quy trình 
                                        LogHelperv2.Logger_CONTROLLER_Infor($"Đóng vòi, sai quy trình, Chưa có sự kiện bơm xăng", LogHelperv2.SaveLogFolder, vehicle);
                                        UpdateViewError(vehicle, MLS.GacCo.GacCoError);
                                        DeleteViewAndListEtag(vehicle);
                                        AddDGVEventError($"Biển số {vehicle.platenumber}", MLS.GacCo.GacCoError, locationName);

                                        if (!vehicle.isNhacCo)
                                        {
                                            if (!MyQuery.InsertMainEvent_SaiQuyTrinh(vehicle, gasModel, MLS.GacCo.GacCoSaiQuyTrinh))
                                            {
                                                MyQuery.InsertLog(EmTypeLog.LogError, MLS.NhacCo.InserttblMainEventFail, IDAgas, "");
                                            }
                                        }
                                        else
                                        {
                                            if (!MyQuery.UpdateMainEvent_GacCoSaiQuyTrinh(vehicle, gasModel, MLS.GacCo.GacCoSaiQuyTrinh))
                                            {
                                                MyQuery.InsertLog(EmTypeLog.LogError, MLS.GacCo.UpdatettblMainEventFail_GacCo, IDAgas, "");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    LogHelperv2.Logger_CONTROLLER_Error($"Gác cò sai quy trình, sự kiện gác cò và bóp cò cùng BS nhưng của 2 vòi bơm khác nhau", LogHelperv2.SaveLogFolder, vehicle);
                                    if (vehicle.IDMainEvent != "")
                                    {
                                        MyQuery.UpdateMainEventSaiVoi(vehicle, gasModel);
                                    }
                                }
                            }
                            break;

                        case (int)EM_PumpStatus.HuyGiaoDich:

                            if (vehicle.pumpid == gasModel.pumpid)
                            {
                                vehicle.VehicleStatus = Vehicle.EmVehicleStatus.HuyGiaoDich;
                                vehicle.ImgPathCancel = modelDetech.ImagePath;
                                LogHelperv2.Logger_CONTROLLER_Infor($"Hủy giao dịch: {vehicle.platenumber}, eTag: {vehicle.etag}", LogHelperv2.SaveLogFolder, vehicle);
                                UpdateView(vehicle, EmPaymentStatus.HuyGiaoDich);
                                DeleteViewAndListEtag(vehicle);
                                if (!MyQuery.UpdateMainEventCancel(vehicle, gasModel))
                                {
                                    MyQuery.InsertLog(EmTypeLog.LogError, "", IDAgas, "");
                                }
                            }
                            else
                            {
                                LogHelperv2.Logger_CONTROLLER_Infor($"Hủy giao dịch sai quy trình, cùng BS nhưng khác vòi bơm", LogHelperv2.SaveLogFolder, vehicle);
                            }
                            break;

                        default:
                            return;
                    }
                }
                // Các trường hợp else
                // Không đọc được biển số - biển số rỗng
                // Đọc biển số sai
                // Đọc đúng BS nhưng ko có trong danh sách chờ
                else
                {
                    // Lưu biển số vào danh sách chưa đăng ký
                    // Hiện tại chưa có phần hiển thị trạng thái đổ xăng của xe chưa đăng ký
                    LogHelperv2.Logger_CONTROLLER_Infor($"So sánh biển số - Không tìm thấy biển số trong danh sách eTag (không dùng eTag hoặc eTag ko đăng ký giao dịch)", LogHelperv2.SaveLogFolder, gasModel);
                    Vehicle vehicleNotRegisted = new Vehicle();

                    if (!MyQuery.CheckProcessError(modelDetech.PlateNumber))
                    {

                    }

                    switch (gasModel.pumpstatus)
                    {
                        case (int)EM_PumpStatus.NhacCo:
                            // lưu db trạng thái nhấc cò
                            if (!MyQuery.InsertMainEventNotRegisted(gasModel, modelDetech.PlateNumber, IDAgas, modelDetech.ImagePath))
                            {
                                //
                            }
                            break;

                        case (int)EM_PumpStatus.BopCo:
                            // Tạm thời không check trạng thái đã nhấc cò chưa với xe chưa đăng ký
                            if (!MyQuery.UpdateMainEventNotRegisted_BopCo(gasModel, modelDetech.PlateNumber, IDAgas, modelDetech.ImagePath))
                            {
                                //
                            }

                            break;
                        case (int)EM_PumpStatus.GacCo:
                            if (!MyQuery.UpdateMainEventNotRegisted_GacCo(gasModel, modelDetech.PlateNumber, IDAgas, modelDetech.ImagePath))
                            {
                                //
                            }
                            break;

                        case (int)EM_PumpStatus.HuyGiaoDich:
                            if (!MyQuery.UpdateMainEventNotRegisted_HuyGiaoDich(gasModel, modelDetech.PlateNumber, IDAgas, modelDetech.ImagePath))
                            {
                                //
                            }
                            break;
                        default:
                            break;
                    }

                    // Update view
                    foreach (DataGridViewRow row in frm.dgvEventError.Rows)
                    {
                        string nameEvent = row.Cells["NameEvent"].Value?.ToString();
                        string locationEr = row.Cells["locationError"].Value?.ToString();

                        if (nameEvent.Contains(modelDetech.PlateNumber) && locationName == locationEr)
                        {
                            return;
                        }
                    }
                    AddDGVEventError(modelDetech.PlateNumber, MLS.Plate.ComparePlateFail, locationName);

                }
                //Update view
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception UpdateGasEvent ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private static async Task Send_API_Result_To_Agas(string IDAgas, Vehicle vehicle, Payment payment, PaymentResponse? paymentResponse, string locationName)
        {
            try
            {
                // Gửi Log kết quả đến AGAS
                if (!await FISHelper.AutoPaymentLog(payment, paymentResponse))
                {
                    AddDGVEventError("AutoPaymentLog", MLS.GacCo.APILogPaymentFail, locationName);
                }
                else
                {
                    // Ko có bảng Log -> bỏ lưu ID log vào MainEvent
                    //if (!MyQuery.UpdateMainEventLogPayment(vehicle))
                    //{
                    //    MyQuery.InsertLog(EmTypeLog.LogError, MLS.GacCo.UpdatettblMainEventFail_LogPayment, IDAgas, "");
                    //}
                }

                // gửi request tạo hóa đơn đến agas
                if (!await FISHelper.CreateInvoice(payment, paymentResponse, vehicle))
                {
                    AddDGVEventError("feapcreateinvoice", MLS.GacCo.FeapCreateInvoice, locationName);
                }
                else
                {
                    AddDGVEventError("FeapCreateInvoice", "Gửi hóa đơn CreateInvoice thành công", locationName);
                }

                UpdateViewHoaDon(vehicle);

                LogHelperv2.Logger_LPR_Infor($"Kết thúc API TO AGAS reason: {vehicle.createInvoiceResponse.reason}", LogHelperv2.SaveLogFolder, vehicle);

                // Lưu kết quả hóa đơn vào bảng hóa đơn tblCreateInvoice
                MyQuery.InsertCreateInvoice(vehicle);

            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Send_API_Result_To_Agas ex = {ex}", LogHelperv2.SaveLogFolder);
            }

        }

        private void AddDGVPayment(Vehicle vehicle)
        {
            try
            {
                dgvAutoPaymentVehicle.Invoke(new Action(() =>
                {
                    if (dgvAutoPaymentVehicle.Rows.Count > 30)
                    {
                        dgvAutoPaymentVehicle.Rows.RemoveAt(0);
                    }
                    int rowIndex = dgvAutoPaymentVehicle.Rows.Add(vehicle.IDVehicle, dgvAutoPaymentVehicle.Rows.Count + 1, DateTime.Now, "", vehicle.platenumber, vehicle.GetDisplayStatus(), 0, 0, "", "", false);

                    dgvAutoPaymentVehicle.CurrentCell = dgvAutoPaymentVehicle.Rows[rowIndex].Cells[1];

                    for (int i = 0; i < dgvAutoPaymentVehicle.Rows.Count; i++)
                    {
                        dgvAutoPaymentVehicle.Rows[i].Cells["STTPayment"].Value = (i + 1).ToString();
                    }
                    dgvAutoPaymentVehicle.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception AddDGVPayment ex = {ex}", LogHelperv2.SaveLogFolder);
            }

        }

        private void AddDGVEtag(string etag, Vehicle vehicle)
        {
            try
            {
                dgvEtag?.Invoke(new Action(() =>
                {
                    if (dgvEtag.Rows.Count > 20)
                    {
                        dgvEtag.Rows.RemoveAt(0);
                    }
                    int rowIndex = dgvEtag.Rows.Add(dgvEtag.Rows.Count + 1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), etag, vehicle.platenumber);
                    StaticPool.vehicleWithAutoPayments.Add(vehicle);

                    dgvEtag.CurrentCell = dgvEtag.Rows[rowIndex].Cells[0];

                    for (int i = 0; i < dgvEtag.Rows.Count; i++)
                    {
                        dgvEtag.Rows[i].Cells["STTEtag"].Value = (i + 1).ToString();
                    }
                    dgvEtag.Refresh();

                }));
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception AddDGVEtag ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private void AddDGVNotEtag(string etag, Vehicle vehicle)
        {
            try
            {
                dgvNotRegisted?.Invoke(new Action(() =>
                {
                    if (dgvNotRegisted.Rows.Count > 100)
                    {
                        dgvNotRegisted.Rows.RemoveAt(0);
                    }
                    int rowIndex = dgvNotRegisted.Rows.Add(dgvNotRegisted.Rows.Count + 1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), etag, vehicle.platenumber);
                    dgvNotRegisted.CurrentCell = dgvNotRegisted.Rows[rowIndex].Cells[0];
                    for (int i = 0; i < dgvNotRegisted.Rows.Count; i++)
                    {
                        dgvNotRegisted.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                    }
                    //LogHelperv2.Logger_CONTROLLER_Infor($"Mã eTag:{etag} đã cập nhật lên view", LogHelperv2.SaveLogFolder);
                    dgvNotRegisted.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception AddDGVNotEtag ex = {ex}", LogHelperv2.SaveLogFolder);
            }

        }
        private static void AddDGVEventError(string nameEventError, string statusError, string locationName)
        {
            frm.dgvEventError?.Invoke(new Action(() =>
            {
                if (frm.dgvEventError.Rows.Count > 100)
                {
                    frm.dgvEventError.Rows.RemoveAt(0);
                }

                int rowIndex = frm.dgvEventError.Rows.Add(frm.dgvEventError.Rows.Count + 1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), locationName, nameEventError, statusError);
                frm.dgvEventError.CurrentCell = frm.dgvEventError.Rows[rowIndex].Cells[0];

                for (int i = 0; i < frm.dgvEventError.Rows.Count; i++)
                {
                    frm.dgvEventError.Rows[i].Cells["STTEvent"].Value = (i + 1).ToString();
                }
                frm.dgvEventError.Refresh();
            }));
        }

        public static void DeleteViewAndListEtag(Vehicle vehicle)
        {
            frm.dgvEtag.Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in frm.dgvEtag.Rows)
                {
                    if (row.Cells["Etag"].Value.ToString() == vehicle.etag)
                    {
                        frm.dgvEtag.Rows.Remove(row);
                        StaticPool.vehicleWithAutoPayments.Remove(vehicle);
                        LogHelperv2.Logger_CONTROLLER_Infor($"Xóa thành công etag này trong list danh sách chờ bảng DGVEtag", LogHelperv2.SaveLogFolder, vehicle);
                        return;
                        // return có update view được ko
                    }
                }
            }));
        }

        private static async Task<modelDetech> RecognPlate(GasModel gasModel, string locationName)
        {
            try
            {
                modelDetech model = new modelDetech();

                //plateNumber = "";

                DateTime saveTime = DateTime.Now;

                if (!String.IsNullOrEmpty(StaticPool.applicationConfig.LPR_API))
                {
                    // Chưa xử lý cho location nào
                    Event_Info infor = await configs.Capture_Image(StaticPool.camera, Application.StartupPath + "\\images", saveTime);

                    if (!string.IsNullOrEmpty(infor?._imgPath_LPR_Morning))
                    {
                        if (File.Exists(infor?._imgPath_LPR_Morning))
                        {
                            Image img = Image.FromFile(infor?._imgPath_LPR_Morning);
                            byte[] data = PlateReader.GetByteArray((Bitmap)img);
                            string a = StaticPool.applicationConfig.LPR_API;
                            PlateReaderResult plateReaderResult = PlateReader.Read(StaticPool.applicationConfig.LPR_API, data, "");
                            if (plateReaderResult != null)// && plateReaderResult.Results.Count > 0)
                            {
                                var results = GetBestResult(plateReaderResult);
                                if (results != null && results.Count > 0)
                                    model.PlateNumber = results[results.Count - 1].Text;
                                else
                                    model.PlateNumber = string.Empty;
                            }
                            else
                            {
                                model.PlateNumber = string.Empty;
                            }
                        }
                        else
                        {
                            model.PlateNumber = string.Empty;
                        }
                    }
                    else
                    {
                        model.PlateNumber = string.Empty;
                    }
                }
                else
                {
                    model = await DetectPlate(saveTime, locationName);
                }

                foreach (var item in listUcLocation)
                {
                    if (item.title == locationName)
                    {
                        item.SetText(DateTime.Now, model.PlateNumber);
                    }
                }

                model.PlateNumber = StaticPool.StandardlizePlateNumber(model.PlateNumber);

                //Fix cung BS
                //if (gasModel.agastransid == "170515757628251057")
                //{
                //    model.PlateNumber = "30H35392";
                //}
                //else
                //{
                //    model.PlateNumber = "30A12716";
                //}

                if (string.IsNullOrEmpty(model.PlateNumber) || model.PlateNumber == "")
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Đọc biển số thất bại với sự kiện agastranid sau: {gasModel.agastransid}", LogHelperv2.SaveLogFolder);
                    AddDGVEventError("Plate Fail", MLS.Plate.ReadPlateFail, locationName);
                    // Biển số rỗng vẫn lưu là sự kiện đổ xăng với xe không đăng ký -> ko return
                    //return;
                }
                LogHelperv2.Logger_CONTROLLER_Infor($"Đọc thành công biển số: {model.PlateNumber} với sự kiện agastranid sau: {gasModel.agastransid}", LogHelperv2.SaveLogFolder);
                return model;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception RecognPlate ex = {ex}", LogHelperv2.SaveLogFolder);
                return new modelDetech();
            }

        }

        private static Payment InitPayment(GasModel gasModel, Vehicle vehicle)
        {
            Payment payment = new Payment();
            payment.agastransid = gasModel.agastransid;
            payment.timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            payment.pumpid = gasModel.pumpid;
            payment.stationid = gasModel.stationid;
            payment.price = gasModel.price;
            payment.volume = gasModel.volume;
            payment.amount = gasModel.amount;
            payment.etag = vehicle.etag;
            payment.platenumber = vehicle.platenumber;
            payment.plxid = vehicle.plxid;
            payment.subid = vehicle.subid;
            payment.beaptransid = vehicle.beaptransid;
            payment.feaprequestid = vehicle.feapresponseid;
            return payment;
        }

        private static Order InitOrder(GasModel gasModel, Vehicle vehicle)
        {
            Order order = new Order();
            order.pumpstatus = EM_PumpStatus.NhacCo;
            order.timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            order.agastransid = gasModel.agastransid;
            order.pumpid = gasModel.pumpid;
            order.stationid = gasModel.stationid;
            order.price = gasModel.price;
            order.volume = gasModel.volume;
            order.amount = gasModel.amount;
            order.etag = vehicle.etag;
            order.platenumber = vehicle.platenumber;
            order.subid = vehicle.subid;
            order.plxid = vehicle.plxid;
            order.feaprequestid = vehicle.feapresponseid;
            return order;
        }
        private static async Task<modelDetech> DetectPlate(DateTime saveTime, string locationName)
        {
            try
            {
                modelDetech model = new modelDetech();
                if (!Directory.Exists(Application.StartupPath + "\\images"))
                //if(!Directory.Exists(StaticPool.pathImage + "\\images" + $"\\{locationName}"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\images");
                }
                Camera camera = new Camera();
                foreach (var item in StaticPool.listLocationConfig)
                {
                    if (item.LocationName == locationName)
                    {
                        camera = item.Camera;
                    }
                }

                model = await Capture_Task(camera, Application.StartupPath + "\\images", saveTime, locationName);
                //await task1;
                return model;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception DetectPlate ex = {ex}", LogHelperv2.SaveLogFolder);
                return new modelDetech();
            }
        }
        public static async Task<modelDetech> TestDetectPlate(DateTime saveTime, string locationName)
        {
            try
            {
                modelDetech model = new modelDetech();
                if (!Directory.Exists(Application.StartupPath + "\\TestImages"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\TestImages");
                }
                Camera camera = new Camera();
                foreach (var item in StaticPool.listLocationConfig)
                {
                    if (item.LocationName == locationName)
                    {
                        camera = item.Camera;
                    }
                }
                model = await TestCapture_Task(camera, Application.StartupPath + "\\TestImages", saveTime);
                return model;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception TestDetectPlate ex = {ex}", LogHelperv2.SaveLogFolder);
                return new modelDetech();
            }
        }
        private static async Task<modelDetech> Capture_Task(Camera camera, string imageFolder, DateTime eventTime, string locationName)
        {
            try
            {
                modelDetech model = new modelDetech();
                eventTime = DateTime.Now;   // Đặt lại thời gian để khi lưu ảnh ko bị trùng tên file ảnh (tên file ảnh là thời gian)
                var event_Info = await configs.Capture_Image(camera, imageFolder, eventTime);
                if (event_Info != null)
                {
                    // Lưu đường dẫn ảnh 
                    string ImgPath = event_Info._imgPath_LPR_Morning;

                    if (ImgPath != null && ImgPath != "")
                    {
                        //frm.Invoke(new Action(() =>
                        //{

                        foreach (var item in listUcLocation)
                        {
                            if (item.title == locationName)
                            {
                                item.SetImage(Image.FromFile(ImgPath));
                            }
                        }
                        //}));
                    }

                    // Recognize
                    model = await ExcecuteLprDetect(event_Info, camera, imageFolder, eventTime);
                    model.ImagePath = ImgPath;
                    if (!string.IsNullOrEmpty(event_Info._plate_Number1)) return model;
                    goto detectAgain;
                }
                else
                {
                    goto detectAgain;
                }
            detectAgain:
                {
                    current_LPR_Index++;

                    if (current_LPR_Index <= StaticPool.applicationConfig.CountDetect)
                    {
                        await Task.Delay(StaticPool.applicationConfig.TimeDelayDetect);
                        model = await Capture_Task(camera, imageFolder, eventTime, locationName);
                    }
                    else
                    {
                        current_LPR_Index = 0;
                    }
                }
                return model;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_API_Error($"Exception Capture_Task + {ex}", LogHelperv2.SaveLogFolder);
                return new modelDetech();
            }

        }
        private static async Task<modelDetech> TestCapture_Task(Camera camera, string imageFolder, DateTime eventTime)
        {
            try
            {
                modelDetech model = new modelDetech();
                var event_Info = await configs.Capture_Image(camera, imageFolder, eventTime);
                if (event_Info != null)
                {
                    // Lưu đường dẫn ảnh 
                    string ImgPath = event_Info._imgPath_LPR_Morning;

                    if (ImgPath != null && ImgPath != "")
                    {

                    }

                    // Recognize
                    model = await ExcecuteLprDetect(event_Info, camera, imageFolder, eventTime);
                    model.ImagePath = ImgPath;
                    if (!string.IsNullOrEmpty(event_Info._plate_Number1)) return model;
                    goto detectAgain;
                }
                else
                {
                    goto detectAgain;
                }
            detectAgain:
                {
                    current_LPR_Index++;
                    if (current_LPR_Index <= StaticPool.applicationConfig.CountDetect)
                    {
                        await Capture_Task(camera, imageFolder, eventTime, "");
                    }
                    else
                    {
                        current_LPR_Index = 0;
                    }
                }
                return model;
            }
            catch (Exception ex)
            {

                LogHelperv2.Logger_API_Error($"Exception Capture_Task + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return new modelDetech();
            }

        }
        private static async Task<modelDetech> ExcecuteLprDetect(Event_Info event_Info, Camera camera, string imageFolder, DateTime eventTime)
        {
            modelDetech model = new modelDetech();
            var task_1 = configs.Get_Car_PlateNumber(StaticPool.carANPR1, event_Info._imgPath_LPR_Morning);
            await task_1;

            // Plate Number 1
            event_Info._plate_Number1 = task_1.Result._plate_Number1;
            event_Info._plate_Number2 = task_1.Result._plate_Number2;
            event_Info._confidence1 = task_1.Result._confidence1;
            event_Info._confidence2 = task_1.Result._confidence2;
            event_Info.image_plateCut = task_1.Result._image_plateCut;

            if (event_Info._plate_Number1 != "")
            {
                event_Info.CameraIP = camera.VideoSource;
                //Excecute Auto Plate Number Detect Event
                model = ExcecutePlateNumDetectEvent(event_Info, camera);
                current_LPR_Index = 0;
            }
            return model;
        }
        private static modelDetech ExcecutePlateNumDetectEvent(Event_Info event_Info, Camera camera)
        {
            if (event_Info._plate_Number1 == "" || event_Info._confidence1 < 0.1) return null;

            modelDetech model = new modelDetech();
            model.PlateNumber = event_Info._plate_Number1;
            //plateNumber = event_Info._plate_Number1;
            return model;
        }

        //__GAS EVENT
        public static void UpdateView(Vehicle vehicle, EmPaymentStatus paymentStatus = EmPaymentStatus.DangThanhToan, string reasonFail = "")
        {
            // Update view chưa bao gồm kết quả hóa đơn
            frm.dgvAutoPaymentVehicle.Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in frm.dgvAutoPaymentVehicle.Rows)
                {
                    string a = StaticPool.StandardlizePlateNumber(row.Cells["dgvAutoPayment_plate"].Value.ToString());
                    string b = StaticPool.StandardlizePlateNumber(vehicle.platenumber);

                    if (row.Cells["IDVehicle"].Value.ToString() == vehicle.IDVehicle && StaticPool.StandardlizePlateNumber(row.Cells["dgvAutoPayment_plate"].Value.ToString()) ==
                        StaticPool.StandardlizePlateNumber(vehicle.platenumber) && (bool)row.Cells["isFinishPayment"].Value == false)
                    {
                        row.Cells["dgvAutoPayment_status"].Value = vehicle.GetDisplayStatus();
                        row.Cells["dgvAutoPayment_volume"].Value = vehicle.Volume.ToString();
                        row.Cells["dgvAutoPayment_amount"].Value = vehicle.Amount.ToString("N0");
                        row.Cells["Payment"].Value = vehicle.GetPaymentStatus(paymentStatus) + $"{reasonFail}";
                        row.Cells["Location"].Value = vehicle.LocationName;

                        if (paymentStatus == EmPaymentStatus.ThanhToanThanhCong || paymentStatus == EmPaymentStatus.ThanhToanThatBai || paymentStatus == EmPaymentStatus.HuyGiaoDich)
                        {
                            if (paymentStatus == EmPaymentStatus.ThanhToanThanhCong)
                            {
                                row.Cells["CreateInvoice"].Value = "Đang gửi hóa đơn...";
                            }
                            row.Cells["isFinishPayment"].Value = true;
                        }
                    }
                }
            }));
        }
        public static void UpdateViewHoaDon(Vehicle vehicle)
        {
            frm.dgvAutoPaymentVehicle.Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in frm.dgvAutoPaymentVehicle.Rows)
                {
                    if (row.Cells["IDVehicle"].Value.ToString() == vehicle.IDVehicle)
                    {
                        if (vehicle.createInvoiceResponse.statuscode == "00")
                        {
                            row.Cells["CreateInvoice"].Value = "Thành công";
                        }
                        else
                        {
                            row.Cells["CreateInvoice"].Value = $"Thất bại - {vehicle.createInvoiceResponse.reason}";
                        }
                    }
                }
            }));
        }
        public static void UpdateViewError(Vehicle vehicle, string textError)
        {
            frm.dgvAutoPaymentVehicle.Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in frm.dgvAutoPaymentVehicle.Rows)
                {
                    if (row.Cells["IDVehicle"].Value.ToString() == vehicle.IDVehicle && StaticPool.StandardlizePlateNumber(row.Cells["dgvAutoPayment_plate"].Value.ToString()) ==
                        StaticPool.StandardlizePlateNumber(vehicle.platenumber) && (bool)row.Cells["isFinishPayment"].Value == false)
                    {
                        row.Cells["dgvAutoPayment_status"].Value = vehicle.GetDisplayStatus();
                        row.Cells["dgvAutoPayment_volume"].Value = vehicle.Volume.ToString();
                        row.Cells["dgvAutoPayment_amount"].Value = vehicle.Amount.ToString();
                        row.Cells["Payment"].Value = textError;
                        row.Cells["isFinishPayment"].Value = true;
                        row.Cells["Location"].Value = vehicle.LocationName;
                    }
                }
            }));
        }
        #endregion

        private static LicensePlateCollection GetBestResult(PlateReaderResult plateReaderResult)
        {
            try
            {
                LicensePlateCollection licensePlateList = new LicensePlateCollection();
                var bestplate = new LicensePlate();

                if (plateReaderResult.Results != null)
                {
                    foreach (var result in plateReaderResult.Results)
                    {
                        LicensePlate plate = new LicensePlate();
                        plate.Text = result.Plate.ToUpper();

                        plate.ConfidenceLevel = (float)result.Dscore;

                        if (result.Dscore > bestplate.ConfidenceLevel)
                            bestplate = plate;

                        licensePlateList.Add(plate);
                    }
                    licensePlateList.Maxcalls = plateReaderResult.usage.Max_calls;
                    licensePlateList.QueryTimes = plateReaderResult.usage.Calls;
                }

                licensePlateList.Add(bestplate);
                return licensePlateList;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception GetBestResult ex = {ex}", LogHelperv2.SaveLogFolder);
                return null;
            }
        }

        public event OnEvent onEvent;
        private async void button1_Click(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    MT116Controller.MT116EventArgs eventArgs = new MT116Controller.MT116EventArgs();

            //    // Gọi trực tiếp phương thức sự kiện Controller_onEvent
            //    eventArgs.CardNumber = "3416214B880E700001941070";
            //    Controller_onEvent(this, eventArgs);
            //    await Task.Delay(500);
            //}

            frmFakeEtag frm = new frmFakeEtag();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MT116Controller.MT116EventArgs eventArgs = new MT116Controller.MT116EventArgs();

                // Gọi trực tiếp phương thức sự kiện Controller_onEvent
                //eventArgs.CardNumber = "3416214B880E700001941070";

                eventArgs.CardNumber = frm.Etag;
                Controller_onEvent(this, eventArgs);
            }
        }



        private void dgvNotRegisted_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                if (i % 2 == 0) // Hàng chẵn
                {
                    dgvNotRegisted.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else // Hàng lẻ
                {
                    dgvNotRegisted.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    //dgvNotRegisted.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }

        private void ToolStripBaoCao_Click(object sender, EventArgs e)
        {
            frmReportVehiceRegisted f = new frmReportVehiceRegisted();
            f.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    dgvNotRegisted.Rows.Clear();
            //}
            dgvNotRegisted.Rows.Clear();

        }

        private async void btnTestAPI_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận test api CreateInvoice", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Payment payment = new Payment();
                payment.agastransid = "68009951716566301";
                payment.volume = 3;
                payment.price = 23470;
                payment.amount = 70410;
                payment.platenumber = "29A2-12345";

                PaymentResponse paymentResponse = new PaymentResponse();
                paymentResponse.partnercode = "VETC";
                paymentResponse.bankcode = "VETC";

                // Gửi Request tạo hóa đơn đến AGAS
                if (!await FISHelper.CreateInvoice(payment, paymentResponse, new Vehicle()))
                {
                    AddDGVEventError("feapcreateinvoice", "test " + MLS.GacCo.FeapCreateInvoice, "Test");
                }
                else
                {
                    AddDGVEventError("feapcreateinvoice", "Test api CreateInvoice thành công", "Test");
                }
            }
        }
        private void ToolStripThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát phần mềm", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;

            //if (gasModelQueue.TryDequeue(out GasModel gasModel))
            //{
            //    await UpdateGasEvent(gasModel);
            //}

            //timer1.Enabled = true;
        }
        private void InitializeTimer(string locationName, ConcurrentQueue<GasModel> gasModelQueue)
        {
            Timer timer = new Timer();
            timer.Interval = 100;

            // Gán sự kiện Tick cho timer
            timer.Tick += (sender, e) => TimerTickHandler(sender, e, locationName, gasModelQueue);

            timer.Start();

            locationTimerDictionary.Add(locationName, timer);
        }

        private async void TimerTickHandler(object sender, EventArgs e, string locationName, ConcurrentQueue<GasModel> gasModelQueue)
        {
            Timer timer = (Timer)sender;

            timer.Enabled = false;

            if (gasModelQueue.TryDequeue(out GasModel gasModel))
            {
                await UpdateGasEvent(gasModel, locationName);
                await Task.Delay(10000);
            }

            timer.Enabled = true;
        }

        private async void btnTestDetect_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            modelDetech model = await TestDetectPlate(DateTime.Now, cbbDetechTest.Text);
            string abc = model.PlateNumber;
            LogHelperv2.Logger_CONTROLLER_Infor($"----------> Nhận test nhận diện plate: {model.PlateNumber}, imgPath : {model.ImagePath}", LogHelperv2.SaveLogFolder);

            frmTestPlate frm = new frmTestPlate(model.ImagePath, model.PlateNumber);
            frm.Show();
        }

        private void timeClearList_Tick(object sender, EventArgs e)
        {
            Vehicle vehicle_remove = new Vehicle();
            if (StaticPool.vehicleWithAutoPayments.GetVehicleIfOverTime(StaticPool.applicationConfig.TimeClearList, ref vehicle_remove))
            {
                DeleteViewAndListEtag(vehicle_remove);
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Vehicle vehicle = new Vehicle() { VehicleStatus = Vehicle.EmVehicleStatus.ChoVaoViTriDoXang, platenumber = $"{textBox1.Text}", etag = $"{textBox1.Text}" };
        //    string etag = textBox1.Text;
        //    AddDGVEtag(etag, vehicle);

        //    foreach (Vehicle item in StaticPool.vehicleWithAutoPayments)
        //    {
        //        dgvAutoPaymentVehicle.Rows.Add(vehicle.IDVehicle, dgvAutoPaymentVehicle.Rows.Count + 1, DateTime.Now, item.platenumber, item.GetDisplayStatus(), 0, 0, "", "", false);
        //    }
        //}
    }
}