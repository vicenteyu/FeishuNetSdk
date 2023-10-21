using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建共享日历 请求体
/// <para>该接口用于为当前身份（应用 / 用户）创建一个共享日历。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6952888507003076635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsBodyDto
{
    /// <summary>
    /// <para>日历标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试日历</para>
    /// <para>最大长度：255</para>
    /// </summary>
    [JsonProperty("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>日历描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：使用开放接口创建日历</para>
    /// <para>最大长度：255</para>
    /// </summary>
    [JsonProperty("description")]
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
    [JsonProperty("permissions")]
    public string? Permissions { get; set; }

    /// <summary>
    /// <para>日历颜色，颜色RGB值的int32表示。客户端展示时会映射到色板上最接近的一种颜色。仅对当前身份生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：-1</para>
    /// </summary>
    [JsonProperty("color")]
    public int? Color { get; set; }

    /// <summary>
    /// <para>日历备注名，修改或添加后仅对当前身份生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：日历备注名</para>
    /// <para>最大长度：255</para>
    /// </summary>
    [JsonProperty("summary_alias")]
    public string? SummaryAlias { get; set; }
}
