// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserStatsViewsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询统计设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计设置 响应体
/// <para>查询考勤统计支持的日度统计或月度统计的统计表头。报表的表头信息可以在考勤统计-[报表](https://example.feishu.cn/people/workforce-management/manage/statistics/report)中查询到具体的报表信息，此接口专门用于查询表头数据。注意此接口和[查询统计表头](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_stats_field/query)基本相同，区别点在于在兼容历史统计视图模型（历史统计数据模型可以按用户ID设置，后续统计升级为仅支持租户维度）</para>
/// <para>接口ID：7044467124773830657</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_view%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsViewsQueryResponseDto
{
    /// <summary>
    /// <para>统计视图</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("view")]
    public UserStatsView? View { get; set; }

    /// <summary>
    /// <para>统计视图</para>
    /// </summary>
    public record UserStatsView
    {
        /// <summary>
        /// <para>视图 ID，可用于[更新统计设置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_stats_view/update)</para>
        /// <para>必填：是</para>
        /// <para>示例值："TmpZNU5qTTJORFF6T1RnNU5UTTNOakV6TWl0dGIyNTBhQT09"</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        public string ViewId { get; set; } = string.Empty;

        /// <summary>
        /// <para>视图类型</para>
        /// <para>必填：是</para>
        /// <para>示例值："month"</para>
        /// <para>可选值：<list type="bullet">
        /// <item>daily：日度统计</item>
        /// <item>month：月度统计</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("stats_type")]
        public string StatsType { get; set; } = string.Empty;

        /// <summary>
        /// <para>操作者的用户id，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值："ec8ddg56"</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户设置字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("items")]
        public Item[]? Items { get; set; }

        /// <summary>
        /// <para>用户设置字段</para>
        /// </summary>
        public record Item
        {
            /// <summary>
            /// <para>标题编号</para>
            /// <para>必填：是</para>
            /// <para>示例值：501</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>标题名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：基本信息</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>子标题</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("child_items")]
            public ChildItem[]? ChildItems { get; set; }

            /// <summary>
            /// <para>子标题</para>
            /// </summary>
            public record ChildItem
            {
                /// <summary>
                /// <para>子标题编号</para>
                /// <para>必填：是</para>
                /// <para>示例值：501</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string Code { get; set; } = string.Empty;

                /// <summary>
                /// <para>开关字段，0：关闭，1：开启（非开关字段场景：code = 51501 可选值为1-6）</para>
                /// <para>`51501`：第 1 次 ~ 第$上下班</para>
                /// <para>`51502`：打卡时间</para>
                /// <para>`51503`：打卡结果</para>
                /// <para>`51504`：打卡原始记录</para>
                /// <para>`51505`：打卡地址</para>
                /// <para>`51506`：打卡备注</para>
                /// <para>必填：是</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;

                /// <summary>
                /// <para>子标题名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：工号</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>列类型</para>
                /// <para>* `0`：未知（默认）</para>
                /// <para>* `1`：复选框</para>
                /// <para>* `2`：文本</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("column_type")]
                public int? ColumnType { get; set; }

                /// <summary>
                /// <para>是否只读</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("read_only")]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>最小值</para>
                /// <para>必填：否</para>
                /// <para>示例值：""</para>
                /// </summary>
                [JsonPropertyName("min_value")]
                public string? MinValue { get; set; }

                /// <summary>
                /// <para>最大值</para>
                /// <para>必填：否</para>
                /// <para>示例值：""</para>
                /// </summary>
                [JsonPropertyName("max_value")]
                public string? MaxValue { get; set; }
            }
        }
    }
}
