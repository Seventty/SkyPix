using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SkyPix
{
    class mensajeUsuario
    {
        MailMessage enviomensaje = new MailMessage();
        public void mensajeusuario(string para, string subject, string body, string bcc = "skypixoficial@gmail.com")
        {
            enviomensaje.To.Clear();
            enviomensaje.To.Add(para);
            enviomensaje.Subject = subject;
            enviomensaje.SubjectEncoding = Encoding.UTF8;
            enviomensaje.Bcc.Add(bcc);
            enviomensaje.Body = "<p style=" + "color:rgb(228,32,72)" + "><font size= " + 5 + "face=" + "Georgia" + "><b> SkyPix Message:</b></font></p>" + "<p><font size = " + 3 + "face = " + "Georgia" + "><b> " + body + " </b></font></p>";
            enviomensaje.BodyEncoding = Encoding.UTF8;
            enviomensaje.IsBodyHtml = true;
            enviomensaje.From = new MailAddress("skypixoficial");
            enviomensaje.Priority = MailPriority.High;
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("skypixoficial@gmail.com", "skypix250317070877");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            cliente.Send(enviomensaje);
            cliente.Dispose();
        }
    }
}
