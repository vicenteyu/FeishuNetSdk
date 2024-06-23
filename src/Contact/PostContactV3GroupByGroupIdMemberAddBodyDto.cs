// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3GroupByGroupIdMemberAddBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加用户组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 添加用户组成员 请求体
/// <para>向用户组中添加成员(目前成员仅支持用户，未来会支持部门)，如果应用的通讯录权限范围是“全部员工”，则可将任何成员添加到任何用户组。如果应用的通讯录权限范围不是“全部员工”，则仅可将通讯录权限范围中的成员添加到通讯录权限范围的用户组中，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593056259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fadd</para>
/// </summary>
public record PostContactV3GroupByGroupIdMemberAddBodyDto
{
    /// <summary>
    /// <para>用户组成员的类型，取值为 user</para>
    /// <para>必填：是</para>
    /// <para>示例值：user</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user：用户成员</item>
    /// </list></para>
    /// <para>默认值：user</para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>当member_type =user时候，member_id_type表示user_id_type，枚举值为open_id, union_id, user_id</para>
    /// <para>必填：是</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>open_id：member_type=user时候，表示用户的open_id</item>
    /// <item>union_id：member_type=user时候，表示用户的union_id</item>
    /// <item>user_id：member_type=user时候，表示用户的user_id</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("member_id_type")]
    public string MemberIdType { get; set; } = string.Empty;

    /// <summary>
    /// <para>添加的成员ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;
}
