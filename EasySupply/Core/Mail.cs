using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySupply
{
    internal class Mail
    {
        public const string SmtpMail = "bilgi-1@baymyo.com;bilgi-2@baymyo.com;bilgi-3@baymyo.com";
        public const string SmtpPassword = "12345cvp";
        public const string SmtpHost = "smtp.gmail.com";
        public const int SmtpPort = 587;
        public const bool SmtpEnableSsl = true;

        public static bool SendInfo(string subject, string message)
        {
            try
            {
                foreach (string m in SmtpMail.Split(';'))
                {
                    bool isOkey = BAYMYO.UI.Mail.Send("info@baymyo.com", "baymyo.com", "noreply@baymyo.com", "Feedback!", subject, message, true,
                        SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (!isOkey)
                        isOkey = BAYMYO.UI.Mail.Send("baymyo@gmail.com", "baymyo.com", "noreply@baymyo.com", "Feedback!", subject, message, true,
                         SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (!isOkey)
                        isOkey = BAYMYO.UI.Mail.Send("sonaynet@gmail.com", "Hayati Sonay", "info@baymyo.com", "Feedback!", subject, message, true,
                         SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (isOkey)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool SendBaymyo(string mail, string name, string subject, string message)
        {
            try
            {
                foreach (string m in SmtpMail.Split(';'))
                {
                    bool isOkey = BAYMYO.UI.Mail.Send("info@baymyo.com", "baymyo.com", mail, name, subject, message, true,
                        SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (!isOkey)
                        BAYMYO.UI.Mail.Send("baymyo@gmail.com", "baymyo.com", mail, name, subject, message, true,
                        SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (isOkey)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool SendSonay(string mail, string name, string subject, string message)
        {
            try
            {
                foreach (string m in SmtpMail.Split(';'))
                {
                    bool isOkey = BAYMYO.UI.Mail.Send("sonaynet@gmail.com", "SonayNet", mail, name, subject, message, true,
                        SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (!isOkey)
                        BAYMYO.UI.Mail.Send("hayati@sonay.net", "SonayNet", mail, name, subject, message, true,
                        SmtpHost, SmtpPort, SmtpEnableSsl, m, SmtpPassword);
                    if (isOkey)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsAddressValid(string emailaddress)
        {
            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(emailaddress);
                return true;
            }
            catch (FormatException ex)
            {
                Commons.Status(Commons.GetErrorCode("MIL", 1) + ex.Message);
                return false;
            }
        }
    }
}
