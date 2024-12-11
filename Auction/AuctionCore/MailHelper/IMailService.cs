namespace AuctionCore.MailHelper;

public interface IMailService
{
    public void SendEmail(string subject, string body, string email);
}
