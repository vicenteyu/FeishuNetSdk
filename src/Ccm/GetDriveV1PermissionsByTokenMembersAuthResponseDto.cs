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
/// 判断用户云文档权限 响应体
/// <para>判断当前请求的应用或用户是否具有指定云文档的指定权限，权限包括阅读、编辑、分享、评论、导出等权限。</para>
/// <para>接口ID：7186547801970524161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/auth</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fauth</para>
/// </summary>
public record GetDriveV1PermissionsByTokenMembersAuthResponseDto
{
    /// <summary>
    /// <para>当前应用或用户是否有指定的权限。可选值：</para>
    /// <para>- true：当前应用或用户具有该权限</para>
    /// <para>- false：当前应用或用户没有该权限</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("auth_result")]
    public bool AuthResult { get; set; }
}
