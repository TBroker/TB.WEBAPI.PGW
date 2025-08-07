using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;

namespace TB.WEBAPI.PGW.Controllers
{
    [Route("api/kbank/")]
    [ApiController]
    public class PaymentKBankHookController(IPaymentKBankService paymentKBankService) : ControllerBase
    {
        private readonly IPaymentKBankService _paymentService = paymentKBankService;

        [HttpPost("card/payment")]
        public async Task<IActionResult> NotifyForCardPayment([FromBody] HookCardPaymentNotifyRequest request)
        {
            var isSuccess = await _paymentService.CreatePaymentNotifyCardAsync(request);
            return isSuccess ? Ok(isSuccess) : BadRequest(isSuccess);
        }

        [HttpPost("link/payment")]
        public async Task<IActionResult> NotifyForPaymentLink([FromBody] HookLinkPaymentNotifyRequest request)
        {
            var isSuccess = await _paymentService.CreatePaymentNotifyLinkAsync(request);
            return isSuccess ? Ok(isSuccess) : BadRequest(isSuccess);
        }

        [HttpPost("qr/payment")]
        public async Task<IActionResult> NotifyForQrCodePayment([FromBody] HookQRPaymentNotifyRequest request)
        {
            var isSuccess = await _paymentService.CreatePaymentNotifyQrCodeAsync(request);
            return isSuccess ? Ok(isSuccess) : BadRequest(isSuccess);
        }
    }
}
