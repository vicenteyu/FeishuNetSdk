// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3GroupByGroupIdMemberSimplelistResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询用户组成员列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户组成员列表 响应体
/// <para>调用该接口查询指定用户组内的成员列表，列表内主要包括成员 ID 信息。</para>
/// <para>## 注意事项</para>
/// <para>- 本接口支持查询普通用户组和动态用户组的成员信息。</para>
/// <para>- 本接口支持查询用户组内的用户类型成员或部门类型成员。一次请求中只能查询用户类型成员或者部门类型成员，不支持查询所有类型的用户组成员。</para>
/// <para>- 如果应用的通讯录权限范围是 **全部员工**，则可以查询当前租户下任何用户组成员列表。如果应用的通讯录权限范围不是 **全部员工**，则仅可查询通讯录权限范围内的用户组成员列表。了解通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593072643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fsimplelist</para>
/// </summary>
public record GetContactV3GroupByGroupIdMemberSimplelistResponseDto : IPageableResponse<GetContactV3GroupByGroupIdMemberSimplelistResponseDto.Memberlist>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Memberlist[]? Items => Memberlists;

    /// <summary>
    /// <para>成员列表。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("memberlist")]
    public Memberlist[] Memberlists { get; set; } = Array.Empty<Memberlist>();

    /// <summary>
    /// <para>成员列表。</para>
    /// </summary>
    public record Memberlist
    {
        /// <summary>
        /// <para>成员 ID。ID 类型与请求时设置的 member_id_type 取值保持一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：u287xj12</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组成员的类型。</para>
        /// <para>**可能值有：**</para>
        /// <para>- user：用户类型</para>
        /// <para>- department：部门类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员 ID 类型。该参数仅在请求参数中有效，作为响应体参数时不会返回。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonPropertyName("member_id_type")]
        public string? MemberIdType { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：TDRRV9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiJDGexPw=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
