using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks
{
    public class VoidTransactionResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("transaction_state")]
        public string? TransactionState { get; set; }

        [JsonPropertyName("source")]
        public VoidTransactionSource? Source { get; set; }

        [JsonPropertyName("created")]
        public string? Created { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("reference_order")]
        public string? ReferenceOrder { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        [JsonPropertyName("approval_code")]
        public string? ApprovalCode { get; set; }

        [JsonPropertyName("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("ref_3")]
        public string? Ref3 { get; set; }

        [JsonPropertyName("dcc_data")]
        public object? DccData { get; set; }

        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }

        [JsonPropertyName("campaign_id")]
        public string? CampaignId { get; set; }
    }

    public class VoidTransactionSource
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("brand")]
        public string? Brand { get; set; }

        [JsonPropertyName("card_masking")]
        public string? CardMasking { get; set; }

        [JsonPropertyName("issuer_bank")]
        public string? IssuerBank { get; set; }
    }
}