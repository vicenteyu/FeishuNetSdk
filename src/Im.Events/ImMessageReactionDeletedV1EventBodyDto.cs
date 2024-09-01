// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImMessageReactionDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除消息表情回复 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 删除消息表情回复 事件体
/// <para>应用订阅该事件后，消息被删除表情回复时会触发此事件。事件体包含被删除表情回复的消息 message_id、删除表情回复的操作人 ID、表情类型、添加时间等信息。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=message.reaction&amp;event=deleted)</para>
/// <para>接口ID：6992043826169987074</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fevents%2fdeleted</para>
/// </summary>
public record ImMessageReactionDeletedV1EventBodyDto() : EventBodyDto("im.message.reaction.deleted_v1")
{
    /// <summary>
    /// <para>消息 ID。调用[获取指定消息的内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/get)接口，可通过 message_id 获取消息内容。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>表情回复的资源类型。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public Emoji? ReactionType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record Emoji
    {
        /// <summary>
        /// <para>emoji 类型。emoji_type 值对应的表情可参见[表情文案说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("emoji_type")]
        public string? EmojiType { get; set; }
    }

    /// <summary>
    /// <para>操作人类型。可能值有：</para>
    /// <para>- user：用户。此时 user_id 参数有返回值。</para>
    /// <para>- app：应用。此时 app_id 参数有返回值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_type")]
    public string? OperatorType { get; set; }

    /// <summary>
    /// <para>用户 ID。调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，可通过用户 ID 获取用户信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>应用 ID。调用[获取应用信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application/get)接口，可通过 app_id 获取应用信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>删除表情回复的时间戳。单位：ms</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("action_time")]
    public string? ActionTime { get; set; }
}
