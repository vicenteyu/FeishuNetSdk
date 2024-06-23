// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询角色下某个成员的管理范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询角色下某个成员的管理范围 响应体
/// <para>通过本接口可以查询某个成员的管理范围</para>
/// <para>接口ID：7200215886841069596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fget</para>
/// </summary>
public record GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto
{
    /// <summary>
    /// <para>成员的管理范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("member")]
    public FunctionalRoleMember? Member { get; set; }

    /// <summary>
    /// <para>成员的管理范围</para>
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
}
