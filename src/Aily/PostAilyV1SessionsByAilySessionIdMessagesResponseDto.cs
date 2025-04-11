// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-10-18
// ************************************************************************
// <copyright file="PostAilyV1SessionsByAilySessionIdMessagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送智能伙伴消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 发送智能伙伴消息 响应体
/// <para>该 API 用于向某个飞书智能伙伴应用发送一条消息（Message）；每个消息从属于一个活跃的会话（Session）。</para>
/// <para>## 实体概念说明</para>
/// <para>- **会话**（Session）：管理用户与 Aily 助手之间的交互会话；每次会话记录了用户发送给 Aily 助手的消息以及 Aily 助手的响应。</para>
/// <para>- **消息**（Message）：消息可以包含文本、表格、图片等多种类型的内容。</para>
/// <para>- **运行**（Run）：Aily 助手基于会话内消息进行意图判定、调用匹配的技能，并返回技能执行后的结果消息。</para>
/// <para>接口ID：7358047310868283396</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-aily_message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-aily_message%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdMessagesResponseDto
{
    /// <summary>
    /// <para>消息信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message")]
    public AilyMessage? Message { get; set; }

    /// <summary>
    /// <para>消息信息</para>
    /// </summary>
    public record AilyMessage
    {
        /// <summary>
        /// <para>消息 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：message_4df45f2xknvcc</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：9</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会话 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：session_4dfunz7sp1g8m</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：9</para>
        /// </summary>
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// <para>运行 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：run_4dfrxvctjqzzj</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：5</para>
        /// </summary>
        [JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// <para>消息内容类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDX</para>
        /// </summary>
        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// <para>消息内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：你好</para>
        /// <para>最大长度：16777216</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>消息中包含的文件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("files")]
        public AilyMessageFile[]? Files { get; set; }

        /// <summary>
        /// <para>消息中包含的文件</para>
        /// </summary>
        public record AilyMessageFile
        {
            /// <summary>
            /// <para>文件 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：file_4d9nu1ev3a2rq</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：6</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>文件类型，参见[MIME 类型（IANA 媒体类型）](https://developer.mozilla.org/zh-CN/docs/Web/HTTP/Basics_of_HTTP/MIME_types)</para>
            /// <para>必填：否</para>
            /// <para>示例值：image/png</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("mime_type")]
            public string? MimeType { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// <para>必填：否</para>
            /// <para>示例值：发票.png</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("file_name")]
            public string? FileName { get; set; }

            /// <summary>
            /// <para>其他透传信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：{}</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("metadata")]
            public string? Metadata { get; set; }

            /// <summary>
            /// <para>文件的创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1711975665710</para>
            /// <para>最大长度：13</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("created_at")]
            public string? CreatedAt { get; set; }

            /// <summary>
            /// <para>文件预览链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("preview_url")]
            public AilyMessageFilePreview? PreviewUrl { get; set; }

            /// <summary>
            /// <para>文件预览链接</para>
            /// </summary>
            public record AilyMessageFilePreview
            {
                /// <summary>
                /// <para>文件的 URL</para>
                /// <para>必填：是</para>
                /// <para>示例值：http://path_to_file</para>
                /// <para>最大长度：512</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// <para>url 过期时间，秒时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1719413169</para>
                /// <para>最大长度：20</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("expired_at")]
                public string? ExpiredAt { get; set; }
            }
        }

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
        /// <para>发送者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public AilySender? Sender { get; set; }

        /// <summary>
        /// <para>发送者</para>
        /// </summary>
        public record AilySender
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
            /// <para>发送人类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：USER</para>
            /// </summary>
            [JsonPropertyName("sender_type")]
            public string? SenderType { get; set; }

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

        /// <summary>
        /// <para>消息体的纯文本表达</para>
        /// <para>必填：否</para>
        /// <para>示例值：你好</para>
        /// <para>最大长度：16777216</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("plain_text")]
        public string? PlainText { get; set; }

        /// <summary>
        /// <para>消息的创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：COMPLETED</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
