// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-25
//
// Last Modified By : yxr
// Last Modified On : 2024-10-25
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdSkillsBySkillIdStartResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>调用技能 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 调用技能 响应体
/// <para>该 API 用于调用某个 Aily 应用的特定技能，支持指定技能入参；并同步返回技能执行的结果。</para>
/// <para>&gt; **技能 API** 能显著简化业务系统的集成工作（单轮 API 调用）。技能 API 提供更贴合系统间服务调用的参数传递模式（JSON 入参 / 出参），且无需通过文本消息对话的方式调用 AI 能力。</para>
/// <para>&lt;div style="text-align: center;"&gt;</para>
/// <para>接口ID：7429225800963031042</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/app-skill/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fstart</para>
/// </summary>
public record PostAilyV1AppsByAppIdSkillsBySkillIdStartResponseDto
{
    /// <summary>
    /// <para>技能的输出</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"input":"你好","custom":true}</para>
    /// <para>最大长度：40960</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }

    /// <summary>
    /// <para>技能的执行状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
