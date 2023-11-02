using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Futech.LPR;
using iPGS.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PETROLIMEX;
using PETROLIMEX.Models;
using RestSharp;
using System.Net.Sockets;
using System.Text;

namespace iPGSTools.Models
{
    public class FISHelper
    {
        public static string token = "";
        public static CancellationTokenSource cts;
        private static string urlPetrolimex = StaticPool.applicationConfig.AGAS_URl;                //"http://192.168.1.100:2068/api/PaymentLog/AutoPaymentLog";
        private static string Host_InvoiceAgas = StaticPool.applicationConfig.Host_CreateInvoice;    //"192.168.1.100:8088"  -  14.232.215.179:900;
        private static int Port_InvoiceAgas = StaticPool.applicationConfig.Port_CreateInvoice;       // 900

        public static async void StartPollingAuthorize()
        {
            cts = new CancellationTokenSource();
            PollingAuthorize(cts.Token);
        }
        public static async void StopPollingAuthorize()
        {
            cts?.Cancel();
        }
        private static async Task PollingAuthorize(CancellationToken ctsToken)
        {
            while (!ctsToken.IsCancellationRequested)
            {
                try
                {
                    var response = await Authorize();
                    if (!string.IsNullOrEmpty(response))
                    {
                        token = response;
                    }
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_API_Error($"PollingAuthorize Exception: " + ex, LogHelperv2.SaveLogFolder);
                }
                finally
                {
                    GC.Collect();
                    await Task.Delay(60 * 1000, ctsToken);
                }
            }
        }
        public static async Task<string> Authorize()
        {
            try
            {
                //string url = Properties.Settings.Default.fis_url + "/" + "queryEtag";
                string url = "http://petrolimex-hub.petrolimex.com.vn:7073/petro/login";

                AuthorizeModel author = new AuthorizeModel();

                Dictionary<string, string> headerValues = new Dictionary<string, string>()
                {
                    {"Authorization", $"Basic {author.tokenLogin}"},
                    {"Content-Type", "application/x-www-form-urlencoded"},
                };

                var loginData = new Dictionary<string, string>
                {
                    { "username", author.username },
                    { "password", author.password }
                };
                
                LogHelperv2.Logger_API_Infor("Send Login", LogHelperv2.SaveLogFolder, loginData);

                
                var result = await GeneralJsonAPILogin(url, loginData, headerValues, new Dictionary<string, string>(), 10000, RestSharp.Method.POST);
                
                if (result.IsSuccessful)
                {
                    try
                    {
                        var responseContent = JsonConvert.DeserializeObject<ResponseModel<object>>(result.Content);

                        LogHelperv2.Logger_API_Infor("Login thành công received: " + result.Content, LogHelperv2.SaveLogFolder, loginData);

                        string token = responseContent.data.ToString();
                        
                        return token;

                    }
                    catch (Exception)
                    {
                        LogHelperv2.Logger_API_Error($"Login Exception: " + result.Content, LogHelperv2.SaveLogFolder, loginData);

                        return null;
                    }
                }
                else
                {
                    LogHelperv2.Logger_API_Error($"Login Exception: " + result.Content, LogHelperv2.SaveLogFolder, loginData);
                }
                return null;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Authorize ex = {ex}", LogHelperv2.SaveLogFolder);
                return null;
            }
        }
        public static async Task<Vehicle> QueryEtag(string _etag, string _etagId, string _feapRequestId, string _stationId)
        {
            var etagData = new
            {
                etag = _etag,
                etagid = _etagId,
                feaprequestid = _feapRequestId,
                stationid = _stationId,
            };
            
            string url = StaticPool.applicationConfig.FIS_URL + "/" + "queryEtag";

            Dictionary<string, string> headerValues = new Dictionary<string, string>()
            {
                {"Authorization", $"Bearer {token}"},
            };
            LogHelperv2.Logger_API_Infor("Send QueryEtag11", LogHelperv2.SaveLogFolder, etagData);

            var result = await ApiHelper.ApiHelpers.GeneralJsonAPI(url, etagData, headerValues, new Dictionary<string, string>(), 10000, RestSharp.Method.POST);
            if (result.IsSuccessful)
            {
                try
                {
                    LogHelperv2.Logger_API_Infor("QueryEtag thành công received11: " + result.Content, LogHelperv2.SaveLogFolder, etagData);

                    var responseContent = JsonConvert.DeserializeObject<ResponseModel<object>>(result.Content);


                    if (responseContent.message != "Success")
                    {
                        LogHelperv2.Logger_API_Error($"QueryEtag error11: " + result.Content, LogHelperv2.SaveLogFolder, etagData);

                        return null;
                    }

                    QueryEtagResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<QueryEtagResponse>(responseContent.data.ToString());

                    if(response.autopayment != null)
                    {
                        Vehicle vehicle = new Vehicle();
                        vehicle.etag = response.etag;
                        vehicle.etagControllerID = _etagId;
                        vehicle.platenumber = response.platenumber;
                        vehicle.subid = response.subid;
                        vehicle.plxid = response.plxid;
                        vehicle.autopayment = response.autopayment;
                        vehicle.feapresponseid = response.feapresponseid;

                        return vehicle;
                    }
                    else
                    {
                        return null;
                    }

                    
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_API_Error($"QueryEtag Exception 11: {ex.ToString()} " + result.Content, LogHelperv2.SaveLogFolder, etagData);

                    return null;
                }
            }
            LogHelperv2.Logger_API_Error($"QueryEtag fail11: " + result.Content, LogHelperv2.SaveLogFolder, etagData);
            return null;
        }

