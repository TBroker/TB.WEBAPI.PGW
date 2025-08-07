using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;
using TB.WEBAPI.PGW.DOMAIN.Entities;

namespace TB.WEBAPI.PGW.APPLICATION.Services
{
    public class PaymentT2PService(IPaymentRepository paymentRepository) : IPaymentT2PService
    {
        private readonly IPaymentRepository _paymentRepository = paymentRepository;

        public async Task<bool> CreatePaymentNotifyT2PAsync(HookT2PNotifyRequest request)
        {
            var webPaymentNotifyT2P = new WebPaymentNotifyT2P
            {
                TransactionId = Guid.NewGuid().ToString(),
                DateCreate = DateTime.Now,
                ConfirmMessage = request.ConfirmMessage,
                Id = request.Id,
                ApproveCode = request.ApproveCode,
                ApproveStatus = request.ApproveStatus,
                BankCode = request.BankCode,
                ChannelCode = request.ChannelCode,
                InstallmentMode = request.InstallmentMode,
                InstallmentAmount = request.InstallmentAmount,
                InstallmentNumber = request.InstallmentNumber,
                PaymentAmount = request.PaymentAmount,
                PaymentChannel = request.PaymentChannel,
                PaymentDate = request.PaymentDate,
                PaymentRef1 = request.PaymentRef1,
                PaymentRef2 = request.PaymentRef2,
                PaymentType = request.PaymentType,
            };
            return await _paymentRepository.CreatePaymentNotifyT2PAsync(webPaymentNotifyT2P);
        }
    }
}
