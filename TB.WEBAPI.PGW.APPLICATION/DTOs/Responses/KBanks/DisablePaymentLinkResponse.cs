using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks
{
    public class DisablePaymentLinkResponse
    {
        [JsonPropertyName("status_code")]
        public string? StatusCode { get; set; }

        [JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        [JsonPropertyName("properties")]
        public DisablePaymentLinkProperties? Properties { get; set; }
    }

    public class DisablePaymentLinkProperties
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}