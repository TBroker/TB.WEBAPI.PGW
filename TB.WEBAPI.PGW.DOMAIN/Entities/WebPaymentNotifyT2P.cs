using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.DOMAIN.Entities
{
    [Table("web_payment_notify_t2p")]
    public class WebPaymentNotifyT2P
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

        [Column("confirm_msg")]
        [JsonPropertyName("confirm_msg")]
        public string? ConfirmMessage { get; set; }

        [Column("payment_ref1")]
        [JsonPropertyName("payment_ref1")]
        public string? PaymentRef1 { get; set; }

        [Column("payment_ref2")]
        [JsonPropertyName("payment_ref2")]
        public string? PaymentRef2 { get; set; }

        [Column("payment_date")]
        [JsonPropertyName("payment_date")]
        public string? PaymentDate { get; set; }

        [Column("approve_status")]
        [JsonPropertyName("approve_status")]
        public string? ApproveStatus { get; set; }

        [Column("approve_code")]
        [JsonPropertyName("approve_code")]
        public string? ApproveCode { get; set; }

        [Column("bank_code")]
        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        [Column("channel_code")]
        [JsonPropertyName("channel_code")]
        public string? ChannelCode { get; set; }

        [Column("instal_mode")]
        [JsonPropertyName("instal_mode")]
        public string? InstallmentMode { get; set; }

        [Column("inst_num")]
        [JsonPropertyName("inst_num")]
        public string? InstallmentNumber { get; set; }

        [Column("inst_amt")]
        [JsonPropertyName("inst_amt")]
        public string? InstallmentAmount { get; set; }

        [Column("payment_amt")]
        [JsonPropertyName("payment_amt")]
        public string? PaymentAmount { get; set; }

        [Column("payment_channel")]
        [JsonPropertyName("payment_channel")]
        public string? PaymentChannel { get; set; }

        [Column("payment_type")]
        [JsonPropertyName("payment_type")]
        public string? PaymentType { get; set; }
    }
}