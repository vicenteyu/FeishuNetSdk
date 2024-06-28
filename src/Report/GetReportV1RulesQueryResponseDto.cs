// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="GetReportV1RulesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Report;
/// <summary>
/// 查询规则 响应体
/// <para>查询规则。</para>
/// <para>接口ID：6969187588792385564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/rule/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2frule%2fquery</para>
/// </summary>
public record GetReportV1RulesQueryResponseDto
{
    /// <summary>
    /// <para>规则列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rules")]
    public Rule[]? Rules { get; set; }

    /// <summary>
    /// <para>规则列表</para>
    /// </summary>
    public record Rule
    {
        /// <summary>
        /// <para>规则唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：6894788526240432147</para>
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string? RuleId { get; set; }

        /// <summary>
        /// <para>规则名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：工作月报</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>规则图标</para>
        /// <para>必填：否</para>
        /// <para>示例值：日报</para>
        /// </summary>
        [JsonPropertyName("icon_name")]
        public string? IconName { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622427266</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>创建人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_133f0b6d0f097cf7d7ba00b38fffb110</para>
        /// </summary>
        [JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// <para>创建人名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("creator_user_name")]
        public string? CreatorUserName { get; set; }

        /// <summary>
        /// <para>规则所有者ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_133f0b6d0f097cf7d7ba00b38fffb111</para>
        /// </summary>
        [JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// <para>规则所有者名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("owner_user_name")]
        public string? OwnerUserName { get; set; }

        /// <summary>
        /// <para>表单定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("form_schema")]
        public FormField[]? FormSchemas { get; set; }

        /// <summary>
        /// <para>表单定义</para>
        /// </summary>
        public record FormField
        {
            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_133f0b6d0f097cf7d7ba00b38fffb112</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text：文本</item>
            /// <item>number：数字</item>
            /// <item>dropdown：单选</item>
            /// <item>image：图片</item>
            /// <item>attachement：附件</item>
            /// <item>multiSelect：多选</item>
            /// <item>address：地址</item>
            /// <item>datetime：时间</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>规则是否已删除</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未删除</item>
        /// <item>1：已删除</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// <para>需要汇报的用户ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['ou_c04cebc780341ab22bd311ba6902ffsd']</para>
        /// </summary>
        [JsonPropertyName("need_report_user_ids")]
        public string[]? NeedReportUserIds { get; set; }

        /// <summary>
        /// <para>需要汇报的部门ID列表（如果id为0，表示全员）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("need_report_department_ids")]
        public string[]? NeedReportDepartmentIds { get; set; }

        /// <summary>
        /// <para>需要汇报的群ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['oc_a7bb9ca5efa68ab8b4fdd2e3b54ffref']</para>
        /// </summary>
        [JsonPropertyName("need_report_chat_ids")]
        public string[]? NeedReportChatIds { get; set; }

        /// <summary>
        /// <para>抄送用户ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['ou_45454c20ef2c92c173445abf6f4955rf']</para>
        /// </summary>
        [JsonPropertyName("cc_user_ids")]
        public string[]? CcUserIds { get; set; }

        /// <summary>
        /// <para>抄送部门ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['od-251480c0bfb8c5c8784ea194ef8b734d']</para>
        /// </summary>
        [JsonPropertyName("cc_department_ids")]
        public string[]? CcDepartmentIds { get; set; }

        /// <summary>
        /// <para>汇报对象用户ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['ou_c04cebc780341ab22bd311ba6902fdfe']</para>
        /// </summary>
        [JsonPropertyName("to_user_ids")]
        public string[]? ToUserIds { get; set; }

        /// <summary>
        /// <para>汇报对象群ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['oc_a7bb9ca5efa68ab8b4fdd2e3b54fcerf']</para>
        /// </summary>
        [JsonPropertyName("to_chat_ids")]
        public string[]? ToChatIds { get; set; }

        /// <summary>
        /// <para>上级汇报对象，0表示第一级，依次类推，最大为5表示第六级</para>
        /// <para>必填：否</para>
        /// <para>示例值：[0]</para>
        /// </summary>
        [JsonPropertyName("to_leaders")]
        public int[]? ToLeaders { get; set; }

        /// <summary>
        /// <para>部门负责人汇报对象，0表示第一级，依次类推，最大为5表示第六级</para>
        /// <para>必填：否</para>
        /// <para>示例值：[0]</para>
        /// </summary>
        [JsonPropertyName("to_department_owners")]
        public int[]? ToDepartmentOwners { get; set; }

        /// <summary>
        /// <para>规则管理员用户ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['ou_c04cebc780341ab22bd311ba6902sseb']</para>
        /// </summary>
        [JsonPropertyName("manager_user_ids")]
        public string[]? ManagerUserIds { get; set; }

        /// <summary>
        /// <para>抄送群ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：['oc_a7bb9ca5efa68ab8b4fdd2e3b54fffsf']</para>
        /// </summary>
        [JsonPropertyName("cc_chat_ids")]
        public string[]? CcChatIds { get; set; }
    }
}
