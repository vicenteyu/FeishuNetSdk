// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAilyV1SessionsByAilySessionIdMessagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送智能伙伴消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 发送智能伙伴消息 请求体
/// <para>该 API 用于向某个飞书智能伙伴应用发送一条消息（Message）；每个消息从属于一个活跃的会话（Session）。</para>
/// <para>## 实体概念说明</para>
/// <para>- **会话**（Session）：管理用户与 Aily 助手之间的交互会话；每次会话记录了用户发送给 Aily 助手的消息以及 Aily 助手的响应。</para>
/// <para>- **消息**（Message）：消息可以包含文本、表格、图片等多种类型的内容。</para>
/// <para>- **运行**（Run）：Aily 助手基于会话内消息进行意图判定、调用匹配的技能，并返回技能执行后的结果消息。</para>
/// <para>接口ID：7358047310868283396</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-aily_message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-aily_message%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdMessagesBodyDto
{
    /// <summary>
    /// <para>幂等 ID（如使用 UUID 生成器或时间戳），同一会话下相同的幂等 ID 视为同一个消息（72h）</para>
    /// <para>必填：是</para>
    /// <para>示例值：idempotent_id_1</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("idempotent_id")]
    public string IdempotentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息的类型，包括 `MDX` | `TEXT` 等</para>
    /// <para>- `MDX` 能够表达富文本信息结构，可参考 [Aily 消息节点 markdown 语法](https://bytedance.larkoffice.com/wiki/ZlHYw8jJci3o4dkkEZZcybM0nah)</para>
    /// <para>- `TEXT` 作为纯文本进行处理</para>
    /// <para>必填：是</para>
    /// <para>示例值：MDX</para>
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：你好</para>
    /// <para>最大长度：16777216</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息中包含的文件 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("file_ids")]
    public string[]? FileIds { get; set; }

    /// <summary>
    /// <para>引用的消息 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：message_4de9bpg70qskh</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("quote_message_id")]
    public string? QuoteMessageId { get; set; }

    /// <summary>
    /// <para>被@的实体</para>
    /// <para>必填：否</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("mentions")]
    public AilyMention[]? Mentions { get; set; }

    /// <summary>
    /// <para>被@的实体</para>
    /// </summary>
    public record AilyMention
    {
        /// <summary>
        /// <para>实体 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_5ad573a6411d72b8305fda3a9c15c70e</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// <para>身份提供者</para>
        /// <para>必填：否</para>
        /// <para>示例值：FEISHU</para>
        /// </summary>
        [JsonPropertyName("identity_provider")]
        public string? IdentityProvider { get; set; }

        /// <summary>
        /// <para>被@实体在消息体中的占位符</para>
        /// <para>必填：否</para>
        /// <para>示例值：@_user_1</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>被@实体的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>飞书智能伙伴创建平台账号体系下的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1794840334557292</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("aily_id")]
        public string? AilyId { get; set; }
    }
}
