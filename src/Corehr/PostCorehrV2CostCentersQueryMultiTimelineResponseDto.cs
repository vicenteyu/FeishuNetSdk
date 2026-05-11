// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询成本中心版本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询成本中心版本信息 响应体
/// <para>根据成本中心 ID 列表，批量查询开始结束时间内的所有成本中心版本信息，含成本中心名称、编码、上级成本中心、负责人、版本生效日期、版本失效日期、是否启用、描述等信息。</para>
/// <para>接口ID：7637139455451122649</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2CostCentersQueryMultiTimelineResponseDto : IPageableResponse<PostCorehrV2CostCentersQueryMultiTimelineResponseDto.CostCenterTimeline>
{
    /// <summary>
    /// <para>成本中心信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CostCenterTimeline[]? Items { get; set; }

    /// <summary>
    /// <para>成本中心信息</para>
    /// </summary>
    public record CostCenterTimeline
    {
        /// <summary>
        /// <para>成本中心ID，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969828847121885087</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>成本中心版本ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969828847121885087</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>成本中心名称</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = [];

        /// <summary>
        /// <para>成本中心名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言，支持中文和英文。中文用zh-CN；英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDPD00000023</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>上级成本中心ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("parent_cost_center_id")]
        public string? ParentCostCenterId { get; set; }

        /// <summary>
        /// <para>成本中心负责人ID 列表，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("managers")]
        public string[]? Managers { get; set; }

        /// <summary>
        /// <para>成本中心描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>版本生效日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>版本失效日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// <para>当前实体是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6969828847121885087</para>
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
