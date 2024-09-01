// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ImMessageReceiveV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>接收消息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Events;
/// <summary>
/// 接收消息 事件体
/// <para>机器人接收到用户发送的消息后触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=im&amp;version=v1&amp;resource=message&amp;event=receive)</para>
/// <para>接口ID：6946222929790402588</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/receive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2freceive</para>
/// </summary>
public record ImMessageReceiveV1EventBodyDto() : EventBodyDto("im.message.receive_v1")
{
    /// <summary>
    /// <para>事件的发送者</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sender")]
    public EventSender? Sender { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EventSender
    {
        /// <summary>
        /// <para>用户 ID。调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，可通过 ID 获取用户信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sender_id")]
        public UserIdSuffix? SenderId { get; set; }

        /// <summary>
        /// <para>消息发送者类型。目前只支持用户(user)发送的消息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sender_type")]
        public string? SenderType { get; set; }

        /// <summary>
        /// <para>tenant key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }

    /// <summary>
    /// <para>事件中包含的消息内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message")]
    public EventMessage? Message { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EventMessage
    {
        /// <summary>
        /// <para>消息 ID。由系统生成的唯一 ID 标识，基于该 ID 可以[回复消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/reply) 或其他管理消息的操作。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>根消息 ID，仅在回复消息场景会有返回值。了解 root_id 可参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("root_id")]
        public string? RootId { get; set; }

        /// <summary>
        /// <para>父消息 ID，仅在回复消息场景会有返回值。了解 parent_id 可参见[消息管理概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>消息发送时间（毫秒）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>消息更新时间（毫秒）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>消息所在的群组 ID。调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，可通过 ID 获取群组信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>消息所属的话题 ID（不返回说明该消息非话题消息）。了解话题可参见[话题概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/thread-introduction)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// <para>消息所在的群组类型</para>
        /// <para>**可能值有**：</para>
        /// <para>- `p2p`：单聊</para>
        /// <para>- `group`： 群组</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_type")]
        public string? ChatType { get; set; }

        /// <summary>
        /// <para>消息类型，可能返回的消息类型以及详细介绍，参见[接收消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/events/message_content)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// <para>消息内容，JSON 结构序列化后的字符串，不同消息类型（`msg_type`）对应不同内容。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>被提及用户的信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mentions")]
        public MentionEvent[]? Mentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record MentionEvent
        {
            /// <summary>
            /// <para>被提及用户序号。例如，第 3 个被 @ 到的成员，取值为 `@_user_3`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }

            /// <summary>
            /// <para>被提及用户 ID。调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，可通过 ID 获取用户信息。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public UserIdSuffix? Id { get; set; }

            /// <summary>
            /// <para>被提及用户姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>tenant key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }
        }

        /// <summary>
        /// <para>用户代理数据，仅在接收事件的机器人具备==获取客户端用户代理信息（im:user_agent:read）==权限时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }
    }
}
