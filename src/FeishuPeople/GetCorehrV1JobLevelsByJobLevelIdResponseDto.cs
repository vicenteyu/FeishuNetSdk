// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="GetCorehrV1JobLevelsByJobLevelIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单个职级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个职级 响应体
/// <para>该接口支持通过职级id 查询单个职级详情信息，包括职级包含的名称、描述、启用状态等。</para>
/// <para>接口ID：7017694651621916676</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2fget</para>
/// </summary>
public record GetCorehrV1JobLevelsByJobLevelIdResponseDto
{
    /// <summary>
    /// <para>职级信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_level")]
    public GetCorehrV1JobLevelsByJobLevelIdResponseDtoJobLevel? JobLevel { get; set; }

    /// <summary>
    /// <para>职级信息</para>
    /// </summary>
    public record GetCorehrV1JobLevelsByJobLevelIdResponseDtoJobLevel
    {
        /// <summary>
        /// <para>职级 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692446793125560154</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职级数值</para>
        /// <para>必填：是</para>
        /// <para>示例值：9999</para>
        /// </summary>
        [JsonPropertyName("level_order")]
        public int LevelOrder { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

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
            /// <para>中文为zh-CN，英文为en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>是否启用，true为启用，false为停用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>自定义字段（职级暂时不支持）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段（职级暂时不支持）</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
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

        /// <summary>
        /// <para>职等 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_grade")]
        public string[]? JobGrade { get; set; }

        /// <summary>
        /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("pathway_ids")]
        public string[]? PathwayIds { get; set; }
    }
}