        public static async Task<OrderResponse> CreateOrder(Order orderData)
        {
            string createOrderUrl = StaticPool.applicationConfig.FIS_URL + "/"+ "createOrder";

            Dictionary<string, string> headerValues = new Dictionary<string, string>()
            {
                {"Authorization", $"Bearer {token}"},
            };
            LogHelperv2.Logger_API_Infor("Send CreateOrder", LogHelperv2.SaveLogFolder, orderData);

            var result = await ApiHelper.ApiHelpers.GeneralJsonAPI(createOrderUrl, orderData, headerValues, new Dictionary<string, string>(), 10000, RestSharp.Method.POST);
            if (result.IsSuccessful)
            {
                try
                {
                    LogHelperv2.Logger_API_Infor("CreateOrder thành công received: " + result.Content, LogHelperv2.SaveLogFolder, orderData);

                    var responseContent = JsonConvert.DeserializeObject<ResponseModel<object>>(result.Content);

                    if (responseContent.message != "Success")
                    {
                        return null;
                    }

                    OrderResponse orderResponse = JsonConvert.DeserializeObject<OrderResponse>(responseContent.data.ToString());
                    return orderResponse;
                }
                catch (Exception)
                {
                    LogHelperv2.Logger_API_Error("CreateOrder Exception: " + result.Content, LogHelperv2.SaveLogFolder, orderData);
                    return null ;
                }
            }
            LogHelperv2.Logger_API_Error("CreateOrder error: " + result.Content, LogHelperv2.SaveLogFolder, orderData);

            return null;
        }

