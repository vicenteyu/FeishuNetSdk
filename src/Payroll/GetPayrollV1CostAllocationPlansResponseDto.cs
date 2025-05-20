// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-15
//
// Last Modified By : yxr
// Last Modified On : 2024-07-15
// ************************************************************************
// <copyright file="GetPayrollV1CostAllocationPlansResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询成本分摊方案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询成本分摊方案 响应体
/// <para>根据期间分页批量查询成本分摊方案，仅返回期间内生效的方案列表。</para>
/// <para>接口ID：7319164056023269404</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/cost_allocation_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fcost_allocation_plan%2flist</para>
/// </summary>
public record GetPayrollV1CostAllocationPlansResponseDto : IPageableResponse<GetPayrollV1CostAllocationPlansResponseDto.CostAllocationPlan>
{
    /// <summary>
    /// <para>方案</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CostAllocationPlan[]? Items { get; set; }

    /// <summary>
    /// <para>方案</para>
    /// </summary>
    public record CostAllocationPlan
    {
        /// <summary>
        /// <para>成本分摊方案id，唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：6823630319749593096</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>方案名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18nContent[]? Names { get; set; }

        /// <summary>
        /// <para>方案名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语种</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// <para>默认值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语种对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>适用国家ID，通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6823630319749593389</para>
        /// <para>最大长度：3000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("applicable_country_region")]
        public string? ApplicableCountryRegion { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6823630319749592467</para>
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
}
