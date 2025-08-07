using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps
{
    public class InquiryTransactionRequest
    {
        [JsonPropertyName("payment_ref1")]
        public string? PaymentRef1 { get; set; }

        [JsonPropertyName("payment_ref2")]
        public string? PaymentRef2 { get; set; }
    }
}