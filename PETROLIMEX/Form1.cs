using CardDispenserLibrary;
using Futech.LPR;
using Kztek.Cameras;
using Kztek.LPR;
using iPGSTools.Models;
using iPGSTools.Usercontrols;
using static iPGSTools.Models.GasModel;
using static CardDispenserLibrary.MT116Controller;
using static iPGSTools.Models.QueryEtagResponse;
using iPGSTools.Helper;
using static iPGSTools.Models.Vehicle;
using iPGSTools.Databases;
using PETROLIMEX.Forms;
using PETROLIMEX;
using System.Collections.Concurrent;
using PETROLIMEX.Helper;
using static iPGSTools.Helper.MLS;
//using iPGS.Tools;

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
        private static int takeImage = 0;
        private static string plateNumber = string.Empty;
        private static string ImgPath = string.Empty;
        #endregion

        public static ConcurrentQueue<GasModel> gasModelQueue = new ConcurrentQueue<GasModel>();
        private bool IsEnableAutoOpenApp = true;
        enum EmCamera
        {
            Tyandy,
            Dahua,
            Hanse,
            Hello
        }
        #region Forms
        public Form1()
        {
            try
            {
                InitializeComponent();
                frm = this;

                //StaticPool.vehicleWithAutoPayments.Add(new Vehicle() { VehicleStatus = Vehicle.EmVehicleStatus.ChoVaoViTriDoXang, platenumber = "38P105694" });

                //foreach (Vehicle item in StaticPool.vehicleWithAutoPayments)
                //{
                //    dgvAutoPaymentVehicle.Rows.Add(vehicle.IDVehicle, dgvAutoPaymentVehicle.Rows.Count + 1, DateTime.Now, item.platenumber, item.GetDisplayStatus(), 0, 0, "", "", false);
                //}
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Form1 ex = {ex}", LogHelperv2.SaveLogFolder);
            }

        }

        //public static bool CheckRangeOfNetwork(string txtIP)
        //{
        //    IEnumerable<string> ips = NetWorkTools.GetLocalIPAddress();
        //    bool isFound = false;
        //    foreach (string ipv4 in ips)
        //    {
        //        string[] splitIpv4 = ipv4.Split('.');
        //        if (txtIP.IpBox1 == splitIpv4[0] && txtIP.IpBox2 == splitIpv4[1] && txtIP.IpBox3 == splitIpv4[2])
        //        {
        //            isFound = true;
        //            break;
        //        }
        //        else continue;
        //    }

        //    return isFound;
        //}

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
                panelCamera.SizeChanged += panelCamera_SizeChanged;
                //StartAPIServer
                //ConnectCamera
                StaticPool.camera = new Kztek.Cameras.Camera()
                {
                    ID = "1",
                    Name = "Camera",
                    VideoSource = StaticPool.applicationConfig.CameraIP,
                    HttpPort = 80,
                    ServerPort = 80,
                    Chanel = 1,
                    Login = StaticPool.applicationConfig.CameraUsername,
                    Password = StaticPool.applicationConfig.CameraPassword,
                    //CameraType = CameraTypes.GetType("Dahua"),
                    CameraType = CameraTypes.GetType(EmCamera.Dahua.ToString()),

                    StreamType = StreamTypes.GetType("H264"),
                    Resolution = "1280x720",
                    UsingPlugins = 0,
                };
                Camera camera = new Camera();
                camera.ID = "1";
                camera.Name = "Camera";
                camera.VideoSource = "192.168.20.98"; //StaticPool.applicationConfig.CameraIP;
                camera.HttpPort = 80;
                camera.ServerPort = 80;
                camera.Chanel = 1;
                camera.Login = "admin";//StaticPool.applicationConfig.CameraUsername;
                camera.Password = "admin";//StaticPool.applicationConfig.CameraPassword;
                camera.CameraType = CameraTypes.GetType(EmCamera.Hanse.ToString());
                camera.StreamType = StreamTypes.GetType("H264");
                camera.Resolution = "1280x720";
                camera.UsingPlugins = 0;

                StaticPool.listCamera = new List<Camera>();
                StaticPool.listCamera.Add(StaticPool.camera);
                StaticPool.listCamera.Add(camera);

                ucCameraView ucCam = new();

                StartCameraView(ucCam);
                LogHelperv2.Logger_SystemInfor($"Load Camera thành công", LogHelperv2.SaveLogFolder);

                CreateLPREngine();
                Task.Run(() =>
                {
                    FISHelper.StartPollingAuthorize();
                });

                if (ConnectCardReader())
                {
                    LogHelperv2.Logger_SystemInfor($"ConnectCardReader thành công", LogHelperv2.SaveLogFolder);

                    controller.onEvent += Controller_onEvent;
                    controller.PollingStart();
                }
                InitDataGridView();

                // Chờ load các thao tác trên hoàn thành
                await Task.Delay(5000);
                try
                {
                    CreateHostBuilder().Build().RunAsync();
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Exception CreateHostBuilder ex = {ex}", LogHelperv2.SaveLogFolder);
                    MessageBox.Show(ex.Message);
                }
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
                if (!NetWorkTools.IsPingSuccess(StaticPool.applicationConfig.ControllerIP, 100))
                {
                    MessageBox.Show("Không Thể Ping Đến Thiết Bị, Hãy Kiểm Tra Lại", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                controller = ICardDispenserFactory.GetCardDispenser(EM_CardDispenser.v5);
                controller.ControllerInfor.IpAddress = StaticPool.applicationConfig.ControllerIP;   // 1. 250
                controller.ControllerInfor.Comport = StaticPool.applicationConfig.ControllerIP;
                controller.ControllerInfor.Port = StaticPool.applicationConfig.ControllerPort;
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
        private static IHostBuilder CreateHostBuilder() =>
         Host.CreateDefaultBuilder()
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseUrls("http://*:" + StaticPool.applicationConfig.ApiPort);// 
                 string a = StaticPool.applicationConfig.ApiPort.ToString();
                 webBuilder.UseStartup<Startup>();
             });
        private void StartCameraView(ucCameraView ucCamera)
        {
            try
            {
                panelCamera?.Invoke(new Action(() =>
                {
                    panelCamera.Controls.Add(ucCamera);
                    ucCamera?.Invoke(() =>
                    {
                        ucCamera.StartViewer(StaticPool.listCamera[1], CameraErrorFunc, CameraDoubleClickFunc);
                    });
                }));
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception StartCameraView ex: {ex}", LogHelperv2.SaveLogFolder);
                MessageBox.Show($"Exception StartCameraView: {ex}");
            }

        }
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
                string stationid = StaticPool.applicationConfig.StationID;

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
                    AddDGVEventError("Etag: " + etag, MLS.Etag.APIQueryEtagFail);
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
        public static async Task UpdateGasEvent(GasModel gasModel)
        {
            try
            {
                LogHelperv2.Logger_CONTROLLER_Infor($"=>>>>>>>>>>>> Nhận sự kiện Agas, Sự kiện Agas chờ có số lượng: {gasModelQueue.Count}", LogHelperv2.SaveLogFolder, gasModel);
                string IDAgas = Guid.NewGuid().ToString();      // IDAgas khác AgastransID

                //Take Plate
                await RecognPlate(gasModel);

                // lưu sự kiện Agas vào db
                if (!MyQuery.InsertQueryAgas(gasModel, IDAgas, ImgPath))
                {
                    LogHelperv2.Logger_CONTROLLER_Infor("=>>>>>>>>>>>> Lưu vào db QueryAgas thất bại", LogHelperv2.SaveLogFolder, gasModel);

                    // Lưu lỗi vào tblLog
                    MyQuery.InsertLog(EmTypeLog.LogError, MLS.Agas.InserttblAgasFail, IDAgas, "");
                }

                //Kiểm tra danh sách xe tích hợp thanh toán tự động có xe đang đổ xăng hay không
                if (StaticPool.vehicleWithAutoPayments.IsContainPlate(plateNumber))
                {
                    LogHelperv2.Logger_CONTROLLER_Infor($"So sánh biển số thành công: {plateNumber} - Biển số có nằm trong danh sách chờ eTag", LogHelperv2.SaveLogFolder);

                    // Lấy phương tiện ứng vs BS
                    Vehicle vehicle = StaticPool.vehicleWithAutoPayments.GetVehicleByPlate(plateNumber);
                    vehicle.IDAgas = IDAgas;
                    vehicle.TimeAgas = DateTime.Now;

                    switch (gasModel.pumpstatus)
                    {
                        case (int)EM_PumpStatus.NhacCo:
                            {
                                vehicle.VehicleStatus = Vehicle.EmVehicleStatus.NhacCo;
                                vehicle.isNhacCo = true;
                                vehicle.pumpid = gasModel.pumpid;
                                vehicle.Price = gasModel.price;
                                vehicle.Volume = 0;
                                vehicle.Amount = 0;
                                vehicle.ImgPathPickup = ImgPath;

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

                                    AddDGVEventError("Create Order", MLS.NhacCo.APICreateOrderFail);

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
                            vehicle.ImgPathPumping = ImgPath;

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
                                    AddDGVEventError($"Biển số {plateNumber}", MLS.BopCo.BomXangSaiQuyTrinh);

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
                                AddDGVEventError($"Biển số {plateNumber}", MLS.BopCo.BomXangSaiVoi);

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
                                vehicle.ImgPathPutdown = ImgPath;

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

                                                UpdateView(vehicle, EmPaymentStatus.ThanhToanThatBai);
                                                DeleteViewAndListEtag(vehicle);

                                                AddDGVEventError("Payment Fail", MLS.GacCo.APIPaymentFail);
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
                                                    await Send_API_Result_To_Agas(IDAgas, vehicle, payment, paymentResponse);


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
                                        AddDGVEventError($"Biển số {plateNumber}", MLS.GacCo.GacCoError);

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
                                vehicle.ImgPathCancel = ImgPath;
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

                    if (!MyQuery.CheckProcessError(plateNumber))
                    {

                    }

                    switch (gasModel.pumpstatus)
                    {
                        case (int)EM_PumpStatus.NhacCo:
                            // lưu db trạng thái nhấc cò
                            if (!MyQuery.InsertMainEventNotRegisted(gasModel, plateNumber, IDAgas, ImgPath))
                            {
                                //
                            }
                            break;

                        case (int)EM_PumpStatus.BopCo:
                            // Tạm thời không check trạng thái đã nhấc cò chưa với xe chưa đăng ký
                            if (!MyQuery.UpdateMainEventNotRegisted_BopCo(gasModel, plateNumber, IDAgas, ImgPath))
                            {
                                //
                            }

                            break;
                        case (int)EM_PumpStatus.GacCo:
                            if (!MyQuery.UpdateMainEventNotRegisted_GacCo(gasModel, plateNumber, IDAgas, ImgPath))
                            {
                                //
                            }
                            break;

                        case (int)EM_PumpStatus.HuyGiaoDich:
                            if (!MyQuery.UpdateMainEventNotRegisted_HuyGiaoDich(gasModel, plateNumber, IDAgas, ImgPath))
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
                        if (nameEvent.Contains(plateNumber))
                        {
                            return;
                        }
                    }
                    AddDGVEventError(plateNumber, MLS.Plate.ComparePlateFail);

                }
                //Update view
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception UpdateGasEvent ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private static async Task Send_API_Result_To_Agas(string IDAgas, Vehicle vehicle, Payment payment, PaymentResponse? paymentResponse)
        {
            try
            {
                // Gửi Log kết quả đến AGAS
                if (!await FISHelper.AutoPaymentLog(payment, paymentResponse))
                {
                    AddDGVEventError("AutoPaymentLog", MLS.GacCo.APILogPaymentFail);
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
                    AddDGVEventError("feapcreateinvoice", MLS.GacCo.FeapCreateInvoice);
                }
                else
                {
                    AddDGVEventError("FeapCreateInvoice", "Gửi hóa đơn CreateInvoice thành công");
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
                    if (dgvAutoPaymentVehicle.Rows.Count > 20)
                    {
                        dgvAutoPaymentVehicle.Rows.RemoveAt(0);
                    }
                    int rowIndex = dgvAutoPaymentVehicle.Rows.Add(vehicle.IDVehicle, dgvAutoPaymentVehicle.Rows.Count + 1, DateTime.Now, vehicle.platenumber, vehicle.GetDisplayStatus(), 0, 0, "", "", false);

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
        private static void AddDGVEventError(string nameEventError, string statusError)
        {
            frm.dgvEventError?.Invoke(new Action(() =>
            {
                if (frm.dgvEventError.Rows.Count > 100)
                {
                    frm.dgvEventError.Rows.RemoveAt(0);
                }

                int rowIndex = frm.dgvEventError.Rows.Add(frm.dgvEventError.Rows.Count + 1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), nameEventError, statusError);
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

        private static async Task RecognPlate(GasModel gasModel)
        {
            try
            {
                plateNumber = "";

                DateTime saveTime = DateTime.Now;

                if (!String.IsNullOrEmpty(StaticPool.applicationConfig.LPR_API))
                {
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
                                    plateNumber = results[results.Count - 1].Text;
                                else
                                    plateNumber = string.Empty;
                            }
                            else
                            {
                                plateNumber = string.Empty;
                            }
                        }
                        else
                        {
                            plateNumber = string.Empty;
                        }
                    }
                    else
                    {
                        plateNumber = string.Empty;
                    }
                }
                else
                {
                    await DetectPlate(saveTime);
                }

                plateNumber = StaticPool.StandardlizePlateNumber(plateNumber);

                 //Fix cung BS
                //if (gasModel.agastransid == "170515757628251057")
                //{
                //    plateNumber = "30H35392";

                //}
                //else
                //{
                //    plateNumber = "30A12716";
                //}

                if (string.IsNullOrEmpty(plateNumber) || plateNumber == "")
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Đọc biển số thất bại với sự kiện agastranid sau: {gasModel.agastransid}", LogHelperv2.SaveLogFolder);
                    AddDGVEventError("Plate Fail", MLS.Plate.ReadPlateFail);
                    // Biển số rỗng vẫn lưu là sự kiện đổ xăng với xe không đăng ký -> ko return
                    //return;
                }
                LogHelperv2.Logger_CONTROLLER_Infor($"Đọc thành công biển số: {plateNumber} với sự kiện agastranid sau: {gasModel.agastransid}", LogHelperv2.SaveLogFolder);
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception RecognPlate ex = {ex}", LogHelperv2.SaveLogFolder);
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
        private static async Task DetectPlate(DateTime saveTime)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\images"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\images");
                }
                Task task1 = Capture_Task(StaticPool.listCamera[1], Application.StartupPath + "\\images", saveTime);
                await task1;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception DetectPlate ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }
        private static async Task TestDetectPlate(DateTime saveTime)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\TestImages"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\TestImages");
                }
                Task task1 = TestCapture_Task(StaticPool.listCamera[1], Application.StartupPath + "\\TestImages", saveTime);
                await task1;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception TestDetectPlate ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }
        private static async Task Capture_Task(Camera camera, string imageFolder, DateTime eventTime)
        {
            try
            {
                eventTime = DateTime.Now;   // Đặt lại thời gian để khi lưu ảnh ko bị trùng tên file ảnh (tên file ảnh là thời gian)
                var event_Info = await configs.Capture_Image(camera, imageFolder, eventTime);
                if (event_Info != null)
                {
                    // Lưu đường dẫn ảnh 
                    ImgPath = event_Info._imgPath_LPR_Morning;

                    if (ImgPath != null && ImgPath != "")
                    {
                        frm.Invoke(new Action(() =>
                        {
                            frm.pictureBox1.Image = Image.FromFile(ImgPath);
                        }));
                    }

                    // Recognize
                    await ExcecuteLprDetect(event_Info, camera, imageFolder, eventTime);
                    if (!string.IsNullOrEmpty(event_Info._plate_Number1)) return;
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
                        await Capture_Task(camera, imageFolder, eventTime);
                    }
                    else
                    {
                        current_LPR_Index = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_API_Error($"Exception Capture_Task + {ex}", LogHelperv2.SaveLogFolder);
            }

        }
        private static async Task TestCapture_Task(Camera camera, string imageFolder, DateTime eventTime)
        {
            try
            {
                var event_Info = await configs.Capture_Image(camera, imageFolder, eventTime);
                if (event_Info != null)
                {
                    // Lưu đường dẫn ảnh 
                    ImgPath = event_Info._imgPath_LPR_Morning;

                    if (ImgPath != null && ImgPath != "")
                    {

                    }

                    // Recognize
                    await ExcecuteLprDetect(event_Info, camera, imageFolder, eventTime);
                    if (!string.IsNullOrEmpty(event_Info._plate_Number1)) return;
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
                        await Capture_Task(camera, imageFolder, eventTime);
                    }
                    else
                    {
                        current_LPR_Index = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                LogHelperv2.Logger_API_Error($"Exception Capture_Task + {ex.ToString()}", LogHelperv2.SaveLogFolder);
            }

        }
        private static async Task ExcecuteLprDetect(Event_Info event_Info, Camera camera, string imageFolder, DateTime eventTime)
        {
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
                ExcecutePlateNumDetectEvent(event_Info, camera);
                current_LPR_Index = 0;
            }
        }
        private static void ExcecutePlateNumDetectEvent(Event_Info event_Info, Camera camera)
        {
            if (event_Info._plate_Number1 == "" || event_Info._confidence1 < 0.1) return;
            plateNumber = event_Info._plate_Number1;
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

                    if (StaticPool.StandardlizePlateNumber(row.Cells["dgvAutoPayment_plate"].Value.ToString()) ==
                        StaticPool.StandardlizePlateNumber(vehicle.platenumber) && (bool)row.Cells["isFinishPayment"].Value == false)
                    {
                        row.Cells["dgvAutoPayment_status"].Value = vehicle.GetDisplayStatus();
                        row.Cells["dgvAutoPayment_volume"].Value = vehicle.Volume.ToString();
                        row.Cells["dgvAutoPayment_amount"].Value = vehicle.Amount.ToString("N0");
                        row.Cells["Payment"].Value = vehicle.GetPaymentStatus(paymentStatus) + $"{reasonFail}";

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
                    if (StaticPool.StandardlizePlateNumber(row.Cells["dgvAutoPayment_plate"].Value.ToString()) ==
                        StaticPool.StandardlizePlateNumber(vehicle.platenumber) && (bool)row.Cells["isFinishPayment"].Value == false)
                    {
                        row.Cells["dgvAutoPayment_status"].Value = vehicle.GetDisplayStatus();
                        row.Cells["dgvAutoPayment_volume"].Value = vehicle.Volume.ToString();
                        row.Cells["dgvAutoPayment_amount"].Value = vehicle.Amount.ToString();
                        row.Cells["Payment"].Value = textError;
                        row.Cells["isFinishPayment"].Value = true;
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
                    AddDGVEventError("feapcreateinvoice", "test " + MLS.GacCo.FeapCreateInvoice);
                }
                else
                {
                    AddDGVEventError("feapcreateinvoice", "Test api CreateInvoice thành công");
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
            timer1.Enabled = false;

            if (gasModelQueue.TryDequeue(out GasModel gasModel))
            {
                await UpdateGasEvent(gasModel);
            }

            timer1.Enabled = true;
        }

        private async void btnTestDetect_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            await TestDetectPlate(DateTime.Now);
            string abc = plateNumber;
            LogHelperv2.Logger_CONTROLLER_Infor($"----------> Nhận test nhận diện plate: {plateNumber}, imgPath : {ImgPath}", LogHelperv2.SaveLogFolder);

            frmTestPlate frm = new frmTestPlate(ImgPath, plateNumber);
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