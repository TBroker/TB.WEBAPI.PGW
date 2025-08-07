using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;

namespace TB.WEBAPI.PGW.APPLICATION.Interfaces
{
    public interface IPaymentT2PService
    {
        Task<bool> CreatePaymentNotifyT2PAsync(HookT2PNotifyRequest request);
    }
}
