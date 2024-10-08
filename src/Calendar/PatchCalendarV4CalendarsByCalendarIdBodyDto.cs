// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCalendarV4CalendarsByCalendarIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新日历信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 更新日历信息 请求体
/// <para>调用该接口以当前身份（应用或用户）修改指定日历的标题、描述、公开范围等信息。</para>
/// <para>接口ID：6952888507003158555</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fpatch</para>
/// </summary>
public record PatchCalendarV4CalendarsByCalendarIdBodyDto
{
    /// <summary>
    /// <para>日历标题。</para>
    /// <para>- 不传表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试日历</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>日历描述。</para>
    /// <para>- 不传表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// <para>示例值：使用开放接口创建日历</para>
    /// <para>最大长度：255</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>日历公开范围。</para>
    /// <para>- 不传表示不更新该字段。</para>
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
    /// <para>日历颜色，取值通过颜色 RGB 值的 int32 表示，其中，24 ~ 31 位为透明度，16 ~ 23 位为红，8 ~ 15 位为绿，0 ~ 7 位为蓝。例如，-11034625 表示 RGB 值 (87, 159, 255)。</para>
    /// <para>- 不传表示不更新该字段。</para>
    /// <para>**注意**：</para>
    /// <para>- 取值范围为 -2^31 ~ 2^31-1</para>
    /// <para>- 日历颜色会映射到飞书客户端色板上最接近的一种颜色进行展示。</para>
    /// <para>- 该颜色仅对当前身份生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：-1</para>
    /// </summary>
    [JsonPropertyName("color")]
    public int? Color { get; set; }

    /// <summary>
    /// <para>日历备注名，设置该字段后（包括后续修改该字段）仅对当前身份生效。</para>
    /// <para>- 不传表示不更新该字段。</para>
    /// <para>必填：否</para>
    /// <para>示例值：日历备注名</para>
    /// <para>最大长度：255</para>
    /// </summary>
    [JsonPropertyName("summary_alias")]
    public string? SummaryAlias { get; set; }
}
