// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostBotV4BotSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索机器人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 搜索机器人 响应体
/// <para>用户可以通过关键字搜索可见的机器人，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649652220287716543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v4/bot/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v4%2fbot%2fsearch</para>
/// </summary>
public record PostBotV4BotSearchResponseDto : IPageableResponse<PostBotV4BotSearchResponseDto.BotSearchItem>
{
    /// <summary>
    /// <para>items</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public BotSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>items</para>
    /// </summary>
    public record BotSearchItem
    {
        /// <summary>
        /// <para>机器人ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7890123456abcdef</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含机器人基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书&lt;h&gt;搜索&lt;/h&gt;助手</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>机器人元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public BotSearchMeta? MetaData { get; set; }

        /// <summary>
        /// <para>机器人元信息</para>
        /// </summary>
        public record BotSearchMeta
        {
            /// <summary>
            /// <para>租户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7010970696222244883</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("tenant_id")]
            public string? TenantId { get; set; }

            /// <summary>
            /// <para>是否允许加入群聊</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("enable_join_group")]
            public bool? EnableJoinGroup { get; set; }

            /// <summary>
            /// <para>机器人所属的群聊ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc-7890123456abcdef</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>是否是智能体</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_agent")]
            public bool? IsAgent { get; set; }
        }
    }

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
