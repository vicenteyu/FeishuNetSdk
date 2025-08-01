// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2JobFamiliesQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围序列版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围序列版本 响应体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>- 适用于需要回顾某段时间内对象版本变化的场景</para>
/// <para>接口ID：7473071080241561604</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2JobFamiliesQueryMultiTimelineResponseDto
{
    /// <summary>
    /// <para>序列信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobFamilyTimeline[]? Items { get; set; }

    /// <summary>
    /// <para>序列信息</para>
    /// </summary>
    public record JobFamilyTimeline
    {
        /// <summary>
        /// <para>序列版本信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("job_family_version_data")]
        public JobFamilyVersionData[]? JobFamilyVersionDatas { get; set; }

        /// <summary>
        /// <para>序列版本信息</para>
        /// </summary>
        public record JobFamilyVersionData
        {
            /// <summary>
            /// <para>序列 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("job_family_id")]
            public string? JobFamilyId { get; set; }

            /// <summary>
            /// <para>序列版本 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7238516215202170412</para>
            /// </summary>
            [JsonPropertyName("job_family_version_id")]
            public string? JobFamilyVersionId { get; set; }

            /// <summary>
            /// <para>序列名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("job_family_names")]
            public I18n[]? JobFamilyNames { get; set; }

            /// <summary>
            /// <para>序列名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>- 中文用zh-CN，英文用en-US。</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：技术序列</para>
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
            /// <para>是否可被使用，true为可被使用，false为不可被使用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("selectable")]
            public bool? Selectable { get; set; }

            /// <summary>
            /// <para>上级序列 ID，详细信息可通过[【查询单个序列】](/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：4698020757495316313</para>
            /// </summary>
            [JsonPropertyName("parent_job_family_id")]
            public string? ParentJobFamilyId { get; set; }

            /// <summary>
            /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("pathway_ids")]
            public string[]? PathwayIds { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：123456</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }
        }
    }
}
