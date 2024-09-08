// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1JobFamiliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询序列 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询序列 响应体
/// <para>该接口支持获取租户下的所有序列信息。序列数量过多时，可以通过多次循环调用该接口获取所有序列详情信息，包括序列编码、名称等。</para>
/// <para>接口ID：7017694651622146052</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2flist</para>
/// </summary>
public record GetCorehrV1JobFamiliesResponseDto
{
    /// <summary>
    /// <para>查询的序列信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobFamily[]? Items { get; set; }

    /// <summary>
    /// <para>查询的序列信息</para>
    /// </summary>
    public record JobFamily
    {
        /// <summary>
        /// <para>序列 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698019107896524633</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言，中文zh-CN，英文en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：管理序列</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>上级序列ID</para>
        /// <para>- 可通过[批量查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698020757495316313</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>当前版本生效时间</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前版本失效时间</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02 00:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>序列编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>自定义字段（暂时不支持该功能）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段（暂时不支持该功能）</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>自定义字段 API Name，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
