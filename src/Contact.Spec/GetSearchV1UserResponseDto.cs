// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="GetSearchV1UserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索用户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 搜索用户 响应体
/// <para>调用该接口通过用户名关键词搜索其他用户的信息，包括用户头像、用户名、用户所在部门、用户 user_id 以及 open_id。</para>
/// <para>注意事项：</para>
/// <para>- 仅支持通过用户身份（user_access_token）调用该接口。</para>
/// <para>- 无法搜索到外部企业或已离职的用户。</para>
/// <para>接口ID：6907569524100349953</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/search-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMTM4UjLzEDO14yMxgTN</para>
/// </summary>
public record GetSearchV1UserResponseDto
{
    /// <summary>
    /// <para>是否还有更多数据，当返回值为 true 时，表示存在下一页，即 page_token 不为空。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标识，存在下一页（has_more 为 true）时会返回该值。下次请求带上此标识可以获取下一页的用户数据。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>搜索到的用户列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public User[]? Users { get; set; }

    /// <summary>
    /// 用户信息
    /// </summary>
    public record User
    {
        /// <summary>
        /// <para>用户的头像信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public AvatarInfo? Avatar { get; set; }

        /// <summary>
        /// 用户的头像信息
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>用户的头像图片 URL，大小 72×72 px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，大小 240×240 px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，大小 640×640 px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，原始大小。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>用户所在的部门 ID 列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户名。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>用户的 open_id。open_id 是用户 ID 类型中的一种，详细介绍可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>用户的 user_id。user_id 是用户 ID 类型中的一种，详细介绍可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**说明**：只有已申请 **获取用户 UserID** API 权限的 **企业自建应用** 会返回该字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
