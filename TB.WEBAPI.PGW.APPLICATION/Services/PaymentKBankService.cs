using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;
using TB.WEBAPI.PGW.DOMAIN.Entities;

namespace TB.WEBAPI.PGW.APPLICATION.Services
{
    public class PaymentKBankService(IPaymentRepository paymentRepository) : IPaymentKBankService
    {
        private readonly IPaymentRepository _paymentRepository = paymentRepository;

        public async Task<bool> CreatePaymentNotifyCardAsync(HookCardPaymentNotifyRequest request)
        {
            var webPaymentNotify = new WebPaymentNotifyCardKBank
            {
                Amount = request.Amount,
                ApprovalCode = request.ApprovalCode,
                CampaignId = request.CampaignId,
                Checksum = request.Checksum,
                Created = request.Created,
                Currency = request.Currency,
                DateCreate = DateTime.Now,
                Description = request.Description,
                FailureCode = request.FailureCode,
                FailureMessage = request.FailureMessage,
                Id = request.Id,
                Livemode = request.Livemode.ToString(),
                MpiCavv = request.Mpi?.Cavv,
                MpiEci = request.Mpi?.Eci,
                MpiKbankMpi = request.Mpi?.KbankMpi.ToString(),
                MpiXid = request.Mpi?.Xid,
                Object = request.Object,
                RedirectUrl = request.RedirectUrl,
                Ref1 = request.Ref1,
                Ref2 = request.Ref2,
                Ref3 = request.Ref3,
                ReferenceOrder = request.ReferenceOrder,
                SourceBrand = request.Source?.Brand,
                SourceCardMasking = request.Source?.CardMasking,
                SourceId = request.Source?.Id,
                SourceIssuerBank = request.Source?.IssuerBank,
                SourceObject = request.Source?.Object,
                Status = request.Status,
                TransactionId = Guid.NewGuid().ToString(),
                TransactionState = request.TransactionState
            };

            return await _paymentRepository.CreatePaymentNotifyCardKBankAsync(webPaymentNotify);
        }

        public async Task<bool> CreatePaymentNotifyLinkAsync(HookLinkPaymentNotifyRequest request)
        {
            var webPaymentNotify = new WebPaymentNotifyLinkKbank
            {
                Amount = request.Amount,
                CampaignId = request.CampaignId,
                Checksum = request.Checksum,
                ConvfeeAmount = request.Convfee?.ConvfeeAmount,
                ConvfeeNetAmount = request.Convfee?.NetAmount,
                ConvfeeVatAmount = request.Convfee?.ConvfeeVatAmount,
                Created = request.Created,
                Currency = request.Currency,
                DateCreate = DateTime.Now,
                Description = request.Description,
                FailureCode = request.FailureCode,
                FailureMessage = request.FailureMessage,
                Id = request.Id,
                LinkRef = request.LinkRef,
                Livemode = request.Livemode.ToString(),
                Metadata = request.Metadata,
                Object = request.Object,
                RedirectUrl = request.RedirectUrl,
                Ref1 = request.Ref1,
                Ref2 = request.Ref2,
                Ref3 = request.Ref3,
                ReferenceOrder = request.ReferenceOrder,
                SourceBrand = request.Source?.Brand,
                SourceCardMasking = request.Source?.CardMasking,
                SourceId = request.Source?.Id,
                SourceIssuerBank = request.Source?.IssuerBank,
                SourceObject = request.Source?.Object,
                Status = request.Status,
                TransactionId = Guid.NewGuid().ToString(),
                TransactionState = request.TransactionState,
            };

            return await _paymentRepository.CreatePaymentNotifyLinkKBankAsync(webPaymentNotify);
        }

        public async Task<bool> CreatePaymentNotifyQrCodeAsync(HookQRPaymentNotifyRequest request)
        {
            var webPaymentNotify = new WebPaymentNotifyQrKbank
            {
                Amount = request.Amount,
                Checksum = request.Checksum,
                Created = request.Created,
                Currency = request.Currency,
                DateCreate = DateTime.Now,
                Description = request.Description,
                FailureCode = request.FailureCode,
                FailureMessage = request.FailureMessage,
                Id = request.Id,
                LiveMode = request.LiveMode.ToString(),
                Object = request.Object,
                OrderId = request.OrderId,
                ReferenceOrder = request.ReferenceOrder,
                SourceBrand = request.Source?.Brand,
                SourceId = request.Source?.Id,
                SourceObject = request.Source?.Object,
                Status = request.Status,
                TransactionId = Guid.NewGuid().ToString(),
                TransactionState = request.TransactionState,
            };

            return await _paymentRepository.CreatePaymentNotifyQrKBankAsync(webPaymentNotify);
        }

    }
}