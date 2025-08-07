using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.T2Ps
{
    public class InquiryTransactionResponse
    {
        [JsonPropertyName("applications")]
        public List<Application>? Applications { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class Application
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("payment_ref1")]
        public string? PaymentRef1 { get; set; }

        [JsonPropertyName("payment_ref2")]
        public string? PaymentRef2 { get; set; }

        [JsonPropertyName("appl_no")]
        public string? ApplNo { get; set; }

        [JsonPropertyName("appl_date")]
        public string? ApplDate { get; set; }

        [JsonPropertyName("inform_date")]
        public string? InformDate { get; set; }

        [JsonPropertyName("channel_code")]
        public string? ChannelCode { get; set; }

        [JsonPropertyName("channel_name")]
        public string? ChannelName { get; set; }

        [JsonPropertyName("seller_code")]
        public string? SellerCode { get; set; }

        [JsonPropertyName("seller_name")]
        public string? SellerName { get; set; }

        [JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        [JsonPropertyName("product_code")]
        public string? ProductCode { get; set; }

        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("package_code")]
        public string? PackageCode { get; set; }

        [JsonPropertyName("package_name")]
        public string? PackageName { get; set; }

        [JsonPropertyName("assure_name")]
        public string? AssureName { get; set; }

        [JsonPropertyName("cover_year")]
        public int CoverYear { get; set; }

        [JsonPropertyName("mobile_no")]
        public string? MobileNo { get; set; }

        [JsonPropertyName("email_addr")]
        public string? EmailAddr { get; set; }

        [JsonPropertyName("premium_amt")]
        public double PremiumAmt { get; set; }

        [JsonPropertyName("start_cover_date")]
        public string? StartCoverDate { get; set; }

        [JsonPropertyName("end_cover_date")]
        public string? EndCoverDate { get; set; }

        [JsonPropertyName("payment_status")]
        public string? PaymentStatus { get; set; }

        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        [JsonPropertyName("car_license_no")]
        public string? CarLicenseNo { get; set; }

        [JsonPropertyName("car_license_type")]
        public string? CarLicenseType { get; set; }

        [JsonPropertyName("payment_notify")]
        public string? PaymentNotify { get; set; }

        [JsonPropertyName("payment_notify_desc")]
        public string? PaymentNotifyDesc { get; set; }

        [JsonPropertyName("otp_login")]
        public int OtpLogin { get; set; }

        [JsonPropertyName("payment_date")]
        public string? PaymentDate { get; set; }

        [JsonPropertyName("payment_type")]
        public string? PaymentType { get; set; }

        [JsonPropertyName("instalment_mode")]
        public string? InstalmentMode { get; set; }

        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        [JsonPropertyName("instalment_num")]
        public int InstalmentNum { get; set; }

        [JsonPropertyName("approve_code")]
        public string? ApproveCode { get; set; }

        [JsonPropertyName("sms_message")]
        public string? SmsMessage { get; set; }

        [JsonPropertyName("otp_verify_link")]
        public string? OtpVerifyLink { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("payment_channel")]
        public string? PaymentChannel { get; set; }

        [JsonPropertyName("agent_code")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("paid_channel")]
        public string? PaidChannel { get; set; }

        [JsonPropertyName("uid")]
        public string? Uid { get; set; }
    }
}