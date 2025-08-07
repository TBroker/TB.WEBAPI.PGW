using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks
{
    public class InquiryPaymentLinkResponse
    {
        [JsonPropertyName("status_code")]
        public string? StatusCode { get; set; }

        [JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        [JsonPropertyName("payment_link")]
        public InquiryPaymentLink? PaymentLink { get; set; }
    }

    public class InquiryPaymentLink
    {
        [JsonPropertyName("service_name")]
        public string? ServiceName { get; set; }

        [JsonPropertyName("link_ref")]
        public string? LinkRef { get; set; }

        [JsonPropertyName("link_url")]
        public string? LinkUrl { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("active_time")]
        public string? ActiveTime { get; set; }

        [JsonPropertyName("expire_time")]
        public string? ExpireTime { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("create_date")]
        public string? CreateDate { get; set; }

        [JsonPropertyName("reference_number")]
        public string? ReferenceNumber { get; set; }

        [JsonPropertyName("paid_time")]
        public int PaidTime { get; set; }

        [JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        [JsonPropertyName("ref_name_1")]
        public string? RefName1 { get; set; }

        [JsonPropertyName("ref_name_2")]
        public string? RefName2 { get; set; }

        [JsonPropertyName("ref_name_3")]
        public string? RefName3 { get; set; }

        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("merchant_name")]
        public string? MerchantName { get; set; }

        [JsonPropertyName("merchant_location")]
        public string? MerchantLocation { get; set; }

        [JsonPropertyName("source_of_fund")]
        public List<string>? SourceOfFund { get; set; }

        [JsonPropertyName("ref1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("card_smartpay")]
        public InquiryPaymentlinkCardSmartpay? CardSmartpay { get; set; }

        [JsonPropertyName("payment_detail")]
        public List<InquiryPaymentDetail>? PaymentDetail { get; set; }
    }

    public class InquiryPaymentlinkCardSmartpay
    {
        [JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        [JsonPropertyName("smartpay_id")]
        public string? SmartpayId { get; set; }
    }

    public class InquiryPaymentDetail
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("transaction_state")]
        public string? TransactionState { get; set; }

        [JsonPropertyName("source")]
        public InquiryPaymentlinkSource? Source { get; set; }
    }

    public class InquiryPaymentlinkSource
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