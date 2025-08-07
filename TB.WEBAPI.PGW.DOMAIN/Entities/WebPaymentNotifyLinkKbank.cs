using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.DOMAIN.Entities
{
    public class WebPaymentNotifyLinkKbank
    {
        [JsonPropertyName("transaction_id")]
        [Column("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("date_create")]
        [Column("date_create")]
        public DateTime? DateCreate { get; set; }

        [Key]
        [JsonPropertyName("id")]
        [Column("id")]
        public string? Id { get; set; }

        [JsonPropertyName("object")]
        [Column("object")]
        public string? Object { get; set; }

        [JsonPropertyName("amount")]
        [Column("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("currency")]
        [Column("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("transaction_state")]
        [Column("transaction_state")]
        public string? TransactionState { get; set; }

        [JsonPropertyName("created")]
        [Column("created")]
        public string? Created { get; set; }

        [JsonPropertyName("status")]
        [Column("status")]
        public string? Status { get; set; }

        [JsonPropertyName("failure_code")]
        [Column("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        [Column("failure_message")]
        public string? FailureMessage { get; set; }

        [JsonPropertyName("checksum")]
        [Column("checksum")]
        public string? Checksum { get; set; }

        [JsonPropertyName("metadata")]
        [Column("metadata")]
        public string? Metadata { get; set; }

        [JsonPropertyName("livemode")]
        [Column("livemode")]
        public string? Livemode { get; set; }

        [JsonPropertyName("reference_order")]
        [Column("reference_order")]
        public string? ReferenceOrder { get; set; }

        [JsonPropertyName("ref_1")]
        [Column("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        [Column("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("ref_3")]
        [Column("ref_3")]
        public string? Ref3 { get; set; }

        [JsonPropertyName("description")]
        [Column("description")]
        public string? Description { get; set; }

        [JsonPropertyName("source_id")]
        [Column("source_id")]
        public string? SourceId { get; set; }

        [JsonPropertyName("source_object")]
        [Column("source_object")]
        public string? SourceObject { get; set; }

        [JsonPropertyName("source_brand")]
        [Column("source_brand")]
        public string? SourceBrand { get; set; }

        [JsonPropertyName("source_card_masking")]
        [Column("source_card_masking")]
        public string? SourceCardMasking { get; set; }

        [JsonPropertyName("source_issuer_bank")]
        [Column("source_issuer_bank")]
        public string? SourceIssuerBank { get; set; }

        [JsonPropertyName("redirect_url")]
        [Column("redirect_url")]
        public string? RedirectUrl { get; set; }

        [JsonPropertyName("campaign_id")]
        [Column("campaign_id")]
        public string? CampaignId { get; set; }

        [JsonPropertyName("convfee_amount")]
        [Column("convfee_amount")]
        public decimal? ConvfeeAmount { get; set; }

        [JsonPropertyName("convfee_vat_amount")]
        [Column("convfee_vat_amount")]
        public decimal? ConvfeeVatAmount { get; set; }

        [JsonPropertyName("convfee_net_amount")]
        [Column("convfee_net_amount")]
        public decimal? ConvfeeNetAmount { get; set; }

        [JsonPropertyName("link_ref")]
        [Column("link_ref")]
        public string? LinkRef { get; set; }
    }
}