// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3FunctionalRolesByRoleIdMembersScopesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量设置角色成员管理范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量设置角色成员管理范围 响应体
/// <para>调用该接口为指定角色内的一个或多个角色成员设置管理范围。管理范围是指角色成员可以管理的部门范围。</para>
/// <para>## 注意事项</para>
/// <para>当前应用的通讯录权限范围需要包含待操作的用户与部门，否则将会操作失败。如何设置通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7200215886841118748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fscopes</para>
/// </summary>
public record PatchContactV3FunctionalRolesByRoleIdMembersScopesResponseDto
{
    /// <summary>
    /// <para>设置结果。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("results")]
    public FunctionalRoleMemberResult[]? Results { get; set; }

    /// <summary>
    /// <para>设置结果。</para>
    /// </summary>
    public record FunctionalRoleMemberResult
    {
        /// <summary>
        /// <para>用户 ID，ID 类型与查询参数 user_id_type 的取值保持一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员处理结果。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：处理成功</item>
        /// <item>2：用户 ID 无效</item>
        /// <item>3：无权限操作该用户 ID</item>
        /// <item>4：用户已存在在该角色中</item>
        /// <item>5：用户不存在在该角色中</item>
        /// <item>6：无权限操作该角色成员旧的管理范围</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public int Reason { get; set; }
    }
}
