﻿using System.Diagnostics;
using System.Reflection;

namespace PetrolimexTools.Helper
{
    public class LogHelperv2
    {  //Multy Thread Excecute
        private static object lockObject = new object();
        public static string SaveLogFolder = "";
        private static Dictionary<string, StreamWriter> streamWriters = new Dictionary<string, StreamWriter>();
        #region: LOG

        public static void Log(EM_LogType logType, string message, string startUpPath, DateTime logTime, object obj = null, int limitLength = 0, string specailName = "")
        {
            lock (lockObject)
            {
                try
                {
                    if (obj != null)
                        message += TextFormatingTool.BeautyJson(obj);

                    string InitPath = GetSavePath(logType, startUpPath);
                    Directory.CreateDirectory(InitPath);
                    string pathFile = "";
                    int limitSize = 1000 * 1024; //1M
                    if (string.IsNullOrEmpty(specailName))
                    {
                        string basePath = Path.GetDirectoryName(InitPath) + @"\" + logType.ToString() + "_" + DateTime.Now.Hour + "_1.html";
                        pathFile = GetLogFilePathByLimitSize(basePath, limitSize);
                        //if (DateTime.Now.Minute < 30)
                        //{
                        //    pathFile = Path.GetDirectoryName(InitPath) + @"\" + logType.ToString() + "_" + DateTime.Now.Hour + "_1.html";
                        //}
                        //else
                        //{
                        //    pathFile = Path.GetDirectoryName(InitPath) + @"\" + logType.ToString() + "_" + DateTime.Now.Hour + "_2.html";
                        //}
                    }
                    else
                    {
                        string basePath = Path.GetDirectoryName(InitPath) + @"\" + specailName + "_" + logType.ToString() + "_" + DateTime.Now.Hour + "_1.html";
                        pathFile = GetLogFilePathByLimitSize(basePath, limitSize);
                        //if (DateTime.Now.Minute < 30)
                        //{
                        //    pathFile = Path.GetDirectoryName(InitPath) + @"\" + specailName + "_" + logType.ToString() + "_" + DateTime.Now.Hour + "_1.html";

                        //}
                        //else
                        //{
                        //    pathFile = Path.GetDirectoryName(InitPath) + @"\" + specailName + "_" + logType.ToString() + "_" + DateTime.Now.Hour + "_2.html";
                        //}
                    }
                    if (File.Exists(pathFile))
                    {
                        string oldContent = "";
                        using (StreamReader reader = new StreamReader(pathFile))
                        {
                            oldContent = reader.ReadToEnd();
                            oldContent = oldContent.Replace("<a href=\"#{next-id}\" class=\"move\">next</a>", $@"<a href=""#{logTime.ToString("yyyy-MM-dd HH:mm:ss.fff")}"" class = ""btn"">Next {logTime.ToString("yyyy-MM-dd HH:mm:ss.fff")}</a>");
                            reader.Dispose();
                        }
                        string logContent = GetLogContent(logType, message, logTime).TrimEnd(); ;
                        oldContent = oldContent.Replace("<p style=\"display: none;\">{log_content}</p>", logContent);
                        using (StreamWriter writer = new StreamWriter(pathFile, false))
                        {
                            try
                            {
                                writer.WriteLine(oldContent);
                                writer.Dispose();
                            }
                            catch
                            {
                            }
                        }
                    }
                    else
                    {
                        string initContent = InitContent();
                        string logContent = GetLogContent(logType, message, logTime);
                        initContent = initContent.Replace("<p style=\"display: none;\">{log_content}</p>", logContent);
                        using (StreamWriter writer = new StreamWriter(pathFile, false))
                        {
                            try
                            {
                                writer.WriteLine(initContent);
                                writer.Dispose();
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                finally
                {
                    GC.Collect();
                }
            }
        }

        public static string GetLogFilePathByLimitSize(string basePath, int limitSizeInByte)
        {
            if (File.Exists(basePath))
            {
                if (GetFileSize(basePath) > limitSizeInByte)
                {
                    var temp = basePath.Split('_');
                    int currentIndex = int.Parse(temp[temp.Length - 1].Split('.')[0]);
                    int nextIndex = currentIndex + 1;
                    temp[temp.Length - 1] = nextIndex + ".html";
                    string updatePath = string.Join("_", temp);
                    return GetLogFilePathByLimitSize(updatePath, limitSizeInByte);
                }
                else
                {
                    return basePath;
                }
            }
            else
            {
                return basePath;
            }
        }
        static long GetFileSize(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                if (fileInfo.Exists)
                {
                    return fileInfo.Length;
                }
                else
                {
                    // File not found
                    return -1;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during file access
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
        public static string GetSavePath(EM_LogType logType, string startUpPath)
        {
            string initPath = startUpPath + $@"\logs\{DateTime.Now.Year}\{DateTime.Now.Month}\{DateTime.Now.Day}\";
            return initPath + @"\";
        }

        public static string InitContent()
        {
            try
            {
                string path = Path.Combine(SaveLogFolder + "/LogFormat/log.html");
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static string GetLogItemContent()
        {
            try
            {
                string path = Path.Combine(SaveLogFolder + "/LogFormat/log_item.html");
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                return "";
            }
        }


        public static string GetLogContent(EM_LogType logType, string message, DateTime logTime)
        {
            string color = GetDisplayColor(logType);
            FunctionExcecute functionExcecute = GetFunctionExcecute();
            string content = GetLogItemContent();
            content = content.Replace("{current-time}", logTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            string _logType = string.Empty;
            if (logType.ToString().ToLower().Contains("infor"))
            {
                _logType = "info";
            }
            else if (logType.ToString().ToLower().Contains("error"))
            {
                _logType = "error";
            }
            else
            {
                _logType = "warn";
            }
            content = content.Replace("{log-type}", _logType);
            content = content.Replace("{log-name}", logType.ToString());
            content = content.Replace("{function-name}", functionExcecute.FunctionName);
            content = content.Replace("{file-name}", functionExcecute.FileName);
            content = content.Replace("{line-number}", functionExcecute.LineNumber.ToString());
            content = content.Replace("{message}", message);
            return content;
        }

        private static string GetDisplayColor(EM_LogType logType)
        {
            string displayColor = "green";
            if (logType.ToString().ToLower().Contains("error"))
            {
                displayColor = "red";
            }
            else if (logType.ToString().ToLower().Contains("warn"))
            {
                displayColor = "yellow";
            }
            else
                displayColor = "green";
            return displayColor;
        }

        #endregion: END LOG

        #region: Log System
        public static void Logger_SystemError(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.SYSTEM_ERROR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_SystemInfor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.SYSTEM_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_SystemWarn(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.SYSTEM_WARNING, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        #endregion:End Log System

        #region: Black List
        public static void Logger_BlackListInfor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.BLACK_LIST_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }

        #endregion: End Black List


        #region: Log API
        public static void Logger_API_Error(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.API_ERROR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_API_Infor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.API_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_API_Warning(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.API_WARNING, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        #endregion: End Log API

        #region: Log COntroller
        public static void Logger_CONTROLLER_Error(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CONTROLLER_ERROR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_CONTROLLER_Infor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CONTROLLER_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_CONTROLLER_Warning(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CONTROLLER_WARNING, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        #endregion: End Log Controller

        #region: Log Camera
        public static void Logger_Camera_Error(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CAMERA_ERROR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_Camera_Infor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CAMERA_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_Camera_Warning(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.CAMERA_WARNING, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        #endregion: End Log Camera

        #region: Log LPR
        public static void Logger_LPR_Error(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.LPR_ERROR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_LPR_Infor(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.LPR_INFOR, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        public static void Logger_LPR_Warning(string errorMessage, string startUpPath, object obj = null)
        {
            Task.Run(() =>
            {
                Log(EM_LogType.LPR_WARNING, errorMessage, startUpPath, DateTime.Now, obj);
            });
        }
        #endregion: End Log LPR

        #region: Log Ipc
        public static void Logger_IPC_Error(string errorMessage, string startUpPath, int limitLength)
        {
            string content = GetLogContent(EM_LogType.IPC_INFOR, errorMessage, DateTime.Now);

            string initPath = startUpPath + $@"\logs\{DateTime.Now.Month}\{DateTime.Now.Day}\";
            initPath += EM_LogType.IPC_INFOR.ToString() + @"\";

            lock (lockObject)
            {
                try
                {
                    Directory.CreateDirectory(initPath);
                    int fCount = Directory.GetFiles(initPath, "*", SearchOption.AllDirectories).Length;
                    if (fCount == 0) fCount = 1;
                    string pathFile = Path.GetDirectoryName(initPath) + @"\" + EM_LogType.IPC_ERROR.ToString() + fCount + ".html";
                    if (!File.Exists(pathFile))
                    {
                        using (StreamWriter writer = new StreamWriter(pathFile, true))
                        {
                            try
                            {
                                writer.WriteLine(content);
                            }
                            catch
                            {
                            }
                        }
                    }
                    else
                    {
                        string checkLengthContent = File.ReadAllText(pathFile);
                        if (checkLengthContent.Length >= limitLength)
                        {
                            pathFile = Path.GetDirectoryName(initPath) + @"\" + EM_LogType.IPC_ERROR.ToString() + (fCount + 1) + ".html";
                            using (StreamWriter writer = new StreamWriter(pathFile, true))
                            {
                                try
                                {
                                    writer.WriteLine(content);
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    GC.Collect();
                }
            }
        }
        public static void Logger_IPC_Infor(string message, string startUpPath, int limitLength)
        {
            string content = GetLogContent(EM_LogType.IPC_INFOR, message, DateTime.Now);

            string initPath = startUpPath + $@"\logs\{DateTime.Now.Month}\{DateTime.Now.Day}\";
            initPath += EM_LogType.IPC_INFOR.ToString() + @"\";

            lock (lockObject)
            {
                try
                {
                    Directory.CreateDirectory(initPath);
                    int fCount = Directory.GetFiles(initPath, "*", SearchOption.AllDirectories).Length;
                    if (fCount == 0) fCount = 1;
                    string pathFile = Path.GetDirectoryName(initPath) + @"\" + EM_LogType.IPC_INFOR.ToString() + fCount + ".html";
                    if (!File.Exists(pathFile))
                    {
                        using (StreamWriter writer = new StreamWriter(pathFile, true))
                        {
                            try
                            {
                                writer.WriteLine(content);
                            }
                            catch
                            {
                            }
                        }
                    }
                    else
                    {
                        string checkLengthContent = File.ReadAllText(pathFile);
                        if (checkLengthContent.Length >= limitLength)
                        {
                            pathFile = Path.GetDirectoryName(initPath) + @"\" + EM_LogType.IPC_INFOR.ToString() + (fCount + 1) + ".html";
                            using (StreamWriter writer = new StreamWriter(pathFile, true))
                            {
                                try
                                {
                                    writer.WriteLine(content);
                                }
                                catch
                                {
                                }
                            }
                        }
                        else
                        {
                            using (StreamWriter writer = new StreamWriter(pathFile, true))
                            {
                                try
                                {
                                    writer.WriteLine(content);
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    GC.Collect();
                }
            }
        }
        public static void Logger_IPC_Warning(string errorMessage, string startUpPath, int limitLength)
        {
            Log(EM_LogType.IPC_WARNING, errorMessage, startUpPath, DateTime.Now);
        }
        #endregion: END Log IPC

        #region: Log Application Progress
        public static void Logger_Application_Progress(string message, object obj = null)
        {
            if (obj != null)
                Log(EM_LogType.Application_Progress, message + " : " + TextFormatingTool.BeautyJson(obj), SaveLogFolder, DateTime.Now);
            else
                Log(EM_LogType.Application_Progress, message, SaveLogFolder, DateTime.Now);
        }
        #endregion: End Application Progress
        public static FunctionExcecute GetFunctionExcecute()
        {
            StackTrace stackTrace = new StackTrace();
            int skipFunction = 4;
            StackFrame stackFrame = new StackFrame(skipFunction, true);
            MethodBase methodBase = stackFrame.GetMethod();
            return new FunctionExcecute()
            {
                FunctionName = stackFrame.GetMethod().Name,
                FileName = stackFrame.GetFileName(),
                LineNumber = stackFrame.GetFileLineNumber(),
            };
        }

        public class FunctionExcecute
        {
            public string FunctionName { get; set; } = string.Empty;

            public string FileName { get; set; } = string.Empty;

            public int LineNumber { get; set; } = 0;
        }
        public static void SaveErrorLog(string errorTittle, Exception ex = null)
        {
            if (ex == null)
            {
                LogHelperv2.Logger_SystemError(errorTittle, LogHelperv2.SaveLogFolder);
                LogHelperv2.Logger_Application_Progress(errorTittle);
            }
            else
            {
                LogHelperv2.Logger_SystemError(errorTittle, LogHelperv2.SaveLogFolder, ex);
                LogHelperv2.Logger_Application_Progress(errorTittle, ex);
            }
        }
        public enum EM_LogType
        {
            SYSTEM_INFOR,
            SYSTEM_WARNING,
            SYSTEM_ERROR,
            API_INFOR,
            API_WARNING,
            API_ERROR,
            CAMERA_INFOR,
            CAMERA_WARNING,
            CAMERA_ERROR,
            CONTROLLER_INFOR,
            CONTROLLER_WARNING,
            CONTROLLER_ERROR,
            LPR_INFOR,
            LPR_WARNING,
            LPR_ERROR,
            IPC_INFOR,
            IPC_WARNING,
            IPC_ERROR,
            BLACK_LIST_INFOR,
            Application_Progress
        }
    }
}
