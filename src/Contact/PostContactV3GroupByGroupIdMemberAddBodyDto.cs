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
/// <para>调用该接口向指定的普通用户组内添加成员。</para>
/// <para>## 注意事项</para>
/// <para>- 目前仅支持添加用户类型的成员，暂不支持添加部门类型的成员。</para>
/// <para>- 如果应用的通讯录权限范围是 **全部员工**，则可以将当前租户内的任何用户添加到任何用户组当中。如果应用的通讯录权限范围不是 **全部员工**，则所要添加的用户以及对应的用户组，均需要在应用的通讯录权限范围内。了解通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>## 使用限制</para>
/// <para>单租户内单个普通用户组的成员数量上限为 100,000，但需要注意，单租户内所有普通用户组的成员数量总和不能超过当前租户成员数量的 10 倍。</para>
/// <para>接口ID：7008085931593056259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fadd</para>
/// </summary>
public record PostContactV3GroupByGroupIdMemberAddBodyDto
{
    /// <summary>
    /// <para>用户组成员的类型，目前仅支持选择 user。</para>
    /// <para>必填：是</para>
    /// <para>示例值：user</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user：用户类型。</item>
    /// </list></para>
    /// <para>默认值：user</para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>当 `member_type` 取值为 `user`时，通过该参数设置用户 ID 类型。</para>
    /// <para>必填：是</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("member_id_type")]
    public string MemberIdType { get; set; } = string.Empty;

    /// <summary>
    /// <para>添加的用户 ID，ID 类型与 member_id_type 的取值保持一致。不同类型的 ID 获取方式可参见：</para>
    /// <para>- [如何获取用户 open_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>- [如何获取用户 union_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
    /// <para>- [如何获取用户 user_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;
}
