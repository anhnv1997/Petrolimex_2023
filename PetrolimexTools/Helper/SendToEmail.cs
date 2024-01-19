using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexTools.Helper
{
    public static class SendToEmail
    {
        public enum Em_SendEmail
        {
            Information,
            Warning,
            Error,
        }
        public static async Task<bool> SendEmail(Em_SendEmail subject, string message)
        {
            try
            {
                string fromEmail = "kienphamthaibinh99@gmail.com";
                string keypass = "dltr tnjo aljt wrsc";

                string toEmail = "kienpt@kztek.net";
                //string toEmail = "anhnv@kztek.net";

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromEmail, keypass),
                };

                using (var mailMessage = new MailMessage(fromEmail, toEmail, subject.ToString(), message))
                {
                    await smtpClient.SendMailAsync(mailMessage);
                }

                return true;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception SendEmail ex:{ex}", LogHelperv2.SaveLogFolder);
                return false;
            }
        }
    }
}
