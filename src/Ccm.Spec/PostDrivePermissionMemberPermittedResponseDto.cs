// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDrivePermissionMemberPermittedResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>判断协作者是否有某权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 判断协作者是否有某权限 响应体
/// <para>该接口用于根据 filetoken 判断当前登录用户是否具有某权限。</para>
/// <para>接口ID：6907569524101087233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/querying-if-a-collaborator-has-a-specific-permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN3UjL2czN14iN3cTN</para>
/// </summary>
public record PostDrivePermissionMemberPermittedResponseDto
{
    /// <summary>
    /// <para>是否具有指定权限</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_permitted")]
    public bool? IsPermitted { get; set; }
}
