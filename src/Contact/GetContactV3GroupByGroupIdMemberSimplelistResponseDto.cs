namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户组成员列表 响应体
/// <para>通过该接口可查询某个用户组的成员列表（支持查询成员中的用户和部门）, 本接口支持普通用户组和动态用户组。如果应用的通讯录权限范围是“全部员工”，则可查询企业内任何用户组的成员列表。如果应用的通讯录权限范围不是“全部员工”，则仅可查询通讯录权限范围中的用户组的成员列表，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593072643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fsimplelist</para>
/// </summary>
public record GetContactV3GroupByGroupIdMemberSimplelistResponseDto
{
    /// <summary>
    /// <para>成员列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("memberlist")]
    public Memberlist[] Memberlists { get; set; } = Array.Empty<Memberlist>();

    /// <summary>
    /// <para>成员列表</para>
    /// </summary>
    public record Memberlist
    {
        /// <summary>
        /// <para>成员ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：u287xj12</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组成员的类型，取值为 user或department。</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>当member_type为user时，member_id_type表示user_id_type，可选值为open_id, union_id, user_id。仅在请求参数中有效，响应体中不会返回此参数。</para>
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
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
