// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCalendarV4CalendarsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询日历列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询日历列表 响应体
/// <para>调用该接口分页查询当前身份（应用或用户）的日历列表。</para>
/// <para>接口ID：6952888507002880027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2flist</para>
/// </summary>
public record GetCalendarV4CalendarsResponseDto : IPageableResponse<GetCalendarV4CalendarsResponseDto.Calendar>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Calendar[]? Items => CalendarLists;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ListCalendarsPageToken_xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>增量同步标记。当 has_more 为 false 时，会同步返回新的 sync_token，下次请求需要带上 sync_token 增量获取日历变更数据。</para>
    /// <para>**注意**：返回的 sync_token 在 90 天内有效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ListCalendarsSyncToken_xxx</para>
    /// </summary>
    [JsonPropertyName("sync_token")]
    public string? SyncToken { get; set; }

    /// <summary>
    /// <para>分页加载的日历数据列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("calendar_list")]
    public Calendar[]? CalendarLists { get; set; }

    /// <summary>
    /// <para>分页加载的日历数据列表。</para>
    /// </summary>
    public record Calendar
    {
        /// <summary>
        /// <para>日历 ID。后续可以通过该 ID 查询、更新或删除日历信息。更多信息参见[日历 ID 字段说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("calendar_id")]
        public string CalendarId { get; set; } = string.Empty;

        /// <summary>
        /// <para>日历标题。</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试日历</para>
        /// <para>最大长度：255</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>日历描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：使用开放接口创建日历</para>
        /// <para>最大长度：255</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>日历公开范围。</para>
        /// <para>必填：否</para>
        /// <para>示例值：private</para>
        /// <para>可选值：<list type="bullet">
        /// <item>private：私密</item>
        /// <item>show_only_free_busy：仅展示忙闲信息</item>
        /// <item>public：公开，他人可查看日程详情</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("permissions")]
        public string? Permissions { get; set; }

        /// <summary>
        /// <para>日历颜色，由颜色 RGB 值的 int32 表示。实际在客户端展示时会映射到色板上最接近的一种颜色，且该字段仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：-1</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; set; }

        /// <summary>
        /// <para>日历类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：shared</para>
        /// <para>可选值：<list type="bullet">
        /// <item>unknown：未知类型</item>
        /// <item>primary：用户或应用的主日历</item>
        /// <item>shared：由用户或应用创建的共享日历</item>
        /// <item>google：用户绑定的谷歌日历</item>
        /// <item>resource：会议室日历</item>
        /// <item>exchange：用户绑定的 Exchange 日历</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>日历备注名，仅对当前身份生效。</para>
        /// <para>必填：否</para>
        /// <para>示例值：日历备注名</para>
        /// <para>最大长度：255</para>
        /// </summary>
        [JsonPropertyName("summary_alias")]
        public string? SummaryAlias { get; set; }

        /// <summary>
        /// <para>对于当前身份，日历是否已经被标记为删除。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>当前日历是否是第三方数据。三方日历及日程只支持读，不支持写入。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_third_party")]
        public bool? IsThirdParty { get; set; }

        /// <summary>
        /// <para>当前身份对于该日历的访问权限。</para>
        /// <para>必填：否</para>
        /// <para>示例值：owner</para>
        /// <para>可选值：<list type="bullet">
        /// <item>unknown：未知权限</item>
        /// <item>free_busy_reader：游客，只能看到忙碌、空闲信息</item>
        /// <item>reader：订阅者，可查看所有日程详情</item>
        /// <item>writer：编辑者，可创建及修改日程</item>
        /// <item>owner：管理员，可管理日历及共享设置</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }
    }
}
