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
/// <para>调用本接口查询指定角色内的指定成员的管理范围。</para>
/// <para>接口ID：7200215886841069596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fget</para>
/// </summary>
public record GetContactV3FunctionalRolesByRoleIdMembersByMemberIdResponseDto
{
    /// <summary>
    /// <para>成员的管理范围。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("member")]
    public FunctionalRoleMember? Member { get; set; }

    /// <summary>
    /// <para>成员的管理范围。</para>
    /// </summary>
    public record FunctionalRoleMember
    {
        /// <summary>
        /// <para>用户 ID，ID 类型与查询参数 user_id_type 的取值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>管理范围类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：All</para>
        /// <para>可选值：<list type="bullet">
        /// <item>All：全部</item>
        /// <item>Part：部分部门</item>
        /// <item>None：空，即未设置</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scope_type")]
        public string? ScopeType { get; set; }

        /// <summary>
        /// <para>部门 ID 列表，ID 类型与查询参数 department_id_type 的取值保持一致。后续你可以调用[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)接口，根据部门 ID 获取部门详情。</para>
        /// <para>**说明**：仅当 scope_type 取值为 Part 时，才会返回该值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }
    }
}
