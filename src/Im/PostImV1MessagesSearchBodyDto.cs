// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostImV1MessagesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 搜索消息 请求体
/// <para>用户可以通过关键字搜索可见消息，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649057980096580572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fsearch</para>
/// </summary>
public record PostImV1MessagesSearchBodyDto
{
    /// <summary>
    /// <para>query (长度范围：0 ～ 50 字符)</para>
    /// <para>必填：否</para>
    /// <para>示例值：下午去哪团建</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>消息过滤器</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public MessageSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>消息过滤器</para>
    /// </summary>
    public record MessageSearchFilter
    {
        /// <summary>
        /// <para>消息创建者</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("from_ids")]
        public string[]? FromIds { get; set; }

        /// <summary>
        /// <para>消息所在的会话，会话ID获取方式参考：https://open.larkoffice.com/document/server-docs/group/chat/chat-id-description</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("chat_ids")]
        public string[]? ChatIds { get; set; }

        /// <summary>
        /// <para>开始与结束时间，不需要同时传入，但是end_time需要大于start_time</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("time_range")]
        public TimeRangeSuffix? TimeRange { get; set; }

        /// <summary>
        /// <para>开始与结束时间，不需要同时传入，但是end_time需要大于start_time</para>
        /// </summary>
        public record TimeRangeSuffix
        {
            /// <summary>
            /// <para>开始时间(iso8601，需要小于end_time)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间(iso8601，需要大于start_time)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>包含某些附件类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：4</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>image：image</item>
        /// <item>video：video</item>
        /// <item>file：file</item>
        /// <item>link：link</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("include_attachment_types")]
        public string[]? IncludeAttachmentTypes { get; set; }

        /// <summary>
        /// <para>来源类型(用户消息、机器人消息)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：user</item>
        /// <item>bot：bot</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("from_types")]
        public string[]? FromTypes { get; set; }

        /// <summary>
        /// <para>消息中包含at的user_id (包含at all)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("at_chatter_ids")]
        public string[]? AtChatterIds { get; set; }

        /// <summary>
        /// <para>会话类型（单聊、群聊） 单选</para>
        /// <para>必填：否</para>
        /// <para>示例值：group</para>
        /// <para>可选值：<list type="bullet">
        /// <item>group：group</item>
        /// <item>p2p：p2p</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("chat_type")]
        public string? ChatType { get; set; }

        /// <summary>
        /// <para>是否at过我，默认否 (包含at all)</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_at_me")]
        public bool? IsAtMe { get; set; }

        /// <summary>
        /// <para>过滤来源</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：user</item>
        /// <item>bot：bot</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("exclude_from_types")]
        public string[]? ExcludeFromTypes { get; set; }
    }
}
