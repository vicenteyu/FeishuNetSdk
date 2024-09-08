// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="UrlPreviewGetEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>拉取链接预览数据 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.CallbackEvents
{
    /// <summary>
    /// 拉取链接预览数据 事件体
    /// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/development-link-preview/pull-link-preview-data-callback-structure</para>
    /// </summary>
    public record UrlPreviewGetEventBodyDto() : EventBodyDto("url.preview.get")
    {
        /// <summary>
        /// 查看链接的用户信息
        /// </summary>
        [JsonPropertyName("operator")]
        public OperatorSuffix? Operator { get; set; }

        /// <summary>
        /// 链接所在的宿主场景。枚举包括：1.im_message 聊天消息；2.im_top_notice 群置顶
        /// </summary>
        [JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// 当 "delivery_type": "url_preview" 表示回调来自链接预览
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public string? DeliveryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("context")]
        public ContextSuffix? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record OperatorSuffix
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public record ContextSuffix
        {
            /// <summary>
            /// 匹配 URL 规则的原链接
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// 用于标识链接预览的凭证，在返回链接预览数据时要用
            /// </summary>
            [JsonPropertyName("preview_token")]
            public string? PreviewToken { get; set; }

            /// <summary>
            /// 触发链接预览的消息 ID
            /// </summary>
            [JsonPropertyName("open_message_id")]
            public string? OpenMessageId { get; set; }

            /// <summary>
            /// 触发链接预览的群 ID
            /// </summary>
            [JsonPropertyName("open_chat_id")]
            public string? OpenChatId { get; set; }
        }
    }
}
