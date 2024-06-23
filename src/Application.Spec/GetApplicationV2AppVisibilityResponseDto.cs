// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV2AppVisibilityResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用在企业内的可用范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取应用在企业内的可用范围 响应体
/// <para>该接口用于查询应用在该企业内可以被使用的范围，只能被企业自建应用调用。</para>
/// <para>接口ID：6907569523177160705</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/obtain-the-app-availability-in-an-organization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjM3UjLyIzN14iMycTN</para>
/// </summary>
public record GetApplicationV2AppVisibilityResponseDto
{
    /// <summary>
    /// <para>可用部门列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public Department[]? Departments { get; set; }

    /// <summary></summary>
    public record Department
    {
        /// <summary>
        /// <para>自定义 department_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    /// <summary>
    /// <para>禁用部门列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invisible_departments")]
    public Department[]? InvisibleDepartments { get; set; }

    /// <summary>
    /// <para>可用用户列表（仅包含单独设置的用户，可用部门、用户组中的用户未展开）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public User[]? Users { get; set; }

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>用户的 user_id，只返回给申请了 user_id 权限的企业自建应用</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户的 open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }
    }

    /// <summary>
    /// <para>禁用用户列表（仅包含单独设置的用户，可用部门、用户组中的用户未展开）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invisible_users")]
    public User[]? InvisibleUsers { get; set; }

    /// <summary>
    /// <para>可用用户组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("groups")]
    public Group[]? Groups { get; set; }

    /// <summary></summary>
    public record Group
    {
        /// <summary>
        /// <para>用户组 group_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    /// <summary>
    /// <para>禁用用户组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invisible_groups")]
    public Group[]? InvisibleGroups { get; set; }

    /// <summary>
    /// <para>是否全员可见，1：是，0：否</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_visible_to_all")]
    public int? IsVisibleToAll { get; set; }

    /// <summary>
    /// <para>是否还有更多可见用户，1：是，0：否</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more_users")]
    public int? HasMoreUsers { get; set; }

    /// <summary>
    /// <para>拉取下一页用户列表时使用的 user_page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_page_token")]
    public string? UserPageToken { get; set; }
}
