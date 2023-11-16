namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询主日历信息 响应体
/// <para>获取当前身份的主日历信息。</para>
/// <para>接口ID：7051880392425439236</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/primary</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fprimary</para>
/// </summary>
public record PostCalendarV4CalendarsPrimaryResponseDto
{
    /// <summary>
    /// <para>主日历列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("calendars")]
    public UserCalendar[]? Calendars { get; set; }

    /// <summary>
    /// <para>主日历列表</para>
    /// </summary>
    public record UserCalendar
    {
        /// <summary>
        /// <para>日历实体信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("calendar")]
        public UserCalendarCalendar? Calendar { get; set; }

        /// <summary>
        /// <para>日历实体信息</para>
        /// </summary>
        public record UserCalendarCalendar
        {
            /// <summary>
            /// <para>日历ID。参见[日历ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)</para>
            /// <para>必填：是</para>
            /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("calendar_id")]
            public string CalendarId { get; set; } = string.Empty;

            /// <summary>
            /// <para>日历标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试日历</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("summary")]
            public string? Summary { get; set; }

            /// <summary>
            /// <para>日历描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：使用开放接口创建日历</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>日历公开范围</para>
            /// <para>必填：否</para>
            /// <para>示例值：private</para>
            /// <para>可选值：<list type="bullet">
            /// <item>private：私密</item>
            /// <item>show_only_free_busy：仅展示忙闲信息</item>
            /// <item>public：他人可查看日程详情</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("permissions")]
            public string? Permissions { get; set; }

            /// <summary>
            /// <para>日历颜色，颜色RGB值的int32表示。客户端展示时会映射到色板上最接近的一种颜色。仅对当前身份生效</para>
            /// <para>必填：否</para>
            /// <para>示例值：-1</para>
            /// </summary>
            [JsonPropertyName("color")]
            public int? Color { get; set; }

            /// <summary>
            /// <para>日历类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：shared</para>
            /// <para>可选值：<list type="bullet">
            /// <item>unknown：未知类型</item>
            /// <item>primary：用户或应用的主日历</item>
            /// <item>shared：由用户或应用创建的共享日历</item>
            /// <item>google：用户绑定的谷歌日历</item>
            /// <item>resource：会议室日历</item>
            /// <item>exchange：用户绑定的Exchange日历</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>日历备注名，修改或添加后仅对当前身份生效</para>
            /// <para>必填：否</para>
            /// <para>示例值：日历备注名</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("summary_alias")]
            public string? SummaryAlias { get; set; }

            /// <summary>
            /// <para>对于当前身份，日历是否已经被标记为删除</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>当前日历是否是第三方数据；三方日历及日程只支持读，不支持写入</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("is_third_party")]
            public bool? IsThirdParty { get; set; }

            /// <summary>
            /// <para>当前身份对于该日历的访问权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：owner</para>
            /// <para>可选值：<list type="bullet">
            /// <item>unknown：未知权限</item>
            /// <item>free_busy_reader：游客，只能看到忙碌/空闲信息</item>
            /// <item>reader：订阅者，查看所有日程详情</item>
            /// <item>writer：编辑者，创建及修改日程</item>
            /// <item>owner：管理员，管理日历及共享设置</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>日历的创建者user ID，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxx</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
