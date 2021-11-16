namespace ChainLink.Api.Services.Interfaces
{
    public interface IEmailAccountService
    {
        void SendMail(string message, string subject, string email);
    }
}