// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3FunctionalRolesByRoleIdMembersBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量添加角色成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量添加角色成员 响应体
/// <para>调用该接口在指定角色内添加一个或多个成员。</para>
/// <para>接口ID：7200215886841053212</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_create</para>
/// </summary>
public record PostContactV3FunctionalRolesByRoleIdMembersBatchCreateResponseDto
{
    /// <summary>
    /// <para>添加结果。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("results")]
    public FunctionalRoleMemberResult[]? Results { get; set; }

    /// <summary>
    /// <para>添加结果。</para>
    /// </summary>
    public record FunctionalRoleMemberResult
    {
        /// <summary>
        /// <para>用户 ID，ID 类型需要和查询参数 user_id_type 的取值保持一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>添加成员的处理结果。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：处理成功</item>
        /// <item>2：用户 ID 无效</item>
        /// <item>3：无权限操作该用户 ID</item>
        /// <item>4：用户已存在该角色中</item>
        /// <item>5：用户不存在该角色中</item>
        /// <item>6：无权限操作该角色成员旧的管理范围</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public int Reason { get; set; }
    }
}
