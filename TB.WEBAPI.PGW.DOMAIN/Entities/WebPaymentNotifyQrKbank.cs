using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.DOMAIN.Entities
{
    [Table("web_payment_notify_qr_kbank")]
    public class WebPaymentNotifyQrKbank
    {
        [Key]
        [Column("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [Column("transaction_id")]
        [JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("date_create")]
        [JsonPropertyName("date_create")]
        public DateTime DateCreate { get; set; }

        [Column("order_id")]
        [JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        [Column("object")]
        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [Column("amount")]
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [Column("currency")]
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [Column("transaction_state")]
        [JsonPropertyName("transaction_state")]
        public string? TransactionState { get; set; }

        [Column("source_id")]
        [JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        [Column("source_object")]
        [JsonPropertyName("source_object")]
        public string? SourceObject { get; set; }

        [Column("source_brand")]
        [JsonPropertyName("source_brand")]
        public string? SourceBrand { get; set; }

        [Column("created")]
        [JsonPropertyName("created")]
        public string? Created { get; set; }

        [Column("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [Column("reference_order")]
        [JsonPropertyName("reference_order")]
        public string? ReferenceOrder { get; set; }

        [Column("description")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [Column("livemode")]
        [JsonPropertyName("livemode")]
        public string? LiveMode { get; set; }

        [Column("failure_code")]
        [JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        [Column("failure_message")]
        [JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }

        [Column("checksum")]
        [JsonPropertyName("checksum")]
        public string? Checksum { get; set; }
    }
}