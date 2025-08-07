using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.KBanks
{
    public class CreatePaymentLinkRequest
    {
        [JsonPropertyName("service_name")]
        public string? ServiceName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("amount")]
        public string? Amount { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("active_time")]
        public string? ActiveTime { get; set; }

        [JsonPropertyName("expire_time")]
        public string? ExpireTime { get; set; }

        [JsonPropertyName("reference_number")]
        public string? ReferenceNumber { get; set; }

        [JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        [JsonPropertyName("merchant_name")]
        public string? MerchantName { get; set; }

        [JsonPropertyName("merchant_location")]
        public string? MerchantLocation { get; set; }

        [JsonPropertyName("source_of_fund")]
        public List<string>? SourceOfFund { get; set; }

        [JsonPropertyName("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("card_smartpay")]
        public CardSmartpay? CardSmartpay { get; set; }

        [JsonPropertyName("payplus_kplus")]
        public PayplusKplus? PayplusKplus { get; set; }

        [JsonPropertyName("payplus_promptpay")]
        public PayplusPromptpay? PayplusPromptpay { get; set; }
    }

    public class CardSmartpay
    {
        [JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        [JsonPropertyName("plan_id")]
        public string? PlanId { get; set; }

        [JsonPropertyName("ipan_mode")]
        public string? IpanMode { get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        [JsonPropertyName("payment_term")]
        public string? PaymentTerm { get; set; }

        [JsonPropertyName("supplier_no")]
        public string? SupplierNo { get; set; }

        [JsonPropertyName("model_no")]
        public string? ModelNo { get; set; }
    }

    public class PayplusKplus
    {
        [JsonPropertyName("compcode")]
        public string? Compcode { get; set; }
    }

    public class PayplusPromptpay
    {
        [JsonPropertyName("compcode")]
        public string? Compcode { get; set; }
    }
}