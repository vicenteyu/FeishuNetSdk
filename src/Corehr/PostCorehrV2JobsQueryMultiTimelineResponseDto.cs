// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2JobsQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围职务版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围职务版本 响应体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本（即：会查询出生效时间段和查询时间段有交集的版本）</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>接口ID：7473071080241577988</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2JobsQueryMultiTimelineResponseDto
{
    /// <summary>
    /// <para>职务信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobTimeline[]? Items { get; set; }

    /// <summary>
    /// <para>职务信息</para>
    /// </summary>
    public record JobTimeline
    {
        /// <summary>
        /// <para>职务版本信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("job_version_data")]
        public JobVersionData[]? JobVersionDatas { get; set; }

        /// <summary>
        /// <para>职务版本信息</para>
        /// </summary>
        public record JobVersionData
        {
            /// <summary>
            /// <para>职务 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>职务版本 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7238516215202170412</para>
            /// </summary>
            [JsonPropertyName("job_version_id")]
            public string? JobVersionId { get; set; }

            /// <summary>
            /// <para>职务名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("job_names")]
            public I18n[]? JobNames { get; set; }

            /// <summary>
            /// <para>职务名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言信息，中文：zh-CN，英文en-US</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：软件工程师</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>当前版本生效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01</para>
            /// </summary>
            [JsonPropertyName("effective_date")]
            public string? EffectiveDate { get; set; }

            /// <summary>
            /// <para>当前版本失效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02</para>
            /// </summary>
            [JsonPropertyName("expiration_date")]
            public string? ExpirationDate { get; set; }

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("descriptions")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：BD38591</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>职务头衔</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("job_titles")]
            public I18n[]? JobTitles { get; set; }

            /// <summary>
            /// <para>序列ID</para>
            /// <para>- 可通过[批量查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)获取详情</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_family_ids")]
            public string[]? JobFamilyIds { get; set; }

            /// <summary>
            /// <para>职级ID</para>
            /// <para>- 可通过[批量查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)获取详情</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_level_ids")]
            public string[]? JobLevelIds { get; set; }

            /// <summary>
            /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719519211875096301</para>
            /// </summary>
            [JsonPropertyName("pathway_id")]
            public string? PathwayId { get; set; }

            /// <summary>
            /// <para>工时制度 ID，详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890452208593372679</para>
            /// </summary>
            [JsonPropertyName("working_hours_type_id")]
            public string? WorkingHoursTypeId { get; set; }
        }
    }
}
