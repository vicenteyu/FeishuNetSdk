// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostImV2ChatsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索群组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 搜索群组 响应体
/// <para>用户可以通过关键字搜索可见群组，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649732836954606572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/chat/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat%2fsearch</para>
/// </summary>
public record PostImV2ChatsSearchResponseDto : IPageableResponse<PostImV2ChatsSearchResponseDto.ChatSearchItem>
{
    /// <summary>
    /// <para>items</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ChatSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>items</para>
    /// </summary>
    public record ChatSearchItem
    {
        /// <summary>
        /// <para>群组ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7890123456abcdef</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含群组基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书&lt;h&gt;搜索&lt;/h&gt;</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>群组元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public ChatSearchMeta? MetaData { get; set; }

        /// <summary>
        /// <para>群组元信息</para>
        /// </summary>
        public record ChatSearchMeta
        {
            /// <summary>
            /// <para>群组 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7890123456abcdef</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string ChatId { get; set; } = string.Empty;

            /// <summary>
            /// <para>创建时间(iso8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间(iso8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>是否是外部群</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("external")]
            public bool? External { get; set; }

            /// <summary>
            /// <para>群模式，group：群组 topic: 话题</para>
            /// <para>必填：否</para>
            /// <para>示例值：group</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("chat_mode")]
            public string? ChatMode { get; set; }

            /// <summary>
            /// <para>群描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：群描述</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>群头像URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public string? Avatar { get; set; }

            /// <summary>
            /// <para>群名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：研发讨论群</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>群主ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4d7a3c6g</para>
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string? OwnerId { get; set; }

            /// <summary>
            /// <para>群主ID类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user_id</para>
            /// </summary>
            [JsonPropertyName("owner_id_type")]
            public string? OwnerIdType { get; set; }

            /// <summary>
            /// <para>tenant key</para>
            /// <para>必填：否</para>
            /// <para>示例值：7010970696222244883</para>
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }

            /// <summary>
            /// <para>群状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：normal</para>
            /// <para>可选值：<list type="bullet">
            /// <item>normal：正常</item>
            /// <item>dissolved：解散</item>
            /// <item>dissolved_save：解散并保留</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("chat_status")]
            public string? ChatStatus { get; set; }
        }
    }

    /// <summary>
    /// <para>total</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
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
