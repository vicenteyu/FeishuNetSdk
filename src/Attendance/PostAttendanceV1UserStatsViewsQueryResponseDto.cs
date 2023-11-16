namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计设置 响应体
/// <para>查询开发者定制的日度统计或月度统计的统计报表表头设置信息。</para>
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
        /// <para>视图 ID</para>
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
        /// <para>操作者的用户id</para>
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
