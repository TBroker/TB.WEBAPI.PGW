using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks
{
    public class CreateChargeRequest
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        [JsonPropertyName("mode")]
        public string? Mode { get; set; }

        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("reference_order")]
        public string? ReferenceOrder { get; set; }

        [JsonPropertyName("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("additional_data")]
        public AdditionalData? AdditionalData { get; set; }
    }

    public class AdditionalData
    {
        [JsonPropertyName("mid")]
        public string? Mid { get; set; }
    }
}