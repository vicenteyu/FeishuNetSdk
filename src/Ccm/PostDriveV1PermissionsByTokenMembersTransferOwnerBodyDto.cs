// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转移所有者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 转移所有者 请求体
/// <para>该接口用于根据云文档 token 和用户信息转移文件的所有者。</para>
/// <para>接口ID：7186547801970507777</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/transfer_owner</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2ftransfer_owner</para>
/// </summary>
public record PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto
{
    /// <summary>
    /// <para>文件所有者的 ID 类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：openid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>email：飞书邮箱</item>
    /// <item>openid：开放平台ID</item>
    /// <item>userid：用户自定义ID</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件所有者的 ID，与文件所有者的 ID 类型需要对应</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_67e5ecb64ce1c0bd94612c17999db411</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;
}
