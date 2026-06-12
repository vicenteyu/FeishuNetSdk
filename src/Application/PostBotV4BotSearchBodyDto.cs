// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostBotV4BotSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索机器人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 搜索机器人 请求体
/// <para>用户可以通过关键字搜索可见的机器人，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649652220287716543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v4/bot/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v4%2fbot%2fsearch</para>
/// </summary>
public record PostBotV4BotSearchBodyDto
{
    /// <summary>
    /// <para>query (长度范围：0 ～ 50 字符)</para>
    /// <para>必填：否</para>
    /// <para>示例值：会议助手</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>filter</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public BotSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>filter</para>
    /// </summary>
    public record BotSearchFilter
    {
        /// <summary>
        /// <para>群聊ID列表，查询指定群聊内的机器人</para>
        /// <para>群聊ID获取参考：https://open.larkoffice.com/document/server-docs/group/chat/chat-id-description</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("chat_ids")]
        public string[]? ChatIds { get; set; }

        /// <summary>
        /// <para>是否和机器人聊过天，如果设置true，只返回有聊天的机器人</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("has_chatter")]
        public bool? HasChatter { get; set; }
    }
}
