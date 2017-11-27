using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace ERL.Mail
{
    public class MailHelper
    {
        static MailHelper _mailHelper = null;
        MailHelper()
        {
            
        }
        public static MailHelper GetMailHelper
        {
            get
            {
                if (_mailHelper == null)
                    _mailHelper = new MailHelper();
                return _mailHelper;
            }
        }

        public void Setup()
        {
            try
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 587;
                WebMail.EnableSsl = true;
                WebMail.UserName = "andrewchess25@gmail.com";
                WebMail.Password = "Manutd1992";
                WebMail.From = "andrewchess25@gmail.com";
                WebMail.Send("andrewchess25@gmail.com", "test", "test");
            }
            catch(Exception exc)
            {

            }
        }

    }
}