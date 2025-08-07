using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps
{
    public class HookT2PNotifyRequest
    {
        [JsonPropertyName("confirm_msg")]
        public string? ConfirmMessage { get; set; }

        [JsonPropertyName("payment_ref1")]
        public string? PaymentRef1 { get; set; }

        [JsonPropertyName("payment_ref2")]
        public string? PaymentRef2 { get; set; }

        [JsonPropertyName("payment_date")]
        public string? PaymentDate { get; set; }

        [JsonPropertyName("approve_status")]
        public string? ApproveStatus { get; set; }

        [JsonPropertyName("approve_code")]
        public string? ApproveCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        [JsonPropertyName("channel_code")]
        public string? ChannelCode { get; set; }

        [JsonPropertyName("instal_mode")]
        public string? InstallmentMode { get; set; }

        [JsonPropertyName("inst_num")]
        public string? InstallmentNumber { get; set; }

        [JsonPropertyName("inst_amt")]
        public string? InstallmentAmount { get; set; }

        [JsonPropertyName("payment_amt")]
        public string? PaymentAmount { get; set; }

        [JsonPropertyName("payment_channel")]
        public string? PaymentChannel { get; set; }

        [JsonPropertyName("payment_type")]
        public string? PaymentType { get; set; }
    }
}