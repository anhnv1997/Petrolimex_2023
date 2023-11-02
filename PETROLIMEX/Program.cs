using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using iPGSTools.Models;
//using iPGS.Tools;
using iPGSTools.Helper;
using PETROLIMEX.Forms;
using iPGS.Tools;
using System.Diagnostics;
using System.Reflection.Emit;

namespace iPGSTools
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>System.Reflection.TargetInvocationException: 'Exception has been thrown by the target of an invocation.'

        [STAThread]
        static void Main()
        {
            try
            {
                bool ownmutex;
                LogHelperv2.SaveLogFolder = Application.StartupPath;
                LogHelperv2.Logger_API_Infor("APP START", LogHelperv2.SaveLogFolder);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            StartApp:
                {
                    using (Mutex mutex = new(true, "PETROLIMEX", out ownmutex))
                    {
                        if (ownmutex)
                        {
                            ApplicationConfiguration.Initialize();
                            frmLoading frmLoad = new frmLoading();
                            if (frmLoad.ShowDialog() == DialogResult.OK)
                            {
                                Application.Run(new Form1());
                            }
                        }
                        else
                        {
                            // ứng dụng đã chạy, đóng ứng dụng trước đó và chạy ứng dụng mới
                            Process currentProcess = Process.GetCurrentProcess();
                            foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
                            {
                                try
                                {
                                    if (process.Id != currentProcess.Id && process.MainModule.FileName == currentProcess.MainModule.FileName)
                                    {
                                        LogHelperv2.Logger_SystemWarn("Ứng dụng đang được mở, tắt ứng dụng mở trước đó, mở ứng dụng mới", LogHelperv2.SaveLogFolder);
                                        process.Kill();
                                        goto StartApp;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    goto StartApp;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception main: {ex.ToString()}");
                LogHelperv2.Logger_API_Error($"Exception Main: {ex}", LogHelperv2.SaveLogFolder);
            }

        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogHelperv2.Logger_CONTROLLER_Error($"EEEEEEEEEEEEEEEEEE", LogHelperv2.SaveLogFolder);

        }
    }
}