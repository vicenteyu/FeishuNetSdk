// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3FunctionalRolesByRoleIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询角色下的所有成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询角色下的所有成员信息 响应体
/// <para>通过本接口可以查询角色ID下的成员信息（含成员ID及其管理范围）</para>
/// <para>接口ID：7200215886840987676</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2flist</para>
/// </summary>
public record GetContactV3FunctionalRolesByRoleIdMembersResponseDto
{
    /// <summary>
    /// <para>角色成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("members")]
    public FunctionalRoleMember[]? Members { get; set; }

    /// <summary>
    /// <para>角色成员列表</para>
    /// </summary>
    public record FunctionalRoleMember
    {
        /// <summary>
        /// <para>成员ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>管理范围的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：All</para>
        /// <para>可选值：<list type="bullet">
        /// <item>All：管理范围是全部</item>
        /// <item>Part：管理范围是部分</item>
        /// <item>None：管理范围为空</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scope_type")]
        public string? ScopeType { get; set; }

        /// <summary>
        /// <para>表示该角色成员的管理范围，scope_type为“指定范围”时，返回该值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：2132323</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
