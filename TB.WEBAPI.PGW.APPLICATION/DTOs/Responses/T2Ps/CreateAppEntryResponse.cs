using System.Text.Json.Serialization;

namespace TB.WEBAPI.PGW.APPLICATION.DTOs.Responses.T2Ps
{
    public class CreateAppEntryResponse
    {
        [JsonPropertyName("app_id")]
        public int AppId { get; set; }

        [JsonPropertyName("ref1_no")]
        public string? Ref1No { get; set; }

        [JsonPropertyName("ref2_no")]
        public string? Ref2No { get; set; }

        [JsonPropertyName("verify_id")]
        public string? VerifyId { get; set; }

        [JsonPropertyName("otp_code")]
        public string? OtpCode { get; set; }

        [JsonPropertyName("is_dup")]
        public bool IsDuplicate { get; set; }

        [JsonPropertyName("agent_code")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("premium_amt")]
        public double PremiumAmount { get; set; }

        [JsonPropertyName("cust_name")]
        public object? CustomerName { get; set; }

        [JsonPropertyName("prod_code")]
        public object? ProductCode { get; set; }

        [JsonPropertyName("prod_name")]
        public object? ProductName { get; set; }

        [JsonPropertyName("mobile_no")]
        public object? MobileNo { get; set; }

        [JsonPropertyName("payment_type")]
        public object? PaymentType { get; set; }

        [JsonPropertyName("instalment_mode")]
        public object? InstallmentMode { get; set; }

        [JsonPropertyName("bank_code")]
        public object? BankCode { get; set; }

        [JsonPropertyName("instalment_num")]
        public int InstallmentNumber { get; set; }

        [JsonPropertyName("payment_method")]
        public List<PaymentMethod>? PaymentMethods { get; set; }

        [JsonPropertyName("success")]
        public bool IsSuccess { get; set; }

        [JsonPropertyName("start_cover_date")]
        public object? StartCoverDate { get; set; }

        [JsonPropertyName("product_type")]
        public object? ProductType { get; set; }

        [JsonPropertyName("car_license_no")]
        public object? CarLicenseNo { get; set; }

        [JsonPropertyName("car_license_type")]
        public object? CarLicenesType { get; set; }
    }

    public class Bank
    {
        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        [JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        [JsonPropertyName("card_inst")]
        public double CardInstallment { get; set; }

        [JsonPropertyName("cust_inst")]
        public double CustomerInstallment { get; set; }

        [JsonPropertyName("inst_num")]
        public string? InstallmentNumber { get; set; }
    }

    public class PaymentMethod
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("payment_channel")]
        public string? PaymentChannel { get; set; }

        [JsonPropertyName("payment_channel_name")]
        public string? PaymentChannelName { get; set; }

        [JsonPropertyName("instalment_mode")]
        public string? InstallmentMode { get; set; }

        [JsonPropertyName("overdue_days")]
        public int OverDueDayes { get; set; }

        [JsonPropertyName("bank")]
        public List<Bank>? Bank { get; set; }

        [JsonPropertyName("plan_bank")]
        public List<PlanBank>? PkanBank { get; set; }

        [JsonPropertyName("discount_amt")]
        public double DiscountAmount { get; set; }

        [JsonPropertyName("total_amt")]
        public double TotalAmount { get; set; }
    }

    public class PlanBank
    {
        [JsonPropertyName("ipp_plan")]
        public int IppPlan { get; set; }

        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        [JsonPropertyName("credit_type")]
        public string? CreditType { get; set; }

        [JsonPropertyName("card_type")]
        public string? CardType { get; set; }

        [JsonPropertyName("card_code")]
        public string? CardCode { get; set; }

        [JsonPropertyName("card_interest")]
        public double CardInterest { get; set; }

        [JsonPropertyName("cust_interest")]
        public double CustInterest { get; set; }

        [JsonPropertyName("installment_num")]
        public string? InstallmentNumber { get; set; }

        [JsonPropertyName("channel_code")]
        public string? ChannelCode { get; set; }
    }
}