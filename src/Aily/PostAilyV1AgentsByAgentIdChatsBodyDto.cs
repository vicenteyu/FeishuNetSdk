// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdChatsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起智能体会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 发起智能体会话 请求体
/// <para>异步发起一轮智能体会话，提交用户消息后立即返回对话ID，触发智能体在后台运行。</para>
/// <para>接口ID：7646811253679819955</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdChatsBodyDto
{
    /// <summary>
    /// <para>用户请求对话内容，必填参数</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_message")]
    public AgentUserMessage UserMessage { get; set; } = new();

    /// <summary>
    /// <para>用户请求对话内容，必填参数</para>
    /// </summary>
    public record AgentUserMessage
    {
        /// <summary>
        /// <para>用户消息，元素最多100</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("content")]
        public AgentUserMessageContent[] Contents { get; set; } = [];

        /// <summary>
        /// <para>用户消息，元素最多100</para>
        /// </summary>
        public record AgentUserMessageContent
        {
            /// <summary>
            /// <para>内容类型</para>
            /// <para>- 支持text</para>
            /// <para>必填：是</para>
            /// <para>示例值：text</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：你好！有什么可以帮您</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>附件id，通过调用[上传附件](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_attachment/create)接口获取</para>
        /// <para>必填：否</para>
        /// <para>最大长度：8</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("agent_attachment_ids")]
        public string[]? AgentAttachmentIds { get; set; }
    }
}
