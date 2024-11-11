using MimeKit;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Modules
{
    internal class QuoteGenerator
    {
        static string CompanyName = "Barroc Intens";
        static string CompanyEmail = "ebarrocintens@gmail.com"; // gmail
        static string CompanyEmailPassword = "texp ezca hrbg sgyk"; // app password (BarrocIntens)

        public void SendEmail(string recipientAddress, string subject, string body)
        {
            // Create message
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(CompanyName, CompanyEmail));
            message.To.Add(new MailboxAddress("", recipientAddress));
            message.Subject = subject;

            // Create the email body
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            // Send email
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true); // connect to smtp server with port 465 and ssl enabled
                client.Authenticate(CompanyEmail, CompanyEmailPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
