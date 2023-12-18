using Kztek.Cameras;
using Kztek.LPR;
using iPGSTools.Models;
using System.Drawing.Imaging;
using PETROLIMEX.Helper;

namespace iPGSTools
{
    public class Configuration
    {
        #region Variables

        // Server

        public static string imageFolder = Application.StartupPath + "\\img";
        public static string imageFolderLocal = Application.StartupPath + "\\imgs";

        // System param
        public DateTime _systemDateTime = DateTime.Now;

        #endregion

        #region Capture Image from Camera
        public static object lockObj = new object();
        public async Task<string> Get_Image_From_Camera(Camera camera, string imageFolder, DateTime eventTime)
        {
            //lock (lockObj)
            {
                string ret = String.Empty;
                await Task.Run(() =>
            {
                if (camera != null)
                {
                    try
                    {
                        string folderPath = Path.Combine(imageFolder, eventTime.ToString("yyyy_MM_dd"));
                        Directory.CreateDirectory(folderPath);

                        // Tạo đường dẫn đầy đủ cho ảnh
                        string imagePath = Path.Combine(folderPath, eventTime.ToString("HH_mm_ss") + "." + eventTime.Millisecond + ".jpg");

                        Bitmap img = camera.GetCurrentVideoFrame();
                        img ??= camera.GetCurrentVideoFrame();
                        ret = "";
                        if (img == null)
                        {
                            ret = string.Empty;
                        }
                        else
                        {
                            using (Bitmap new_img = new Bitmap(img))
                            {
                                try
                                {
                                    img.Save(imagePath, ImageFormat.Jpeg);
                                }
                                catch (Exception)
                                {
                                }
                            }
                            //string imagePath = imageFolder + "\\" + eventTime.ToString("yyyyMMdd_HHmmss") + "." + eventTime.Millisecond + ".jpg";
                            //camera.SaveCurrentVideoFrame(imagePath);
                            if (File.Exists(imagePath))
                                ret = imagePath;
                        }
                    }
                    catch (System.AccessViolationException ex)
                    {

                    }
                    catch (Exception ex)
                    {

                    }

                }
            });
                //);
                //if (picSaveType == EmPicSaveType.FrontPlateNumber)
                //    ret = frmMain.testFront;//"D:\\LPR TEST\\New folder (33)\\20220801_090107.500_FrontPlateNumber.jpg";
                //else
                //    ret = frmMain.testRear;
                return ret;
            }
          
        }
        static int detectTimes = 0;
        public async Task<Event_Info> Capture_Image(Camera camera, string imageFolder, DateTime saveEventTime)
        {
            Event_Info eventInfo = null;
            var task_1 = Get_Image_From_Camera(camera, imageFolder, saveEventTime);
            var results = await Task.WhenAll(task_1);
            if (results[0] != "")
            {
                eventInfo = new Event_Info();
                try
                {
                    eventInfo._dateTime = _systemDateTime;
                    eventInfo._imgPath_LPR_Morning = results[0];
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Exception Capture_Image ex = {ex}", LogHelperv2.SaveLogFolder);
                }
            }
            return eventInfo;
        }
        #endregion

        #region Get Plate Number

        public CarANPR carANPR1 = null;

        #region create anpr engine
        private void carANPR_NewError(object sender, Kztek.LPR.ErrorEventArgs e)
        {
        }

        private void motorANPR_NewError(object sender, Kztek.LPR.ErrorEventArgs e)
        {
        }

        public void CloseANPREngine()
        {
            if (carANPR1 != null)
            {
                carANPR1.NewError -= carANPR_NewError;
                carANPR1.CloseLPREngine();
            }
        }
        #endregion

        public async Task<Event_Info> Get_Car_PlateNumber(CarANPR lprProcess, string imagePath)
        {
            Event_Info event_Info = new Event_Info();
            if (!File.Exists(imagePath)) return null;
            await Task.Run(() =>
            {
                try
                {
                    // Recog
                    if (imagePath != "")
                    {
                        var lPRObject_Result = new LPRObject(imagePath);
                        lPRObject_Result.enableMultiplePlateNumber = true;
                        lPRObject_Result.enableRawFormat = false;
                        lPRObject_Result.vehicleImage = (Bitmap)Image.FromFile(imagePath);
                        lprProcess.UsingGPU = true;
                        lprProcess.Analyze(ref lPRObject_Result);
                        if (lPRObject_Result.plateNumber != "" && lPRObject_Result.confidence > 0.1 && lPRObject_Result.plateNumber.Length > 5)
                        {
                            if (lPRObject_Result.confidence < 0.9)
                            {
                                Bitmap output = Utils.CropBitmap(lPRObject_Result.vehicleImage, new Rectangle(0, 0, lPRObject_Result.vehicleImage.Width, lPRObject_Result.plateLocation.Y + lPRObject_Result.plateLocation.Height + 200));
                                output.Save(imagePath.Replace(".jpg", "test.jpg"));
                                if (!File.Exists(imagePath.Replace(".jpg", "test.jpg")))
                                {

                                }
                                string cropImagePath = imagePath.Replace(".jpg", "test.jpg");
                                var lPRObject_Result1 = new LPRObject(cropImagePath);
                                lPRObject_Result1.enableMultiplePlateNumber = true;
                                lPRObject_Result1.enableRawFormat = true;
                                lPRObject_Result1.vehicleImage = (Bitmap)Image.FromFile(cropImagePath);
                                lprProcess.UsingGPU = true;
                                List<(string, double)> plateDetectes = new List<(string, double)>();

                                lprProcess.Analyze(ref lPRObject_Result1);
                                plateDetectes.Add((lPRObject_Result1.plateNumber, lPRObject_Result1.confidence));

                                lprProcess.Analyze(ref lPRObject_Result1);
                                plateDetectes.Add((lPRObject_Result1.plateNumber, lPRObject_Result1.confidence));

                                lprProcess.Analyze(ref lPRObject_Result1);
                                plateDetectes.Add((lPRObject_Result1.plateNumber, lPRObject_Result1.confidence));

                                (string, double) bestResult = ("", 0);

                                foreach (var item in plateDetectes)
                                {
                                    if (bestResult.Item2 < item.Item2)
                                    {
                                        bestResult.Item1 = item.Item1;
                                        bestResult.Item2 = item.Item2;
                                    }
                                }

                                if (lPRObject_Result.confidence < bestResult.Item2)
                                {
                                    lPRObject_Result = lPRObject_Result1;
                                }
                            }

                            event_Info._plate_Number1 = lPRObject_Result.plateNumber;
                            if (event_Info._plate_Number1[2] == '-')
                            {
                                event_Info._plate_Number1 = event_Info._plate_Number1.Remove(2, 1);
                            }
                            event_Info._confidence1 = lPRObject_Result.confidence;
                            if (lPRObject_Result.plateNumberSub.Count > 0)
                            {
                                if (lPRObject_Result.confidenceSub[0] > 0.1)
                                {
                                    event_Info._plate_Number2 = lPRObject_Result.plateNumberSub[0];
                                }
                            }
                            event_Info._image_plateCut = lPRObject_Result.plateImage;
                            event_Info._image_plateCut.Save(imagePath.Replace(".jpg", "cut.jpg"));
                        }
                        else
                        {
                            lPRObject_Result = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Exception Get_Car_PlateNumber ex = {ex}", LogHelperv2.SaveLogFolder);
                }
                finally
                {
                    GC.Collect();
                }
            });
            return event_Info;
        }
        #endregion

        #region Get Ordinal Number
        #endregion
    }

}
