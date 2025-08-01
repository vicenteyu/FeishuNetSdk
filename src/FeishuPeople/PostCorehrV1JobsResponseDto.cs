// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PostCorehrV1JobsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建职务 响应体
/// <para>该接口用于创建职务信息，创建后系统中新增一条包含职务编码、名称、描述等信息的职务记录，适用于企业新增职务类型时，HR需要创建职务信息以便分配给员工的场景</para>
/// <para>接口ID：7017707615191040003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2fcreate</para>
/// </summary>
public record PostCorehrV1JobsResponseDto
{
    /// <summary>
    /// <para>创建成功的Job信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job")]
    public PostCorehrV1JobsResponseDtoJob? Job { get; set; }

    /// <summary>
    /// <para>创建成功的Job信息</para>
    /// </summary>
    public record PostCorehrV1JobsResponseDtoJob
    {
        /// <summary>
        /// <para>职务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698040628992333549</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职务编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：JP422119</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>软件工程师</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>软件工程师</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言信息，中文用zh-CN，英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容，最小1字符，最大100字符</para>
            /// <para>必填：是</para>
            /// <para>示例值：软件工程师</para>
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
        /// <para>职务头衔</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public I18n[]? JobTitles { get; set; }

        /// <summary>
        /// <para>通道ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// <para>职务序列 ID 列表</para>
        /// <para>- 可通过[批量查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：7373183781</para>
        /// </summary>
        [JsonPropertyName("job_family_id_list")]
        public string[]? JobFamilyIdList { get; set; }

        /// <summary>
        /// <para>职务级别 ID 列表</para>
        /// <para>- 可通过[批量查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：316316317</para>
        /// </summary>
        [JsonPropertyName("job_level_id_list")]
        public string[]? JobLevelIdList { get; set; }

        /// <summary>
        /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>版本生效日期（UTC+8）</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
        /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>版本失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
        /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>自定义字段，格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段，格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块</para>
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
    }
}
