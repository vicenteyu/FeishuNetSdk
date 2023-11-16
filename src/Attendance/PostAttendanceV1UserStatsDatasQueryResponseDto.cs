namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询统计数据 响应体
/// <para>查询日度统计或月度统计的统计数据。</para>
/// <para>接口ID：7044467124773568513</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_data%2fquery</para>
/// </summary>
public record PostAttendanceV1UserStatsDatasQueryResponseDto
{
    /// <summary>
    /// <para>用户统计数据（限制1000条，超过1000条会截断）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_datas")]
    public UserStatsData[]? UserDatas { get; set; }

    /// <summary>
    /// <para>用户统计数据（限制1000条，超过1000条会截断）</para>
    /// </summary>
    public record UserStatsData
    {
        /// <summary>
        /// <para>用户姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：小李</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ec8ddg56</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户的统计数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("datas")]
        public UserStatsDataCell[]? Datas { get; set; }

        /// <summary>
        /// <para>用户的统计数据</para>
        /// </summary>
        public record UserStatsDataCell
        {
            /// <summary>
            /// <para>字段编号</para>
            /// <para>必填：是</para>
            /// <para>示例值：50102</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据值</para>
            /// <para>必填：是</para>
            /// <para>示例值：无需打卡(-),无需打卡(-)</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("features")]
            public UserStatsDataFeature[]? Features { get; set; }

            /// <summary>
            /// <para>数据属性</para>
            /// </summary>
            public record UserStatsDataFeature
            {
                /// <summary>
                /// <para>统计数据列附加属性的名称</para>
                /// <para>必填：是</para>
                /// <para>示例值：Abnormal</para>
                /// </summary>
                [JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// <para>统计数据列附加属性的值。</para>
                /// <para>* 先展示上下班的打卡结果，再展示假勤申请时间(如果有)</para>
                /// <para>必填：是</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>字段标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：姓名</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }
        }
    }

    /// <summary>
    /// <para>无权限获取的用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_user_list")]
    public string[]? InvalidUserList { get; set; }
}
