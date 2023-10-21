using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 操作候选人入职 响应体
/// <para>根据投递 ID 操作候选人入职并创建员工。投递须处于「待入职」阶段，可通过「转移阶段」接口变更投递状态。</para>
/// <para>接口ID：6964286393804800028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/transfer_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_onboard</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdTransferOnboardResponseDto
{
    /// <summary>
    /// <para>employee</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employee")]
    public PostHireV1ApplicationsByApplicationIdTransferOnboardResponseDtoEmployee? Employee { get; set; }

    /// <summary>
    /// <para>employee</para>
    /// </summary>
    public record PostHireV1ApplicationsByApplicationIdTransferOnboardResponseDtoEmployee
    {
        /// <summary>
        /// <para>员工ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7095600054216542508</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7073372582620416300</para>
        /// </summary>
        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>入职状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已入职</item>
        /// <item>2：已离职</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("onboard_status")]
        public int? OnboardStatus { get; set; }

        /// <summary>
        /// <para>转正状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未转正</item>
        /// <item>2：已转正</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("conversion_status")]
        public int? ConversionStatus { get; set; }

        /// <summary>
        /// <para>实际入职时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonProperty("onboard_time")]
        public int? OnboardTime { get; set; }

        /// <summary>
        /// <para>预期转正时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonProperty("expected_conversion_time")]
        public int? ExpectedConversionTime { get; set; }

        /// <summary>
        /// <para>实际转正时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonProperty("actual_conversion_time")]
        public int? ActualConversionTime { get; set; }

        /// <summary>
        /// <para>离职时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonProperty("overboard_time")]
        public int? OverboardTime { get; set; }

        /// <summary>
        /// <para>离职原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：职业发展考虑</para>
        /// </summary>
        [JsonProperty("overboard_note")]
        public string? OverboardNote { get; set; }

        /// <summary>
        /// <para>办公地点</para>
        /// <para>必填：否</para>
        /// <para>示例值：CT_2</para>
        /// </summary>
        [JsonProperty("onboard_city_code")]
        public string? OnboardCityCode { get; set; }

        /// <summary>
        /// <para>入职部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966123381141866028</para>
        /// </summary>
        [JsonProperty("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>直属上级</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-xxx</para>
        /// </summary>
        [JsonProperty("leader")]
        public string? Leader { get; set; }

        /// <summary>
        /// <para>序列</para>
        /// <para>必填：否</para>
        /// <para>示例值：6937934036379650311</para>
        /// </summary>
        [JsonProperty("sequence")]
        public string? Sequence { get; set; }

        /// <summary>
        /// <para>职级</para>
        /// <para>必填：否</para>
        /// <para>示例值：7006234385490345986</para>
        /// </summary>
        [JsonProperty("level")]
        public string? Level { get; set; }

        /// <summary>
        /// <para>员工类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("employee_type")]
        public string? EmployeeType { get; set; }
    }
}
