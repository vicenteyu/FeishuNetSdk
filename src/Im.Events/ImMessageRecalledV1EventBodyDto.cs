// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImMessageRecalledV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回消息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 撤回消息 事件体
/// <para>机器人所在会话内的消息被撤回时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=message&amp;event=recalled)</para>
/// <para>接口ID：7145387488308363267</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/recalled</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2frecalled</para>
/// </summary>
public record ImMessageRecalledV1EventBodyDto() : EventBodyDto("im.message.recalled_v1")
{
    /// <summary>
    /// <para>被撤回的消息 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>消息所在的群组 ID。调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，可通过 ID 获取群组信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>撤回的时间，毫秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("recall_time")]
    public string? RecallTime { get; set; }

    /// <summary>
    /// <para>撤回类型</para>
    /// <para>**可选值有**：</para>
    /// <para>message_owner:消息发送者撤回,group_owner:群主撤回,group_manager:群管理员撤回,enterprise_manager:企业管理员撤回</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>message_owner：消息发送者撤回</item>
    /// <item>group_owner：群主撤回</item>
    /// <item>group_manager：群管理员撤回</item>
    /// <item>enterprise_manager：企业管理员撤回</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("recall_type")]
    public string? RecallType { get; set; }
}
