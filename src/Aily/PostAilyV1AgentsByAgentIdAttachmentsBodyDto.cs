// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdAttachmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传附件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 上传附件 请求体
/// <para>本接口用于上传需智能体分析的文件，上传成功后返回附件 ID。</para>
/// <para>接口ID：7646811253679787187</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_attachment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_attachment%2fcreate</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdAttachmentsBodyDto
{
    /// <summary>
    /// <para>附件类型</para>
    /// <para>- 当设置为 `image`或者`file` 时，file必传，doc_url不生效</para>
    /// <para>- 当设置为 `feishu_doc`或者`bitable` 时，doc_url必传，file不生效</para>
    /// <para>- 可选类型，image、file、feishu_doc、bitable</para>
    /// <para>必填：是</para>
    /// <para>示例值：image</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>云文档/多维表格url，仅在type=bitable或者feishu_doc时需要传入</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://bytedance.larkoffice.com/wiki/PRSdJR8NowW5gxguFGcm9Hpn</para>
    /// <para>最大长度：512</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("doc_url")]
    public string? DocUrl { get; set; }
}
