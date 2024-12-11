﻿using MailKit.Net.Smtp;
using MimeKit;

namespace AuctionCore.MailHelper;

public class MailService : IMailService
{
    public void SendEmail(string subject, string body, string email)
    {
        try
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("bkeskin394@gmail.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };


            using var emailClient = new SmtpClient();
            emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            emailClient.Authenticate("testdenemebatu1@gmail.com", "zuhnvixhckwzaiek");
            emailClient.Send(emailToSend);
            emailClient.Disconnect(true);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
