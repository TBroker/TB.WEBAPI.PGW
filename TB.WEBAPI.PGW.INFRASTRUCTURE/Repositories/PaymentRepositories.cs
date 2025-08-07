using Microsoft.Extensions.Logging;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;
using TB.WEBAPI.PGW.DOMAIN.Entities;
using TB.WEBAPI.PGW.INFRASTRUCTURE.DbContexts;

namespace TB.WEBAPI.PGW.INFRASTRUCTURE.Repositories
{
    public class PaymentRepositories(ILogger<PaymentRepositories> logger, PaymentDbContext context) : IPaymentRepository
    {
        private readonly ILogger<PaymentRepositories> _logger = logger;
        private readonly PaymentDbContext _context = context;

        public async Task<bool> CreatePaymentNotifyQrKBankAsync(WebPaymentNotifyQrKbank notifyQrKBank)
        {
            try
            {
                _logger.LogInformation("Starting AddPaymentNotifyQrKBankAsync with TransactionId: {TransactionId}", notifyQrKBank.TransactionId);
                await _context.WebPaymentNotifyQrKbanks.AddAsync(notifyQrKBank);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Successfully saved payment notification for TransactionId: {TransactionId}", notifyQrKBank.TransactionId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while saving payment notification for TransactionId: {TransactionId}", notifyQrKBank.TransactionId);
                return false;
            }
        }

        public async Task<bool> CreatePaymentNotifyCardKBankAsync(WebPaymentNotifyCardKBank notifyCardKBank)
        {
            try
            {
                _logger.LogInformation("Starting AddPaymentNotifyCardKBankAsync with TransactionId: {TransactionId}", notifyCardKBank.TransactionId);
                await _context.WebPaymentNotifyCardKbanks.AddAsync(notifyCardKBank);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Successfully saved payment notification for TransactionId: {TransactionId}", notifyCardKBank.TransactionId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while saving payment notification for TransactionId: {TransactionId}", notifyCardKBank.TransactionId);
                return false;
            }
        }

        public async Task<bool> CreatePaymentNotifyLinkKBankAsync(WebPaymentNotifyLinkKbank notifyLinkKBank)
        {
            try
            {
                _logger.LogInformation("Starting AddPaymentNotifyLinkKBankAsync with TransactionId: {TransactionId}", notifyLinkKBank.TransactionId);
                await _context.WebPaymentNotifyLinkKbanks.AddAsync(notifyLinkKBank);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Successfully saved payment notification for TransactionId: {TransactionId}", notifyLinkKBank.TransactionId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while saving payment notification for TransactionId: {TransactionId}", notifyLinkKBank.TransactionId);
                return false;
            }
        }

        public async Task<bool> CreatePaymentNotifyT2PAsync(WebPaymentNotifyT2P notifyT2P)
        {
            try
            {
                _logger.LogInformation("Starting AddPaymentNotifyT2PAsync with TransactionId: {TransactionId}", notifyT2P.TransactionId);
                await _context.WebPaymentNotifyT2Ps.AddAsync(notifyT2P);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Successfully saved payment notification for TransactionId: {TransactionId}", notifyT2P.TransactionId);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while saving payment notification for TransactionId: {TransactionId}", notifyT2P.TransactionId);
                return false;
            }
        }
    }
}