        public static async Task<PaymentResponse> Payment(Payment paymentData)
        {
            string paymentApiUrl = StaticPool.applicationConfig.FIS_URL + "/" + "payment";

            LogHelperv2.Logger_API_Infor("Send payment"+ Newtonsoft.Json.JsonConvert.SerializeObject(paymentData), LogHelperv2.SaveLogFolder);
            
            Dictionary<string, string> headerValues = new Dictionary<string, string>()
            {
                {"Authorization", $"Bearer {token}"},
            };


            var result = await ApiHelper.ApiHelpers.GeneralJsonAPI(paymentApiUrl, paymentData, headerValues, new Dictionary<string, string>(), 90000, RestSharp.Method.POST);
            if (result.IsSuccessful)
            {
                try
                {
                    LogHelperv2.Logger_API_Infor("payment thành công received: " + result.Content, LogHelperv2.SaveLogFolder, paymentData);

                    var responseContent = JsonConvert.DeserializeObject<ResponseModel<object>>(result.Content);

                    if (responseContent.message != "Success")
                    {
                        LogHelperv2.Logger_API_Error("payment error: " + result.Content, LogHelperv2.SaveLogFolder, paymentData);
                        return null;   
                    }

                    PaymentResponse paymentResponse = JsonConvert.DeserializeObject<PaymentResponse>(responseContent.data.ToString());
                    return paymentResponse;
                }
                catch (Exception)
                {
                    LogHelperv2.Logger_API_Error("payment Exception: " + result.Content, LogHelperv2.SaveLogFolder, paymentData);

                    return null;
                }
            }
            else
            {
                LogHelperv2.Logger_API_Error("payment error: " + result.Content, LogHelperv2.SaveLogFolder, paymentData);
                return null;
            }
        }
        // api gửi kết quả thanh toán cho agas
        public static async Task<bool> AutoPaymentLog(Payment payment, PaymentResponse paymentResponse)
        {
            AgasLogAutopayment logAutoPayment = new AgasLogAutopayment();
            if(paymentResponse != null)
            {
                logAutoPayment.agastransid = payment.agastransid;
                logAutoPayment.transidautopayment = payment.beaptransid;
                logAutoPayment.timestamp = payment.timestamp;
                logAutoPayment.pumpid = payment.pumpid;
                logAutoPayment.stationid = payment.stationid;
                logAutoPayment.price = payment.price.ToString();
                logAutoPayment.volume = payment.volume.ToString();
                logAutoPayment.amount = payment.amount.ToString();
                logAutoPayment.etag = payment.etag;
                logAutoPayment.platenumber = payment.platenumber;
                logAutoPayment.plxid = payment.plxid;
                logAutoPayment.subid = payment.subid;
                logAutoPayment.paymenttype = paymentResponse.paytype;
                logAutoPayment.partnercode = paymentResponse.partnercode;
                logAutoPayment.bankcode = paymentResponse.bankcode;
                logAutoPayment.paymenthash = paymentResponse.payhash;
            }

            string petrolimexUrl = urlPetrolimex;
            var result = await ApiHelper.ApiHelpers.GeneralJsonAPI(petrolimexUrl, logAutoPayment, new Dictionary<string, string>(), new Dictionary<string, string>(), 10000, RestSharp.Method.POST);


            if (result.IsSuccessful)
            {
                LogHelperv2.Logger_API_Infor("Gửi kết quả đến agas thành công received: " + result.Content, LogHelperv2.SaveLogFolder, logAutoPayment);
                return true;
            }
            else
            {
                LogHelperv2.Logger_API_Error("Gửi kết quả đến agas thất bại Error: " + result.Content, LogHelperv2.SaveLogFolder, logAutoPayment);
                return false;
            }
        }
        /// Dùng Using sẽ tự giải phóng client, nếu ko dùng using thì cần try catch finally để close client
        public static async Task<bool> CreateInvoice(Payment payment, PaymentResponse paymentResponse)
        {
            LogHelperv2.Logger_LPR_Infor($"Bắt đầu gửi hóa đơn CreateInvoice với Host: {Host_InvoiceAgas}, Port: {Port_InvoiceAgas} ", LogHelperv2.SaveLogFolder);

            AgasCreateInvoice agasCreateInvoice = CreatInvoiceModel(payment, paymentResponse);
            string requestData = JsonConvert.SerializeObject(agasCreateInvoice);
            
            TcpClient client = null;
            try
            {
                using (client = new TcpClient())
                {
                    //client.Connect("14.232.215.179", 900);
                    var cancelTokenConnect = new CancellationTokenSource();
                    cancelTokenConnect.CancelAfter(TimeSpan.FromSeconds(10)); // Đặt thời gian timeout khi kết nối host 10 giây
                    

                    await client.ConnectAsync(Host_InvoiceAgas, Port_InvoiceAgas).WaitAsync(cancelTokenConnect.Token);

                    if (client.Connected)
                    {
                        using (NetworkStream stream = client.GetStream())
                        {
                            var cancelTokenRead = new CancellationTokenSource();
                            cancelTokenRead.CancelAfter(TimeSpan.FromSeconds(10)); // Đặt thời gian timeout khi đọc dữ liệu 10 giây

                            //string message = "{\r\n  \"apiname\": \"egas_createinvoice_feap\",\r\n  \"agasTransId\": 68009951716566301,\r\n  \"quantity\": 3.0,\r\n  \"price\": 23470.0,\r\n  \"amount\": 70410.0,\r\n  \"plateNumber\": \"29A-587.57\",\r\n  \"partnerCode\": \"VETC\",\r\n  \"BankCode\": \"VETC\"\r\n}\u0004";
                            string message = requestData + "\u0004";
                            
                            byte[] data = Encoding.Unicode.GetBytes(message);
                            
                            stream.Write(data.ToArray(), 0, data.Length);
                            
                            byte[] buffer = new byte[2048];

                            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancelTokenRead.Token);
                            
                            string response = Encoding.Unicode.GetString(buffer, 0, bytesRead);

                            string newResponse = response.Replace("\u0004", "").Trim();

                            LogHelperv2.Logger_LPR_Infor($"-> Nhận Response: {response} ", LogHelperv2.SaveLogFolder, agasCreateInvoice);

                            AgasCreateInvoiceResponse responseContent = JsonConvert.DeserializeObject<AgasCreateInvoiceResponse>(newResponse);

                            if (responseContent != null)
                            {
                                if (responseContent.statuscode == "00")         // Thành công
                                {
                                    LogHelperv2.Logger_LPR_Infor("Gửi hóa đơn CreateInvoice đến agas thành công received: " + responseContent, LogHelperv2.SaveLogFolder, agasCreateInvoice);
                                    return true;
                                }
                                else if (responseContent.statuscode == "01")    // Thất bại
                                {
                                    LogHelperv2.Logger_LPR_Infor("Gửi hóa đơn CreateInvoice thành công -> nhận Statuscode = 01 với Error: " + responseContent, LogHelperv2.SaveLogFolder, agasCreateInvoice);
                                    return true;
                                }
                                else
                                {
                                    LogHelperv2.Logger_LPR_Error("Gửi hóa đơn CreateInvoice đến agas thất bại Error: với status ngoại lệ" + responseContent, LogHelperv2.SaveLogFolder, agasCreateInvoice);
                                    return false;
                                }
                            }
                            else
                            {
                                LogHelperv2.Logger_LPR_Error("ResponseContent null !!!", LogHelperv2.SaveLogFolder, agasCreateInvoice);
                                return false;
                            }
                        }
                    }
                    else
                    {
                        LogHelperv2.Logger_LPR_Error($"Client connected -> FAIL", LogHelperv2.SaveLogFolder, agasCreateInvoice);
                        return false;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_LPR_Error($"Exception CreateInvoice -> {ex}", LogHelperv2.SaveLogFolder, agasCreateInvoice);
                return false;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

            private static AgasCreateInvoice CreatInvoiceModel(Payment payment, PaymentResponse paymentResponse)
        {
            AgasCreateInvoice agasCreateInvoice = new AgasCreateInvoice();
            if (paymentResponse != null)
            {
                agasCreateInvoice.apiname = "egas_createinvoice_feap";
                agasCreateInvoice.agasTransId = ulong.Parse(payment.agastransid);
                agasCreateInvoice.quantity = payment.volume;
                agasCreateInvoice.price = payment.price;
                agasCreateInvoice.amount = payment.amount;
                agasCreateInvoice.plateNumber = payment.platenumber;
                agasCreateInvoice.partnerCode = paymentResponse.partnercode;
                agasCreateInvoice.BankCode = paymentResponse.bankcode;
            }

            return agasCreateInvoice;
        }

        public static async Task<IRestResponse> GeneralJsonAPILogin(string apiUrl, Dictionary<string, string> data, Dictionary<string, string> headerValues, Dictionary<string, string> requiredParams, int timeOut, Method method)
        {
            var client = new RestClient(apiUrl);
            client.Timeout = timeOut;
            var request = new RestRequest(method);

            if (data != null)
            {
                foreach (KeyValuePair<string, string> kvp in data)
                {
                    request.AddParameter(kvp.Key, kvp.Value);
                }
            }

            request.AddHeaders(headerValues);

            if (requiredParams != null)
            {
                foreach (KeyValuePair<string, string> kvp in requiredParams)
                {
                    request.AddQueryParameter(kvp.Key, kvp.Value);
                }
            }

            IRestResponse response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
