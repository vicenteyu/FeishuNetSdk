namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建客服技能 响应体
/// <para>该接口用于创建客服技能。</para>
/// <para>接口ID：6955768425688268803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fcreate</para>
/// </summary>
public record PostHelpdeskV1AgentSkillsResponseDto
{
    /// <summary>
    /// <para>客服技能id</para>
    /// <para>必填：否</para>
    /// <para>示例值：test-skill-id</para>
    /// </summary>
    [JsonPropertyName("agent_skill_id")]
    public string? AgentSkillId { get; set; }
}
