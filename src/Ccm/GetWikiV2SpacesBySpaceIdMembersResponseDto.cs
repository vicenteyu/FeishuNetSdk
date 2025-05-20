// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="GetWikiV2SpacesBySpaceIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取知识空间成员列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取知识空间成员列表 响应体
/// <para>获取知识空间的成员与管理员列表。</para>
/// <para>接口ID：7386702252390449180</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/wiki-v2/space-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2flist</para>
/// </summary>
public record GetWikiV2SpacesBySpaceIdMembersResponseDto : IPageableResponse<GetWikiV2SpacesBySpaceIdMembersResponseDto.Member>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Member[]? Items => Members;

    /// <summary>
    /// <para>空间成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[]? Members { get; set; }

    /// <summary>
    /// <para>空间成员列表</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>知识库协作者 ID 类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：openid</para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>知识库协作者 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_67e5ecb64ce1c0bd94612c17999db411</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>知识库协作者角色</para>
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

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_12345</para>
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
