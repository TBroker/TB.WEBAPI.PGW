using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Requests.T2Ps
{
    public class CreateAppEntryRequest
    {
        [JsonPropertyName("payment_ref1")]
        public string? PaymentRef1 { get; set; }

        [JsonPropertyName("payment_ref2")]
        public string? PaymentRef2 { get; set; }

        [JsonPropertyName("channel_code")]
        public string? ChannelCode { get; set; }

        [JsonPropertyName("appl_no")]
        public string? ApplicationNo { get; set; }

        [JsonPropertyName("appl_date")]
        public string? ApplicationDate { get; set; }

        [JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        [JsonPropertyName("product_code")]
        public string? ProductCode { get; set; }

        [JsonPropertyName("start_cover_date")]
        public string? StartCoverDate { get; set; }

        [JsonPropertyName("assure_name")]
        public string? AssureName { get; set; }

        [JsonPropertyName("mobile_no")]
        public string? MobileNo { get; set; }

        [JsonPropertyName("email_addr")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("premium_amt")]
        public string? PremiumsAmount { get; set; }

        [JsonPropertyName("payment_notify")]
        public string? PaymentNotify { get; set; }

        [JsonPropertyName("car_license_no")]
        public string? CarLicenseNo { get; set; }

        [JsonPropertyName("car_license_type")]
        public string? CarLicenseType { get; set; }
    }
}