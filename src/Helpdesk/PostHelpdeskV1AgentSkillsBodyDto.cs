using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建客服技能 请求体
/// <para>该接口用于创建客服技能。</para>
/// <para>接口ID：6955768425688268803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fcreate</para>
/// </summary>
public record PostHelpdeskV1AgentSkillsBodyDto
{
    /// <summary>
    /// <para>技能名</para>
    /// <para>必填：否</para>
    /// <para>示例值：test-skill</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>技能rules</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("rules")]
    public AgentSkillRule[]? Rules { get; set; }

    /// <summary>
    /// <para>技能rules</para>
    /// </summary>
    public record AgentSkillRule
    {
        /// <summary>
        /// <para>rule id, 参考[获取客服技能rules](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent_skill_rule/list) 用于获取rules options</para>
        /// <para>必填：否</para>
        /// <para>示例值：test-skill-id</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>运算符比较, 参考[客服技能运算符选项](https://open.feishu.cn/document/ukTMukTMukTM/ucDOyYjL3gjM24yN4IjN/operator-options)</para>
        /// <para>必填：否</para>
        /// <para>示例值：8</para>
        /// </summary>
        [JsonProperty("selected_operator")]
        public int? SelectedOperator { get; set; }

        /// <summary>
        /// <para>rule 操作数的值</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"selected_departments\":[{\"id\":\"部门ID\",\"name\":\"IT\"}]}</para>
        /// </summary>
        [JsonProperty("operand")]
        public string? Operand { get; set; }

        /// <summary>
        /// <para>rule 类型，1-知识库，2-工单信息，3-用户飞书信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonProperty("category")]
        public int? Category { get; set; }
    }

    /// <summary>
    /// <para>客服 ids</para>
    /// <para>必填：否</para>
    /// <para>示例值：["客服ID"]</para>
    /// </summary>
    [JsonProperty("agent_ids")]
    public string[]? AgentIds { get; set; }
}
