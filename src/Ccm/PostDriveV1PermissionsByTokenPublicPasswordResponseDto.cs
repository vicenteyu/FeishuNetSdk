// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1PermissionsByTokenPublicPasswordResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>开启密码 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 开启密码 响应体
/// <para>该接口用于根据 filetoken 开启云文档的密码。</para>
/// <para>接口ID：7220305453616152580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/permission-public-password/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public-password%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenPublicPasswordResponseDto
{
    /// <summary>
    /// <para>密码</para>
    /// <para>必填：否</para>
    /// <para>示例值：A8e6</para>
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }
}
