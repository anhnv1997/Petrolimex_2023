using GeneralTool;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using iPGSTools.Models;
using iPGS.Tools;

namespace iPGSTools.Controllers
{
    public class APIController
    {
        private string ServerConfigPath = $"{Application.StartupPath}\\SQLConn.xml";

        /// <summary>
        /// Hello World
        /// </summary>
        /// <returns></returns>
        private string port = "";

        [HttpGet("Hello")]
        public ActionResult<string> Hello()
        {
            return new OkObjectResult("hello");
        }

        [HttpPost("Petrolimex")]
        public ActionResult<MessageModel> Creat([FromBody] GasModel data)
        {
            MessageModel messageModel = new MessageModel();
            try
            {
                if (data == null)
                {
                    //LogHelper.Logger_SystemWarn($"Cảnh báo nhận Request với data null", Application.StartupPath);
                    return messageModel.MessageFail();
                }
                //UPDATE MAIN VIEW
                Form1.UpdateGasEvent(data);
                
                return messageModel.MessageSuccess();
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception Creat ex = {ex}", LogHelperv2.SaveLogFolder);
                return messageModel.MessageFail();
            }

        }
        [HttpPost("Testing")]
        public ActionResult<bool> Creation([FromBody] BodyModel data)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }

}
