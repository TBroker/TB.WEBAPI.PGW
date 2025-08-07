using TB.WEBAPI.PGW.DOMAIN.Entities;

namespace TB.WEBAPI.PGW.APPLICATION.Interfaces
{
    public interface IPaymentRepository
    {
        Task<bool> CreatePaymentNotifyCardKBankAsync(WebPaymentNotifyCardKBank notifyCardKbank);

        Task<bool> CreatePaymentNotifyLinkKBankAsync(WebPaymentNotifyLinkKbank notifyLinkKbank);

        Task<bool> CreatePaymentNotifyQrKBankAsync(WebPaymentNotifyQrKbank webPaymentNotifyQrKbank);

        Task<bool> CreatePaymentNotifyT2PAsync(WebPaymentNotifyT2P webPaymentConfirmT2P);
    }
}