// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3FunctionalRolesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建角色 响应体
/// <para>调用该接口创建一个角色。</para>
/// <para>接口ID：7200215886841135132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fcreate</para>
/// </summary>
public record PostContactV3FunctionalRolesResponseDto
{
    /// <summary>
    /// <para>角色 ID，是角色在当前租户下的唯一标识。</para>
    /// <para>**注意**：建议你在本地保存该 ID，后续可通过该 ID 删除、修改角色。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7vrj3vk70xk7v5r</para>
    /// </summary>
    [JsonPropertyName("role_id")]
    public string RoleId { get; set; } = string.Empty;
}
