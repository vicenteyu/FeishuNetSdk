// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1LumpSumPaymentQueryDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询一次性支付授予明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 查询一次性支付授予明细 响应体
/// <para>根据筛选条件查询一次性授予明细</para>
/// <para>接口ID：7429528484932796444</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/query_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fquery_detail</para>
/// </summary>
public record PostCompensationV1LumpSumPaymentQueryDetailResponseDto : IPageableResponse<PostCompensationV1LumpSumPaymentQueryDetailResponseDto.LumpSumPaymentDetail>
{
    /// <summary>
    /// <para>一次性支付授予明细列表</para>
    /// </summary>
    [JsonIgnore]
    public LumpSumPaymentDetail[]? Items => Records;

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>一次性支付授予明细列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("records")]
    public LumpSumPaymentDetail[]? Records { get; set; }

    /// <summary>
    /// <para>一次性支付授予明细列表</para>
    /// </summary>
    public record LumpSumPaymentDetail
    {
        /// <summary>
        /// <para>一次性支付记录明细id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7395133551102200876</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>一次性支付记录id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7395133551102168108</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>员工id，具体类型由入参中的 user_id_type 指定</para>
        /// <para>必填：否</para>
        /// <para>示例值：7337149697626801708</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>一次性支付明细发放金额，可转数字的字符串</para>
        /// <para>必填：否</para>
        /// <para>示例值：2000.00</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("issuance_amount")]
        public string? IssuanceAmount { get; set; }

        /// <summary>
        /// <para>发放状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：to_be_issued</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>to_be_issued：应发放</item>
        /// <item>not_issued：不发放</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_status")]
        public string? IssuanceStatus { get; set; }

        /// <summary>
        /// <para>发放方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：with_salary</para>
        /// <para>可选值：<list type="bullet">
        /// <item>with_salary：随工资发放</item>
        /// <item>with_cash：现金发放</item>
        /// <item>with_year_end_bonus：随年终奖发放</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("issuance_way")]
        public string? IssuanceWay { get; set; }

        /// <summary>
        /// <para>发放日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-08-01</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("issuance_time")]
        public string? IssuanceTime { get; set; }

        /// <summary>
        /// <para>币种id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863329932261459464</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string? CurrencyId { get; set; }

        /// <summary>
        /// <para>申请发放日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2025-01-20</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("belong_time")]
        public string? BelongTime { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-08-01 12:34:56</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-08-01 12:34:56</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>发放国家ID（可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)进行查询）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("issuance_country_region_id")]
        public string? IssuanceCountryRegionId { get; set; }

        /// <summary>
        /// <para>发放薪资组ID（可通过[获取薪资组基本信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/paygroup/list)</para>
        /// <para>进行查询）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("issuance_pay_group_id")]
        public string? IssuancePayGroupId { get; set; }
    }
}
