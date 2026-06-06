// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdAttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 上传附件 响应体
/// <para>本接口用于上传需智能体分析的文件，上传成功后返回附件 ID。</para>
/// <para>接口ID：7646811253679787187</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_attachment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_attachment%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdAttachmentsResponseDto
{
    /// <summary>
    /// <para>附件id</para>
    /// <para>必填：是</para>
    /// <para>示例值：3d058789-6952-4697-bf9c-1add1ebc206e</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("agent_attachment_id")]
    public string AgentAttachmentId { get; set; } = string.Empty;
}
