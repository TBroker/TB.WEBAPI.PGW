using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps;
using TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.T2Ps;
using TB.WEBAPI.PGW.APPLICATION.Interfaces;

namespace TB.WEBAPI.PGW.Controllers
{
    [Route("api/t2p/")]
    [ApiController]
    public class PaymentT2PController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly string clientName = "T2PExternalApi";
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("inquiry/transaction")]
        public async Task<IActionResult> InquiryTransactionPayment([FromBody] InquiryTransactionRequest request)
        {
            var response = await _apiClientService.GetAsync<InquiryTransactionResponse>(clientName, $"/T2P_APP/api/proxy/payment/enquiry?payment_ref1={request.PaymentRef1}&payment_ref2={request.PaymentRef2}");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/appentry")]
        public async Task<IActionResult> CreateAppEntryRequest([FromBody] CreateAppEntryRequest request)
        {
            var response = await _apiClientService.PostAsync<CreateAppEntryRequest, CreateAppEntryResponse>(clientName, $"/T2P_APP/api/proxy/application", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}