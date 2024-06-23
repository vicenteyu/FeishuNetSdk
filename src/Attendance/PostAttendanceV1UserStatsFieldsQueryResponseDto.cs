// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserStatsFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询统计表头 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计表头 响应体
/// <para>查询考勤统计支持的日度统计或月度统计的统计表头。</para>
/// <para>接口ID：7044467124773814273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_field%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsFieldsQueryResponseDto
{
    /// <summary>
    /// <para>统计数据表头</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_stats_field")]
    public PostAttendanceV1UserStatsFieldsQueryResponseDtoUserStatsField? UserStatsField { get; set; }

    /// <summary>
    /// <para>统计数据表头</para>
    /// </summary>
    public record PostAttendanceV1UserStatsFieldsQueryResponseDtoUserStatsField
    {
        /// <summary>
        /// <para>统计类型</para>
        /// <para>必填：是</para>
        /// <para>示例值："daily"</para>
        /// <para>可选值：<list type="bullet">
        /// <item>daily：日度统计</item>
        /// <item>month：月度统计</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("stats_type")]
        public string StatsType { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID，字段已废弃</para>
        /// <para>必填：是</para>
        /// <para>示例值：""</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public Field[] Fields { get; set; } = Array.Empty<Field>();

        /// <summary>
        /// <para>字段列表</para>
        /// </summary>
        public record Field
        {
            /// <summary>
            /// <para>字段编号</para>
            /// <para>必填：是</para>
            /// <para>示例值：50121</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：工号</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// <para>子字段列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("child_fields")]
            public ChildField[]? ChildFields { get; set; }

            /// <summary>
            /// <para>子字段列表</para>
            /// </summary>
            public record ChildField
            {
                /// <summary>
                /// <para>子字段编号</para>
                /// <para>必填：是</para>
                /// <para>示例值：50121</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string Code { get; set; } = string.Empty;

                /// <summary>
                /// <para>子字段名称</para>
                /// <para>必填：是</para>
                /// <para>示例值：工号</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// <para>时间单位(该字段已停止使用)</para>
                /// <para>必填：否</para>
                /// <para>示例值："Minute"</para>
                /// </summary>
                [JsonPropertyName("time_unit")]
                public string? TimeUnit { get; set; }
            }
        }
    }
}
