using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 查询全部客服技能 响应体
/// <para>获取全部客服技能。</para>
/// <para>接口ID：6955768425688285187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2flist</para>
/// </summary>
public record GetHelpdeskV1AgentSkillsResponseDto
{
    /// <summary>
    /// <para>客服技能列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("agent_skills")]
    public AgentSkill[]? AgentSkills { get; set; }

    /// <summary>
    /// <para>客服技能列表</para>
    /// </summary>
    public record AgentSkill
    {
        /// <summary>
        /// <para>技能id</para>
        /// <para>必填：否</para>
        /// <para>示例值：test-skill-id</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>技能名</para>
        /// <para>必填：否</para>
        /// <para>示例值：skill-name</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>具有此技能的客服ids</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("agent_ids")]
        public string[]? AgentIds { get; set; }

        /// <summary>
        /// <para>默认技能</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }
    }
}
