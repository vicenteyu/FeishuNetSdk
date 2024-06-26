// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDrivePermissionMemberTransferResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转移拥有者 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 转移拥有者 响应体
/// <para>该接口用于根据文档信息和用户信息转移文档的所有者。</para>
/// <para>接口ID：6907569744329719809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/transfer-ownership</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzNzUjL0czM14CN3MTN</para>
/// </summary>
public record PostDrivePermissionMemberTransferResponseDto
{
    /// <summary>
    /// <para>请求是否成功</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_success")]
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// <para>文档类型，可选 **doc、sheet、bitable、file**</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>文档的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>文档当前所有者</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("owner")]
    public OwnerSuffix? Owner { get; set; }

    /// <summary></summary>
    public record OwnerSuffix
    {
        /// <summary>
        /// <para>用户类型，有 **email、openid、userid、unionid**</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string? MemberType { get; set; }

        /// <summary>
        /// <para>用户类型下的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string? MemberId { get; set; }
    }
}
