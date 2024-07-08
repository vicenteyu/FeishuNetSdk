// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3FunctionalRolesByRoleIdMembersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量添加角色成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量添加角色成员 请求体
/// <para>调用该接口在指定角色内添加一个或多个成员。</para>
/// <para>接口ID：7200215886841053212</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_create</para>
/// </summary>
public record PostContactV3FunctionalRolesByRoleIdMembersBatchCreateBodyDto
{
    /// <summary>
    /// <para>待添加为角色成员的用户 ID 列表，以 `["xxx", "yyy"]` 数组格式进行传值。ID 类型需要和查询参数 user_id_type 的取值保持一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：["qwer","qweq"]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("members")]
    public string[] Members { get; set; } = Array.Empty<string>();
}
