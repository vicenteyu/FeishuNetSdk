// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImChatAccessEventBotP2pChatEnteredV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户进入与机器人的会话 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 用户进入与机器人的会话 事件体
/// <para>用户进入与机器人的会话时触发此事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=chat.access_event&amp;event=bot_p2p_chat_entered)</para>
/// <para>接口ID：7372115309028524036</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-access_event/events/bot_p2p_chat_entered</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-access_event%2fevents%2fbot_p2p_chat_entered</para>
/// </summary>
public record ImChatAccessEventBotP2pChatEnteredV1EventBodyDto() : EventBodyDto("im.chat.access_event.bot_p2p_chat_entered_v1")
{
    /// <summary>
    /// <para>会话 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>会话内用户可见的最新消息ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("last_message_id")]
    public string? LastMessageId { get; set; }

    /// <summary>
    /// <para>会话内用户可见的最新消息发送时间（毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("last_message_create_time")]
    public string? LastMessageCreateTime { get; set; }
}
