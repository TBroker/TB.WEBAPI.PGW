using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.DOMAIN.Entities
{
    public class WebPaymentNotifyCardKBank
    {
        [Key]
        [JsonPropertyName("id")]
        [Column("id")]
        public string? Id { get; set; }

        [JsonPropertyName("transaction_id")]
        [Column("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("date_create")]
        [Column("date_create")]
        public DateTime? DateCreate { get; set; }

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

        [JsonPropertyName("created")]
        [Column("created")]
        public string? Created { get; set; }

        [JsonPropertyName("status")]
        [Column("status")]
        public string? Status { get; set; }

        [JsonPropertyName("reference_order")]
        [Column("reference_order")]
        public string? ReferenceOrder { get; set; }

        [JsonPropertyName("description")]
        [Column("description")]
        public string? Description { get; set; }

        [JsonPropertyName("redirect_url")]
        [Column("redirect_url")]
        public string? RedirectUrl { get; set; }

        [JsonPropertyName("approval_code")]
        [Column("approval_code")]
        public string? ApprovalCode { get; set; }

        [JsonPropertyName("ref_1")]
        [Column("ref_1")]
        public string? Ref1 { get; set; }

        [JsonPropertyName("ref_2")]
        [Column("ref_2")]
        public string? Ref2 { get; set; }

        [JsonPropertyName("ref_3")]
        [Column("ref_3")]
        public string? Ref3 { get; set; }

        [JsonPropertyName("livemode")]
        [Column("livemode")]
        public string? Livemode { get; set; }

        [JsonPropertyName("failure_code")]
        [Column("failure_code")]
        public string? FailureCode { get; set; }

        [JsonPropertyName("failure_message")]
        [Column("failure_message")]
        public string? FailureMessage { get; set; }

        [JsonPropertyName("campaign_id")]
        [Column("campaign_id")]
        public string? CampaignId { get; set; }

        [JsonPropertyName("mpi_eci")]
        [Column("mpi_eci")]
        public string? MpiEci { get; set; }

        [JsonPropertyName("mpi_xid")]
        [Column("mpi_xid")]
        public string? MpiXid { get; set; }

        [JsonPropertyName("mpi_cavv")]
        [Column("mpi_cavv")]
        public string? MpiCavv { get; set; }

        [JsonPropertyName("mpi_kbank_mpi")]
        [Column("mpi_kbank_mpi")]
        public string? MpiKbankMpi { get; set; }

        [JsonPropertyName("checksum")]
        [Column("checksum")]
        public string? Checksum { get; set; }
    }
}