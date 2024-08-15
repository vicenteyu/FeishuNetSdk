// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3GroupByGroupIdMemberBatchRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量移除用户组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量移除用户组成员 请求体
/// <para>调用该接口从指定普通用户组内移除一个或多个成员。</para>
/// <para>## 注意事项</para>
/// <para>- 目前仅支持移除用户类型的成员，暂不支持移除部门类型的成员。</para>
/// <para>- 如果应用的通讯录权限范围是 **全部员工**，则可以将任何用户移除任何用户组。如果应用的通讯录权限范围不是 **全部员工**，则所要移除的用户以及对应的用户组，均需要在应用的通讯录权限范围内。了解通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7106501358249869315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fbatch_remove</para>
/// </summary>
public record PostContactV3GroupByGroupIdMemberBatchRemoveBodyDto
{
    /// <summary>
    /// <para>待移除成员信息。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Memberlist[] Members { get; set; } = Array.Empty<Memberlist>();

    /// <summary>
    /// <para>待移除成员信息。</para>
    /// </summary>
    public record Memberlist
    {
        /// <summary>
        /// <para>移除的用户 ID，ID 类型与 member_id_type 的取值保持一致。</para>
        /// <para>你可以调用[查询用户组成员列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/group-member/simplelist)接口，获取用户组内的成员 ID，并将需要移除的成员 ID 传入当前参数。注意仅支持移除用户类型的成员，且需要使用相同的用户 ID 类型，否则会报错。</para>
        /// <para>必填：是</para>
        /// <para>示例值：u287xj12</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组成员的类型，目前仅支持选择 user，表示用户类型。</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>当 `member_type` 取值为 `user`时，该参数必填，需通过该参数设置用户 ID 类型，包括：</para>
        /// <para>- open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</para>
        /// <para>- union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</para>
        /// <para>- user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonPropertyName("member_id_type")]
        public string? MemberIdType { get; set; }
    }
}
