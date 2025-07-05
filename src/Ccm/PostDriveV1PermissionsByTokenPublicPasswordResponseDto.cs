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
/// 启用云文档密码 响应体
/// <para>启用指定云文档的密码。密码启用后，组织外用户需要密码访问，组织内用户无需密码可直接访问。</para>
/// <para>## 注意事项</para>
/// <para>要启用密码，必须先确保云文档权限中的 **链接分享** 设置为“互联网获得链接的人可编辑/可阅读”。你可通过[更新云文档权限设置](https://open.feishu.cn/document/ukTMukTMukTM/uIzNzUjLyczM14iM3MTN/drive-v2/permission-public/patch)接口设置。</para>
/// <para>接口ID：7220305453616152580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/permission-public-password/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public-password%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenPublicPasswordResponseDto
{
    /// <summary>
    /// <para>密码</para>
    /// <para>必填：否</para>
    /// <para>示例值：q79536&amp;1</para>
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }
}
