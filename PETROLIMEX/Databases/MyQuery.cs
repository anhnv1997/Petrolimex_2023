
//using iPGS.Tools;

using iPGSTools.Models;
using PetrolimexTools;
using PetrolimexTools.Helper;
using PetrolimexTools.Model;
using System.Data;
using System.Text;
using static PetrolimexTools.Model.Vehicle;

namespace iPGSTools.Databases
{
    public partial class MyQuery
    {
        public static bool InsertQueryEtag(Vehicle vehicle)
        {
            try
            {
                vehicle.IDQueryEtag = Guid.NewGuid().ToString();
                vehicle.TimeQueryEtag = DateTime.Now;

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblEtagEvent(IdEtag, CreateDate, Subid, PlateRegisted, Etag, EtagControllerID, Plxid, FeapresponseID, Autopayment, IsDelete) ");
                sb.Append($"values ('{vehicle.IDQueryEtag}', '{vehicle.TimeQueryEtag}', '{vehicle.subid}', '{vehicle.platenumber}', '{vehicle.etag}', '{vehicle.etagControllerID}', ");
                sb.Append($"'{vehicle.plxid}', '{vehicle.feapresponseid}', '{(int)vehicle.autopayment}', '{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Query dữ liệu CreateQueryEtag thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertQueryAgas(GasModel gasModel, string IDAgas, string imagePath)
        {
            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblAgasEvent(IDAgas, CreateDate, PumpStatus, TimeStamp, AgastransID, PumpID, StationID, Price, Volume, Amount, ReasonID, IsDelete, ImgPath) ");
                sb.Append($"values ('{IDAgas}', '{DateTime.Now}','{(int)gasModel.pumpstatus}', '{gasModel.timestamp}', '{gasModel.agastransid}', '{gasModel.pumpid}', '{gasModel.stationid}', ");
                sb.Append($"'{gasModel.price}', '{gasModel.volume}', '{gasModel.amount}', '{gasModel.reasonid}', '{false}', '{imagePath}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    LogHelperv2.Logger_CONTROLLER_Infor("=>>>>>>>>>>>> Lưu vào db QueryAgas thành công", LogHelperv2.SaveLogFolder, gasModel);

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Query dữ liệu AgasEvent thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertCreateOrder(Vehicle vehicle, GasModel gasModel)
        {
            try
            {
                vehicle.IDCreateOrder = Guid.NewGuid().ToString();
                vehicle.TimeCreateOrder = DateTime.Now;

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblCreateOrderEvent(IDCreateOrder, CreateDate, EtagID, FeapresponseID, BeaptransID, IDAgas, IsDelete) ");
                sb.Append($"values ('{vehicle.IDCreateOrder}', '{vehicle.TimeCreateOrder}','{vehicle.IDQueryEtag}', '{vehicle.feapresponseid}', '{vehicle.beaptransid}', '{vehicle.IDAgas}', '{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertPayment(Vehicle vehicle, PaymentResponse paymentResponse)
        {
            try
            {
                vehicle.IDPayment = Guid.NewGuid().ToString();
                vehicle.TimePayment = DateTime.Now;

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblPayment (IDPayment, CreateDate, Paystatus, FeapresponseID, Partnercode, BeaptransID, Paytype, Bankcode, Payhash, IDAgas, IsDelete) ");
                sb.Append($"values ('{vehicle.IDPayment}', '{vehicle.TimePayment}',N'{paymentResponse.paystatus}', '{vehicle.feapresponseid}', '{paymentResponse.partnercode}', ");
                sb.Append($"'{vehicle.beaptransid}', '{paymentResponse.paytype}', '{paymentResponse.bankcode}', '{paymentResponse.payhash}', '{vehicle.IDAgas}', '{false}' )");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool CheckProcessError(string plate)
        {
            try
            {
                // Check biển số này có tồn tại và chưa hoàn thành ko 
                string cmd = $"select TOP(1) * from tblMainEvent where PlateNumber = '{plate}' and IsFinish = '0'";
                DataTable dt = StaticPool.mdb.FillData(cmd.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    LogHelperv2.Logger_API_Infor($"Phát hiện có bản ghi chưa hoàn thành chu trình: plate {plate}", LogHelperv2.SaveLogFolder);

                    DataRowView drv = dt.DefaultView[0];
                    string IDFail = drv["ID"].ToString();

                    string pp = $"update tblMainEvent set StatusPayment = '{(int)EmPaymentStatusSQL.ThanhToanThatBai}', IsFinish = '1', Describe = N'Thiếu quy trình' where ID = '{IDFail}'";
                    if (StaticPool.mdb.ExecuteCommand(pp.ToString()))
                    {
                        LogHelperv2.Logger_API_Infor($"Đã update bản ghi chưa hoàn thành chu trình thành công {plate}", LogHelperv2.SaveLogFolder);

                        return true;
                    }
                    else
                    {
                        LogHelperv2.Logger_CONTROLLER_Error($"update bảng Main với TH chưa hoàn thành lỗi ", LogHelperv2.SaveLogFolder);
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception CheckProcessError thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }

        }
        public static bool InsertMainEvent(Vehicle vehicle, GasModel gasModel)
        {
            try
            {


                vehicle.IDMainEvent = Guid.NewGuid().ToString();
                string stationName = StaticPool.StationName ?? "";

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblMainEvent (ID, CreateDate, TimeQueryEtag, QueryEtagID, TimeCreateOrder, CreateOrderID, ");
                sb.Append("Etag, PlateNumber, IsPlateValid, StationID, StationName, PumpID, Price, Volume, Amount, StatusPayment, IsFinish, IsDelete, AgasPumpPickupID, TimeAgasPumpPickup, ImgPathPickup ) ");

                sb.Append($"values ('{vehicle.IDMainEvent}', '{DateTime.Now}','{vehicle.TimeQueryEtag}', '{vehicle.IDQueryEtag}', '{vehicle.TimeCreateOrder}', '{vehicle.IDCreateOrder}', ");
                sb.Append($"'{vehicle.etag}', '{vehicle.platenumber}','{true}', '{gasModel.stationid}', '{stationName}', '{gasModel.pumpid}', '{gasModel.price}', '{gasModel.volume}', '{gasModel.amount}', ");
                sb.Append($"'{(int)EmPaymentStatusSQL.ChuaThanhToan}', '{false}', '{false}', '{vehicle.IDAgas}', '{vehicle.TimeAgas}', '{vehicle.ImgPathPickup}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Insert dữ liệu tblMainEvent thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertMainEvent_SaiQuyTrinh(Vehicle vehicle, GasModel gasModel, string describe)
        {
            try
            {
                vehicle.IDMainEvent = Guid.NewGuid().ToString();
                string stationName = StaticPool.StationName ?? "";

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblMainEvent (ID, CreateDate, TimeQueryEtag, QueryEtagID, ");
                sb.Append("Etag, PlateNumber, IsPlateValid, StationID, StationName, PumpID, StatusPayment, IsFinish, IsDelete, AgasPumpPickupID, TimeAgasPumpPickup, Describe, ImgPathPickup) ");

                sb.Append($"values ('{vehicle.IDMainEvent}', '{DateTime.Now}','{vehicle.TimeQueryEtag}', '{vehicle.IDQueryEtag}', ");
                sb.Append($"'{vehicle.etag}', '{vehicle.platenumber}','{true}', '{gasModel.stationid}', '{stationName}', '{gasModel.pumpid}', ");
                sb.Append($"'{(int)EmPaymentStatusSQL.ThanhToanThatBai}', '{true}', '{false}', '{vehicle.IDAgas}', '{vehicle.TimeAgas}', '{describe}', '{vehicle.ImgPathPickup}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Insert dữ liệu tblMainEvent thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertMainEventNotRegisted(GasModel gasModel, string plateNumber, string IDAgas, string imgPath)
        {
            try
            {
                string stationName = StaticPool.StationName ?? "";

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into tblMainEvent (ID, CreateDate, PlateNumber, IsPlateValid, StationID, ");
                sb.Append("StationName, PumpID, Price, Volume, Amount, StatusPayment, IsDelete, AgasPumpPickupID, TimeAgasPumpPickup, isFinish, ImgPathPickup ) ");
                sb.Append($"values ('{Guid.NewGuid().ToString()}', '{DateTime.Now}', '{plateNumber}','{false}', '{gasModel.stationid}', ");
                sb.Append($"N'{stationName}', '{gasModel.pumpid}', '{gasModel.price}', '{gasModel.volume}', '{gasModel.amount}', '{-1}', '{false}', '{IDAgas}', '{DateTime.Now}', '{0}', '{imgPath}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Insert dữ liệu tblMainEvent thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEvent_GacCoSaiQuyTrinh(Vehicle vehicle, GasModel gasModel, string describe)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update TOP(1) tblMainEvent ");
                sb.Append($"set Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', StatusPayment = '{(int)EmPaymentStatusSQL.ThanhToanThatBai}', ");
                sb.Append($"IsFinish = '{true}', AgasPutdownID = '{vehicle.IDAgas}', TimeAgasPutdown = '{vehicle.TimeAgas}', Describe = '{describe}', ImgPathPutdown = '{vehicle.ImgPathPutdown}' ");
                sb.Append($"where PlateNumber = '{vehicle.platenumber}' and IsPlateValid = '{true}' ");
                sb.Append($"and CreateDate = (SELECT MAX(CreateDate) FROM tblMainEvent WHERE PlateNumber = '{vehicle.platenumber}' AND IsPlateValid = '{true}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventNotRegisted_BopCo(GasModel gasModel, string plateNumber, string IDAgas, string imgPath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update TOP(1) tblMainEvent ");
                sb.Append($"set TimePumping = '{DateTime.Now}', AgasPumpingID = '{IDAgas}', Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', ImgPathPumping = '{imgPath}' ");
                sb.Append($"where PlateNumber = '{plateNumber}' and IsPlateValid = '{false}' ");
                sb.Append($"and CreateDate = (SELECT MAX(CreateDate) FROM tblMainEvent WHERE PlateNumber = '{plateNumber}' AND IsPlateValid = '{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventNotRegisted_GacCo(GasModel gasModel, string plateNumber, string IDAgas, string imgPath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update TOP(1) tblMainEvent ");
                sb.Append($"set AgasPutdownID = '{IDAgas}', TimeAgasPutdown = '{DateTime.Now}', Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', IsFinish = '{true}', ImgPathPutdown = '{imgPath}' ");
                sb.Append($"where PlateNumber = '{plateNumber}' and IsPlateValid = '{false}' ");
                sb.Append($"and CreateDate = (SELECT MAX(CreateDate) FROM tblMainEvent WHERE PlateNumber = '{plateNumber}' AND IsPlateValid = '{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventNotRegisted_HuyGiaoDich(GasModel gasModel, string plateNumber, string IDAgas, string imgPath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update TOP(1) tblMainEvent ");
                sb.Append($"set AgasPumpCancelID = '{IDAgas}', TimeAgasPumpCancel = '{DateTime.Now}', Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', IsFinish = '{true}', ImgPathCancel = '{imgPath}' ");
                sb.Append($"where PlateNumber = '{plateNumber}' and IsPlateValid = '{false}' ");
                sb.Append($"and CreateDate = (SELECT MAX(CreateDate) FROM tblMainEvent WHERE PlateNumber = '{plateNumber}' AND IsPlateValid = '{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventPumping(Vehicle vehicle, GasModel gasModel)
        {
            try
            {
                // Update với ID agas có thể là bản ghi chuẩn / bản ghi thanh toán lỗi
                vehicle.TimePumping = DateTime.Now;
                vehicle.IDPumping = Guid.NewGuid().ToString();
                StringBuilder sb = new StringBuilder();
                sb.Append($"update tblMainEvent ");
                sb.Append($"set TimePumping = '{vehicle.TimePumping}', AgasPumpingID = '{vehicle.IDPumping}', Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', ImgPathPumping = '{vehicle.ImgPathPumping}' ");
                sb.Append($"where ID = '{vehicle.IDMainEvent}'");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventPayment(Vehicle vehicle, GasModel gasModel, int statusPayment, bool IsFinish)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update tblMainEvent ");
                sb.Append($"set TimePayment = '{vehicle.TimePayment}', PaymentID = '{vehicle.IDPayment}', Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', ");
                sb.Append($"StatusPayment = '{statusPayment}',Describe = N'{vehicle.Describtion}', IsFinish = '{IsFinish}', AgasPutdownID = '{vehicle.IDAgas}', TimeAgasPutdown = '{vehicle.TimeAgas}', ImgPathPutdown = '{vehicle.ImgPathPutdown}', InvoiceID = '{vehicle.IDCreateInvoice}' ");
                sb.Append($"where ID = '{vehicle.IDMainEvent}'");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventSaiVoi(Vehicle vehicle, GasModel gasModel)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update tblMainEvent ");
                sb.Append($"set Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', ");
                sb.Append($"StatusPayment = '{(int)EmPaymentStatusSQL.ThanhToanThatBai}', IsFinish = '{true}', AgasPutdownID = '{vehicle.IDAgas}', TimeAgasPutdown = '{vehicle.TimeAgas}', ImgPathPutdown = '{vehicle.ImgPathPutdown}' ");
                sb.Append($"where ID = '{vehicle.IDMainEvent}'");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventLogPayment(Vehicle vehicle)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update tblMainEvent ");
                sb.Append($"set TimeLogAutoPayment = '{vehicle.TimeLogPayment}', LogAutoPaymentID = '{vehicle.IDLogPayment}' ");
                sb.Append($"where ID = '{vehicle.IDMainEvent}'");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool UpdateMainEventCancel(Vehicle vehicle, GasModel gasModel)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"update TOP(1) tblMainEvent ");
                sb.Append($"set Price = '{gasModel.price}', Volume = '{gasModel.volume}', Amount = '{gasModel.amount}', IsFinish = '{true}', AgasPumpCancelID = '{vehicle.IDAgas}', TimeAgasPumpCancel = '{vehicle.TimeAgas}', ImgPathCancel = '{vehicle.ImgPathCancel}' ");
                sb.Append($"where PlateNumber = '{vehicle.platenumber}' and IsPlateValid = '{true}' ");
                sb.Append($"and CreateDate = (SELECT MAX(CreateDate) FROM tblMainEvent WHERE PlateNumber = '{vehicle.platenumber}' AND IsPlateValid = '{true}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Query dữ liệu CreateOrder thất bại + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertLog(EmTypeLog emTypeLog, string mess, string idAgas, string Etag)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"insert into tblLog (LogID, LogDateTime, LogType, Message, Describe, PCName, IDAgas, IDEtag, IsDelete) ");
                sb.Append($"values ('{Guid.NewGuid().ToString()}','{DateTime.Now}',N'{emTypeLog}',N'{mess}','{""}','{Environment.MachineName}','{idAgas}','{Etag}','{false}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception InsertLog + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
        public static bool InsertCreateInvoice(Vehicle vehicle)
        {
            try
            {
                vehicle.IDCreateInvoice = Guid.NewGuid().ToString();

                StringBuilder sb = new StringBuilder();
                sb.Append($"insert into tblCreateInvoice ([IDInvoice], [CreatDate], [ApiName], [AgasTransID], [ResponseDate], [StatusCode], [linkref], [refcode], [reason], [checksum]) ");
                sb.Append($"values ('{vehicle.IDCreateInvoice}','{DateTime.Now}','{vehicle.createInvoiceResponse.apiname}',N'{vehicle.createInvoiceResponse.agasTransId}','{vehicle.createInvoiceResponse.responsedate}',");
                sb.Append($"'{vehicle.createInvoiceResponse.statuscode}','{vehicle.createInvoiceResponse.linkref}','{vehicle.createInvoiceResponse.refcode}',N'{vehicle.createInvoiceResponse.reason}', '{vehicle.createInvoiceResponse.checksum}')");

                if (StaticPool.mdb.ExecuteCommand(sb.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception InsertLog + {ex.ToString()}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
    }
}
