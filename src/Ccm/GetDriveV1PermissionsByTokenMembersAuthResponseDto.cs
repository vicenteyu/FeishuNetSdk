// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1PermissionsByTokenMembersAuthResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>判断当前用户是否有某权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 判断当前用户是否有某权限 响应体
/// <para>该接口用于根据 filetoken 判断当前登录用户是否具有某权限。</para>
/// <para>接口ID：7186547801970524161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/auth</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fauth</para>
/// </summary>
public record GetDriveV1PermissionsByTokenMembersAuthResponseDto
{
    /// <summary>
    /// <para>是否有权限</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("auth_result")]
    public bool AuthResult { get; set; }
}
