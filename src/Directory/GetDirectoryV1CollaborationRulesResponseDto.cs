// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetDirectoryV1CollaborationRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询可搜可见规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 查询可搜可见规则 响应体
/// <para>管理员视角查询可搜可见规则。用户需具备关联组织管理员权限。</para>
/// <para>接口ID：7442539768884543516</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2flist</para>
/// </summary>
public record GetDirectoryV1CollaborationRulesResponseDto
{
    /// <summary>
    /// <para>规则列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CollaborationRule[]? Items { get; set; }

    /// <summary>
    /// <para>规则列表</para>
    /// </summary>
    public record CollaborationRule
    {
        /// <summary>
        /// <para>规则ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：12121</para>
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string? RuleId { get; set; }

        /// <summary>
        /// <para>实体数量之和需要小于100</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("subjects")]
        public CollaborationRuleEntities? Subjects { get; set; }

        /// <summary>
        /// <para>实体数量之和需要小于100</para>
        /// </summary>
        public record CollaborationRuleEntities
        {
            /// <summary>
            /// <para>用户 open id</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("open_user_ids")]
            public string[]? OpenUserIds { get; set; }

            /// <summary>
            /// <para>部门 open id，0代表全部成员</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("open_department_ids")]
            public string[]? OpenDepartmentIds { get; set; }

            /// <summary>
            /// <para>用户组 open id</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("open_group_ids")]
            public string[]? OpenGroupIds { get; set; }
        }

        /// <summary>
        /// <para>是否生效，如果规则主体超出了分享的范围，则is_valid为false，规则主体将不返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("subject_is_valid")]
        public bool? SubjectIsValid { get; set; }

        /// <summary>
        /// <para>实体数量之和需要小于100</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("objects")]
        public CollaborationRuleEntities? Objects { get; set; }

        /// <summary>
        /// <para>是否生效，如果规则客体超出了分享的范围，则is_valid为false，规则客体将不返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("object_is_valid")]
        public bool? ObjectIsValid { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
