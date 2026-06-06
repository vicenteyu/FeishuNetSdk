// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostAilyV1AgentsByAgentIdAgentVisibilityCheckResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取当前用户的可见性 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 获取当前用户的可见性 响应体
/// <para>查询当前调用用户对指定智能体的可见性。接口根据UserAccessToken(用户身份凭证)解析出当前用户,结合传入的 channel_type(渠道类型),返回可见性。</para>
/// <para>接口ID：7646811253679836339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_visibility/check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_visibility%2fcheck</para>
/// </summary>
public record PostAilyV1AgentsByAgentIdAgentVisibilityCheckResponseDto
{
    /// <summary>
    /// <para>可见性</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("visibility")]
    public bool? Visibility { get; set; }
}
