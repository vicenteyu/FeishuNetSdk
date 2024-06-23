// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定客服技能 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 查询指定客服技能 响应体
/// <para>该接口用于获取客服技能。</para>
/// <para>接口ID：6955768425688481795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fget</para>
/// </summary>
public record GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDto
{
    /// <summary>
    /// <para>技能</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agent_skill")]
    public GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDtoAgentSkill? AgentSkill { get; set; }

    /// <summary>
    /// <para>技能</para>
    /// </summary>
    public record GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDtoAgentSkill
    {
        /// <summary>
        /// <para>技能id</para>
        /// <para>必填：否</para>
        /// <para>示例值：test-skill-id</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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

        /// <summary>
        /// <para>具有此技能的客服ids</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_ids")]
        public string[]? AgentIds { get; set; }

        /// <summary>
        /// <para>默认技能</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>客服 info</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agents")]
        public Agent[]? Agents { get; set; }

        /// <summary>
        /// <para>客服 info</para>
        /// </summary>
        public record Agent
        {
            /// <summary>
            /// <para>user id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ea651a5c09e2d01af8acd34059f5359b</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>user avatar url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://avatar-url.com/test.png</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>user name</para>
            /// <para>必填：否</para>
            /// <para>示例值：test-user</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
