// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCompensationV1ArchivesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询员工薪资档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询员工薪资档案 响应体
/// <para>批量查询员工薪资档案</para>
/// <para>接口ID：7314129756769746948</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fquery</para>
/// </summary>
public record PostCompensationV1ArchivesQueryResponseDto
{
    /// <summary>
    /// <para>档案信息列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ArchiveDetail[] Items { get; set; } = Array.Empty<ArchiveDetail>();

    /// <summary>
    /// <para>档案信息列表</para>
    /// </summary>
    public record ArchiveDetail
    {
        /// <summary>
        /// <para>员工ID，返回的ID类型与查询参数中的「user_id_type」的取值一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：344325234123</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工薪资档案ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：32141234412</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工薪资档案版本ID，薪资档案唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：141541351</para>
        /// </summary>
        [JsonPropertyName("tid")]
        public string Tid { get; set; } = string.Empty;

        /// <summary>
        /// <para>关联薪资方案ID，详细信息可以通过[批量查询薪资方案](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：123412433</para>
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// <para>关联薪资方案版本ID，薪资方案唯一标识，详细信息可以通过[批量查询薪资方案](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：213412343</para>
        /// </summary>
        [JsonPropertyName("plan_tid")]
        public string PlanTid { get; set; } = string.Empty;

        /// <summary>
        /// <para>档案币种ID，详细信息可以通过[查询货币信息v2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：324167823</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string? CurrencyId { get; set; }

        /// <summary>
        /// <para>调薪原因ID，详细信息可以通过[批量查询定调薪原因](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/change_reason/list)接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：321414123</para>
        /// </summary>
        [JsonPropertyName("change_reason_id")]
        public string ChangeReasonId { get; set; } = string.Empty;

        /// <summary>
        /// <para>调薪说明</para>
        /// <para>必填：是</para>
        /// <para>示例值：长期表现优异，产出高，本次给出涨幅</para>
        /// </summary>
        [JsonPropertyName("change_description")]
        public string ChangeDescription { get; set; } = string.Empty;

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-10-23</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪级薪等ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：12342313</para>
        /// </summary>
        [JsonPropertyName("salary_level_id")]
        public string? SalaryLevelId { get; set; }

        /// <summary>
        /// <para>档案关联的薪资项</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("archive_items")]
        public ArchiveItem[] ArchiveItems { get; set; } = Array.Empty<ArchiveItem>();

        /// <summary>
        /// <para>档案关联的薪资项</para>
        /// </summary>
        public record ArchiveItem
        {
            /// <summary>
            /// <para>薪资项ID，详细信息可以通过[批量查询薪资项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list)接口查询获得</para>
            /// <para>必填：是</para>
            /// <para>示例值：213423144</para>
            /// </summary>
            [JsonPropertyName("item_id")]
            public string ItemId { get; set; } = string.Empty;

            /// <summary>
            /// <para>档案关联薪资项数值</para>
            /// <para>必填：是</para>
            /// <para>示例值：15000</para>
            /// </summary>
            [JsonPropertyName("item_result")]
            public string ItemResult { get; set; } = string.Empty;

            /// <summary>
            /// <para>档案关联薪资项转正后数值</para>
            /// <para>必填：否</para>
            /// <para>示例值：18000</para>
            /// </summary>
            [JsonPropertyName("item_result_regular")]
            public string? ItemResultRegular { get; set; }
        }

        /// <summary>
        /// <para>档案关联的薪资指标</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("archive_indicators")]
        public ArchiveIndicator[] ArchiveIndicators { get; set; } = Array.Empty<ArchiveIndicator>();

        /// <summary>
        /// <para>档案关联的薪资指标</para>
        /// </summary>
        public record ArchiveIndicator
        {
            /// <summary>
            /// <para>薪资统计指标ID，详细信息可以通过[批量查询薪资统计指标](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/indicator/list)接口查询获得</para>
            /// <para>必填：是</para>
            /// <para>示例值：23141423</para>
            /// </summary>
            [JsonPropertyName("indicator_id")]
            public string IndicatorId { get; set; } = string.Empty;

            /// <summary>
            /// <para>档案关联薪资统计指标数值</para>
            /// <para>必填：是</para>
            /// <para>示例值：15000</para>
            /// </summary>
            [JsonPropertyName("indicator_result")]
            public string IndicatorResult { get; set; } = string.Empty;

            /// <summary>
            /// <para>档案关联薪资统计指标转正后数值</para>
            /// <para>必填：否</para>
            /// <para>示例值：18000</para>
            /// </summary>
            [JsonPropertyName("indicator_result_regular")]
            public string? IndicatorResultRegular { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
