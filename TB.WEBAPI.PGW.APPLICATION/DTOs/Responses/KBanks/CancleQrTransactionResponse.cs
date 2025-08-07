using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks
{
    public class CancleQrTransactionResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("created")]
        public string? Created { get; set; }

        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }
    }
}