// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostWikiV2SpacesBySpaceIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加知识空间成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 添加知识空间成员 响应体
/// <para>添加知识空间成员或管理员。</para>
/// <para>接口ID：7023947709203906564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdMembersResponseDto
{
    /// <summary>
    /// <para>知识空间成员</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("member")]
    public PostWikiV2SpacesBySpaceIdMembersResponseDtoMember? Member { get; set; }

    /// <summary>
    /// <para>知识空间成员</para>
    /// </summary>
    public record PostWikiV2SpacesBySpaceIdMembersResponseDtoMember
    {
        /// <summary>
        /// <para>要添加的成员或管理员的身份类型。枚举值：</para>
        /// <para>- openchat：群组 ID。参考[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)获取</para>
        /// <para>- userid：用户 ID。详情参考[如何获取 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</para>
        /// <para>- email：用户邮箱</para>
        /// <para>- opendepartmentid：部门 ID。参考[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)获取</para>
        /// <para>- openid：用户的 Open ID。详情参考[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
        /// <para>- unionid：用户的 Union ID。详情参考[如何获取 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
        /// <para>必填：是</para>
        /// <para>示例值：openid</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员或管理员的 ID，值的类型由 member_type 参数决定。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_449b53ad6aee526f7ed311b216aabcef</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员的角色类型。可选值:</para>
        /// <para>- admin：管理员</para>
        /// <para>- member：成员</para>
        /// <para>必填：是</para>
        /// <para>示例值：admin</para>
        /// </summary>
        [JsonPropertyName("member_role")]
        public string MemberRole { get; set; } = string.Empty;

        /// <summary>
        /// <para>知识库协作者类型（未来支持）</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>department：组织架构</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
