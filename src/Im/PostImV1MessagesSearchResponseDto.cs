// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostImV1MessagesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 搜索消息 响应体
/// <para>用户可以通过关键字搜索可见消息，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649057980096580572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fsearch</para>
/// </summary>
public record PostImV1MessagesSearchResponseDto : IPageableResponse<PostImV1MessagesSearchResponseDto.MessageSearchItem>
{
    /// <summary>
    /// <para>items</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MessageSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>items</para>
    /// </summary>
    public record MessageSearchItem
    {
        /// <summary>
        /// <para>消息ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：om_40eb06e7b84dc71c03e00ida3c754892</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含消息基本信息的卡片,用户搜索关键词命中的文本 片段,使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书&lt;h&gt;搜索&lt;/h&gt;</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>消息元数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public MessageSearchMeta? MetaData { get; set; }

        /// <summary>
        /// <para>消息元数据</para>
        /// </summary>
        public record MessageSearchMeta
        {
            /// <summary>
            /// <para>消息ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：om_40eb06e7b84dc71c03e00ida3c754892</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("message_id")]
            public string MessageId { get; set; } = string.Empty;

            /// <summary>
            /// <para>消息类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：post</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>unknown：unknown</item>
            /// <item>post：post</item>
            /// <item>file：file</item>
            /// <item>text：text</item>
            /// <item>image：image</item>
            /// <item>system：system</item>
            /// <item>audio：audio</item>
            /// <item>email：email</item>
            /// <item>share_group_chat：share_group_chat</item>
            /// <item>sticker：sticker</item>
            /// <item>merge_forward：merge_forward</item>
            /// <item>calendar：calendar</item>
            /// <item>cloud_file：cloud_file</item>
            /// <item>card：card</item>
            /// <item>media：media</item>
            /// <item>share_calendar_event：share_calendar_event</item>
            /// <item>hongbao：hongbao</item>
            /// <item>general_calendar：general_calendar</item>
            /// <item>video_chat：video_chat</item>
            /// <item>location：location</item>
            /// <item>commercialized_hongbao：commercialized_hongbao</item>
            /// <item>share_user_card：share_user_card</item>
            /// <item>todo：todo</item>
            /// <item>folder：folder</item>
            /// <item>diagnose：diagnose</item>
            /// <item>vote：vote</item>
            /// <item>link：link</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>创建时间(iso8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间(iso8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>消息位置</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最大值：1000000000000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("position")]
            public int? Position { get; set; }

            /// <summary>
            /// <para>所在会话ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>消息发送者ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-7890123456abcdef</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("from_id")]
            public string? FromId { get; set; }

            /// <summary>
            /// <para>消息话题ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：omt_d4be107c616a</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("thread_id")]
            public string? ThreadId { get; set; }

            /// <summary>
            /// <para>消息话题位置</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// <para>最大值：1000000000000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("thread_position")]
            public int? ThreadPosition { get; set; }

            /// <summary>
            /// <para>是否为单聊</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_p2p_chat")]
            public bool? IsP2pChat { get; set; }
        }
    }

    /// <summary>
    /// <para>total</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>搜索补充提示信息，返回本次搜索的额外说明，例如：query被截断；搜索结果不全等</para>
    /// <para>必填：否</para>
    /// <para>示例值：The query is too long and has been truncated to the first 50 characters for search.</para>
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }
}
