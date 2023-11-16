namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 更新客服技能 请求体
/// <para>该接口用于更新客服技能。</para>
/// <para>接口ID：6955768425688416259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fpatch</para>
/// </summary>
public record PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDto
{
    /// <summary>
    /// <para>更新技能</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agent_skill")]
    public PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDtoAgentSkill? AgentSkill { get; set; }

    /// <summary>
    /// <para>更新技能</para>
    /// </summary>
    public record PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDtoAgentSkill
    {
        /// <summary>
        /// <para>技能名</para>
        /// <para>必填：否</para>
        /// <para>示例值：skill-name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>技能rules</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rules")]
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
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>运算符比较, 参考[客服技能运算符选项](https://open.feishu.cn/document/ukTMukTMukTM/ucDOyYjL3gjM24yN4IjN/operator-options)</para>
            /// <para>必填：否</para>
            /// <para>示例值：8</para>
            /// </summary>
            [JsonPropertyName("selected_operator")]
            public int? SelectedOperator { get; set; }

            /// <summary>
            /// <para>rule操作数value，[客服技能及运算符](https://open.feishu.cn/document/ukTMukTMukTM/ucDOyYjL3gjM24yN4IjN/operator-options)</para>
            /// <para>必填：否</para>
            /// <para>示例值：[3]</para>
            /// </summary>
            [JsonPropertyName("operator_options")]
            public int[]? OperatorOptions { get; set; }

            /// <summary>
            /// <para>rule 操作数的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{\"selected_departments\":[{\"id\":\"部门ID\",\"name\":\"IT\"}]}</para>
            /// </summary>
            [JsonPropertyName("operand")]
            public string? Operand { get; set; }
        }

        /// <summary>
        /// <para>具有此技能的客服ids</para>
        /// <para>必填：否</para>
        /// <para>示例值：["ou_ea21d7f018e1155d960e40d33191f966"]</para>
        /// </summary>
        [JsonPropertyName("agent_ids")]
        public string[]? AgentIds { get; set; }
    }
}
