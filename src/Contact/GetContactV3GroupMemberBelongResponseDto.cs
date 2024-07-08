// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3GroupMemberBelongResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询用户所属用户组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户所属用户组 响应体
/// <para>调用该接口查询指定用户所属的用户组列表。</para>
/// <para>接口ID：7106501358249885699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/member_belong</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fmember_belong</para>
/// </summary>
public record GetContactV3GroupMemberBelongResponseDto
{
    /// <summary>
    /// <para>用户组 ID 列表。</para>
    /// <para>**说明**：你可以调用[查询指定用户组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/group/get)接口，通过用户组 ID 获取用户组的详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("group_list")]
    public string[]? GroupList { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
