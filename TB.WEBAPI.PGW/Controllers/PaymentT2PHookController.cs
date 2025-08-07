using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;

namespace TB.WEBAPI.PGW.Controllers
{
    [Route("api/t2p/")]
    [ApiController]
    public class PaymentT2PHookController(IPaymentT2PService paymentT2PService) : ControllerBase
    {
        private readonly IPaymentT2PService _paymentT2PService = paymentT2PService;

        [HttpPost("payment")]
        public async Task<IActionResult> NotifyPaymentT2P([FromBody] HookT2PNotifyRequest request)
        {
            var isSuccess = await _paymentT2PService.CreatePaymentNotifyT2PAsync(request);
            return Ok(isSuccess);
        }
    }
}
