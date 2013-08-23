using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace google_smtp_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // replace username and password with your gmail's username and password.
            const string smtpServer = "smtp.gmail.com";
            const int port = 587;
            const string username = "username@gmail.com";
            const string password = "password";

            // from and recipient can be replaced with your own email addresses.
            const string from = "username@gmail.com";
            const string recipient = "receipient@gmail.com";
            const string subject = "Smtp Test";
            const string body = "This email was sent using Google's Smtp server!";

            var smptClient = new SmtpClient(smtpServer, port)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true
            };
            
            smptClient.Send(from, recipient, subject, body);

        }
    }
}
