// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索成本中心信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索成本中心信息 响应体
/// <para>搜索成本中心信息；支持通过成本中心ID，成本中心名称，成本中心编码，成本中心上级搜索成本中心的信息，有分页功能。</para>
/// <para>接口ID：7225452763517075459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fsearch</para>
/// </summary>
public record PostCorehrV2CostCentersSearchResponseDto : IPageableResponse<PostCorehrV2CostCentersSearchResponseDto.CostCenterVersion>
{
    /// <summary>
    /// <para>成本中心信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CostCenterVersion[]? Items { get; set; }

    /// <summary>
    /// <para>成本中心信息</para>
    /// </summary>
    public record CostCenterVersion
    {
        /// <summary>
        /// <para>成本中心ID</para>
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
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>成本中心名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>信息的语言，支持中文和英文。中文用zh-CN；英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
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
        /// <para>成本中心负责人ID 列表，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("managers")]
        public string[]? Managers { get; set; }

        /// <summary>
        /// <para>成本中心描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

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
