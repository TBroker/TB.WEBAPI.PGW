using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;

namespace TB.WEBAPI.PGW.APPLICATION.Interfaces
{
    public interface IPaymentKBankService
    {
        Task<bool> CreatePaymentNotifyQrCodeAsync(HookQRPaymentNotifyRequest request);

        Task<bool> CreatePaymentNotifyCardAsync(HookCardPaymentNotifyRequest request);

        Task<bool> CreatePaymentNotifyLinkAsync(HookLinkPaymentNotifyRequest request);
    }
}