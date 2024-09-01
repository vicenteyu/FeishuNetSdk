// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImMessageMessageReadV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>消息已读 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 消息已读 事件体
/// <para>用户阅读机器人发送的单聊消息后触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=message&amp;event=message_read)</para>
/// <para>接口ID：6946222929790533660</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/message_read</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2fmessage_read</para>
/// </summary>
public record ImMessageMessageReadV1EventBodyDto() : EventBodyDto("im.message.message_read_v1")
{
    /// <summary>
    /// <para>\-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reader")]
    public EventMessageReader? Reader { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EventMessageReader
    {
        /// <summary>
        /// <para>用户 ID。调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，可通过 ID 获取用户信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reader_id")]
        public UserIdSuffix? ReaderId { get; set; }

        /// <summary>
        /// <para>用户已读的时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("read_time")]
        public string? ReadTime { get; set; }

        /// <summary>
        /// <para>租户key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>消息 ID 列表。你可以调用[获取指定消息的内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/get)接口，通过消息 ID 查询消息内容。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id_list")]
    public string[]? MessageIdList { get; set; }
}
