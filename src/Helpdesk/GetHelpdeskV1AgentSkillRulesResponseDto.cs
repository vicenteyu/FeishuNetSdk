namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 获取客服技能列表 响应体
/// <para>该接口用于获取全部客服技能。仅支持自建应用。</para>
/// <para>接口ID：6955768425688317955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill_rule%2flist</para>
/// </summary>
public record GetHelpdeskV1AgentSkillRulesResponseDto
{
    /// <summary>
    /// <para>rules列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rules")]
    public AgentSkillRule[]? Rules { get; set; }

    /// <summary>
    /// <para>rules列表</para>
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
        /// <para>rule操作数value，[客服技能及运算符](https://open.feishu.cn/document/ukTMukTMukTM/ucDOyYjL3gjM24yN4IjN/operator-options)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_options")]
        public int[]? OperatorOptions { get; set; }

        /// <summary>
        /// <para>rule 操作数的值。该参数类型为泛型，会指向多类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"selected_departments\":[{\"id\":\"部门ID\",\"name\":\"IT\"}]}</para>
        /// </summary>
        [JsonPropertyName("operand")]
        public string? Operand { get; set; }

        /// <summary>
        /// <para>rule 类型，1-知识库，2-工单信息，3-用户飞书信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("category")]
        public int? Category { get; set; }

        /// <summary>
        /// <para>rule 名</para>
        /// <para>必填：否</para>
        /// <para>示例值：中文知识库分类</para>
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }
    }
}
