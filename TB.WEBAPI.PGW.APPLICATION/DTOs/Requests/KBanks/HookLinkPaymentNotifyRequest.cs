using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks
{
    public class HookLinkPaymentNotifyRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("transaction_state")]
        public string? TransactionState { get; set; }

        [JsonPropertyName("created")]
        public string? Created { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }

        [JsonPropertyName("checksum")]
        public string? Checksum { get; set; }

        [JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("reference_order")]
        public string? ReferenceOrder { get; set; }

        [JsonPropertyName("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("ref_3")]
        public string? Ref3 { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        [JsonPropertyName("campaign_id")]
        public string? CampaignId { get; set; }

        [JsonPropertyName("link_ref")]
        public string? LinkRef { get; set; }

        [JsonPropertyName("source")]
        public NotifyLinkSource? Source { get; set; }

        [JsonPropertyName("convfee")]
        public NotifyLinkConvfee? Convfee { get; set; }
    }

    public class NotifyLinkSource
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

    public class NotifyLinkConvfee
    {
        [JsonPropertyName("convfee_amount")]
        public decimal ConvfeeAmount { get; set; }

        [JsonPropertyName("convfee_vat_amount")]
        public decimal ConvfeeVatAmount { get; set; }

        [JsonPropertyName("net_amount")]
        public decimal NetAmount { get; set; }
    }
}