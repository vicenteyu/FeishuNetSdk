// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDrivePermissionMemberListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取协作者列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取协作者列表 响应体
/// <para>该接口用于根据文件的 token 查询协作者，目前包括人("user")和群("chat") 。</para>
/// <para>接口ID：6907569523177324545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/obtain-a-collaborator-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATN3UjLwUzN14CM1cTN</para>
/// </summary>
public record PostDrivePermissionMemberListResponseDto
{
    /// <summary>
    /// <para>协作者列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[]? Members { get; set; }

    /// <summary></summary>
    public record Member
    {
        /// <summary>
        /// <para>协作者类型 "user" or "chat"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string? MemberType { get; set; }

        /// <summary>
        /// <para>协作者openid</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_open_id")]
        public string? MemberOpenId { get; set; }

        /// <summary>
        /// <para>协作者userid(仅当member_type="user"时有效)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_user_id")]
        public string? MemberUserId { get; set; }

        /// <summary>
        /// <para>协作者权限 (注意: **有"edit"权限的协作者一定有"view"权限**)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("perm")]
        public string? Perm { get; set; }
    }
}