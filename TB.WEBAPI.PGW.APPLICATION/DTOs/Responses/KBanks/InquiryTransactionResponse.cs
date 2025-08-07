using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.KBanks
{
    public class InquiryTransactionResponse
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

        [JsonPropertyName("source")]
        public InquiryTransactionSource? Source { get; set; }

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

        [JsonPropertyName("settlement_info")]
        public InquiryTransactionSettlementInfo? SettlementInfo { get; set; }

        [JsonPropertyName("refund_info")]
        public List<InquiryTransactionRefundInfo>? RefundInfo { get; set; }

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

        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }

        [JsonPropertyName("campaign_id")]
        public string? CampaignId { get; set; }

        [JsonPropertyName("mpi")]
        public InquiryTransactionMpi? Mpi { get; set; }
    }

    public class InquiryTransactionSource
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

    public class InquiryTransactionSettlementInfo
    {
        [JsonPropertyName("settle_amount")]
        public int SettleAmount { get; set; }

        [JsonPropertyName("baht_amount")]
        public int BahtAmount { get; set; }

        [JsonPropertyName("exchange_rate")]
        public int ExchangeRate { get; set; }

        [JsonPropertyName("orig_amount")]
        public int OrigAmount { get; set; }

        [JsonPropertyName("orig_mdr")]
        public double OrigMdr { get; set; }

        [JsonPropertyName("orig_vat")]
        public double OrigVat { get; set; }

        [JsonPropertyName("orig_net_amount")]
        public double OrigNetAmount { get; set; }
    }

    public class InquiryTransactionRefundInfo
    {
        [JsonPropertyName("settle_amount")]
        public int SettleAmount { get; set; }

        [JsonPropertyName("baht_amount")]
        public int BahtAmount { get; set; }

        [JsonPropertyName("exchange_rate")]
        public int ExchangeRate { get; set; }

        [JsonPropertyName("orig_amount")]
        public int OrigAmount { get; set; }

        [JsonPropertyName("orig_mdr")]
        public double OrigMdr { get; set; }

        [JsonPropertyName("orig_vat")]
        public double OrigVat { get; set; }

        [JsonPropertyName("orig_net_amount")]
        public double OrigNetAmount { get; set; }

        [JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }
    }

    public class InquiryTransactionMpi
    {
        [JsonPropertyName("eci")]
        public string? Eci { get; set; }

        [JsonPropertyName("xid")]
        public string? Xid { get; set; }

        [JsonPropertyName("cavv")]
        public string? Cavv { get; set; }

        [JsonPropertyName("kbank_mpi")]
        public bool KbankMpi { get; set; }
    }
}