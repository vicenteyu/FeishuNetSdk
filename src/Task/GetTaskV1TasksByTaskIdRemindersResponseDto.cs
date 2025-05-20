// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV1TasksByTaskIdRemindersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询提醒时间列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 查询提醒时间列表 响应体
/// <para>返回提醒时间列表，支持分页，最大值为50。</para>
/// <para>接口ID：6985127383322394626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-reminder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-reminder%2flist</para>
/// </summary>
public record GetTaskV1TasksByTaskIdRemindersResponseDto : IPageableResponse<GetTaskV1TasksByTaskIdRemindersResponseDto.Reminder>
{
    /// <summary>
    /// <para>返回提醒时间设置列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Reminder[]? Items { get; set; }

    /// <summary>
    /// <para>返回提醒时间设置列表</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>提醒时间设置的 ID（在删除时候需要使用这个）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>相对于截止时间的提醒时间（如提前 30 分钟，截止时间后 30 分钟，则为 -30） 任务没有截止时间则为全天任务(截止时间为0)</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("relative_fire_minute")]
        public int RelativeFireMinute { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：「填写上次返回的page_token」</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
