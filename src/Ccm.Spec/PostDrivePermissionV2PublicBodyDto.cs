// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDrivePermissionV2PublicBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取云文档权限设置V2 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取云文档权限设置V2 请求体
/// <para>该接口用于根据 filetoken 获取云文档的权限设置。</para>
/// <para>接口ID：6907569524099940353</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/get-document-sharing-settings-v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITM3YjLyEzN24iMxcjN</para>
/// </summary>
public record PostDrivePermissionV2PublicBodyDto
{
    /// <summary>
    /// <para>文件的 token，获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#8353e05f)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档类型 "doc", "sheet" or "isv"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
