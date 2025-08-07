using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;

namespace TB.WEBAPI.PGW.Controllers
{
    [Route("api/payment/kbank/")]
    [ApiController]
    public class PaymentKBankController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly string clientName = "KBankExternalApi";
        private readonly IApiClientService _apiClientService = apiClientService;

        #region Qr Code

        [HttpGet("qr/inquiry/order/{orderId}")]
        public async Task<IActionResult> InquiryOrder(string orderId)
        {
            var response = await _apiClientService.GetAsync<InquiryOrderResponse>(clientName, $"/qr/v2/order/{orderId}");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("qr/inquiry/transaction/{id}")]
        public async Task<IActionResult> InquiryQrTransaction(string id)
        {
            var response = await _apiClientService.GetAsync<InquiryQrTransactionResponse>(clientName, $"/qr/v2/qr/{id}");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("qr/void/{chargeId}")]
        public async Task<IActionResult> VoidQrTransaction(string chargeId)
        {
            var response = await _apiClientService.PostAsync<VoidQrTransactionResponse>(clientName, $"/qr/v2/qr/{chargeId}/void");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("qr/cancel/{qrId}")]
        public async Task<IActionResult> CancelQrTransaction(string qrId)
        {
            var response = await _apiClientService.PostAsync<CancleQrTransactionResponse>(clientName, $"/qr/v2/qr/{qrId}/cancel");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("qr/create/order")]
        public async Task<IActionResult> CreateOrderRequest([FromBody] CreateOrderRequest request)
        {
            var response = await _apiClientService.PostAsync<CreateOrderRequest, CreateOrderResponse>(clientName, "/qr/v2/order", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        #endregion Qr Code

        #region CreditCard

        [HttpGet("card/inquiry/transaction/{id}")]
        public async Task<IActionResult> InquiryTransaction(string id)
        {
            var response = await _apiClientService.GetAsync<InquiryTransactionResponse>(clientName, $"/card/v2/charge/{id}");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("card/void/{chargeId}")]
        public async Task<IActionResult> VoidTransaction(string chargeId)
        {
            var response = await _apiClientService.PostAsync<VoidTransactionResponse>(clientName, $"/card/v2/charge/{chargeId}/void");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("card/refund/{chargeId}")]
        public async Task<IActionResult> RefundTransaction(string chargeId)
        {
            var response = await _apiClientService.PostAsync<RefundTransactionResponse>(clientName, $"/card/v2/charge/{chargeId}/refund");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("card/create/charge")]
        public async Task<IActionResult> CreateChargeRequest([FromBody] CreateChargeRequest request)
        {
            var response = await _apiClientService.PostAsync<CreateChargeRequest, CreateChargeResponse>(clientName, "/card/v2/charge", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        #endregion CreditCard

        #region Payment Link

        [HttpGet("link/inquiry/paymentlink/{linkRef}")]
        public async Task<IActionResult> InquiryPaymentLink(string linkRef)
        {
            var response = await _apiClientService.GetAsync<InquiryPaymentLinkResponse>(clientName, $"/KPGW-Payment-Webapi/public/api/payment-link/{linkRef}");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("link/disable/paymentlink/{linkRef}")]
        public async Task<IActionResult> DisablePaymentLinkRequest(string linkRef)
        {
            var response = await _apiClientService.PostAsync<DisablePaymentLinkResponse>(clientName, $"/KPGW-Payment-Webapi/public/api/payment-link/{linkRef}/disable");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("link/create/paymentlink")]
        public async Task<IActionResult> CreatePaymentLinkRequest([FromBody] CreatePaymentLinkRequest request)
        {
            var response = await _apiClientService.PostAsync<CreatePaymentLinkRequest, CreatePaymentLinkResponse>(clientName, "/KPGW-Payment-Webapi/public/api/payment-link/create", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        #endregion Payment Link
    }
}