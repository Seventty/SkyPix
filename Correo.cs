using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SkyPix
{
   public sealed class Correo
    {
        MailMessage msg = new MailMessage();
        public void mensaje(string para, string subject, string body, string bcc = "skypixoficial@gmail.com")
        {
            msg.To.Clear();
            msg.To.Add(para);
            msg.Subject = subject;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Bcc.Add(bcc);
            msg.Body = "<p style="+ "color:rgb(228,32,72)" + "><font size= "+5+"face="+"Georgia"+"><b> SkyPix Message:</b></font></p>" + "<p><font size = "+3+"face = "+"Georgia"+"><b> "+body+" </b></font></p>";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("elmastigeron2015@gmail.com");
            msg.Priority = MailPriority.High;
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("elmastigeron2015@gmail.com", "250317070877");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            cliente.Send(msg);
            cliente.Dispose();
       }
    }
}
