using Newtonsoft.Json;
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 搜索用户 响应体
/// <para>以用户身份搜索其他用户的信息，无法搜索到外部企业或已离职的用户。</para>
/// <para>调用该接口需要申请 `搜索用户` 权限。</para>
/// <para>接口ID：6907569524100349953</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/search-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMTM4UjLzEDO14yMxgTN</para>
/// </summary>
public record GetSearchV1UserResponseDto
{
    /// <summary>
    /// <para>是否还有更多用户，值为 true 表示存在下一页。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标识，存在下一页的时候返回。下次请求带上此标识可以获取下一页的用户。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>搜索到的用户列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("users")]
    public User[]? Users { get; set; }

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>用户的头像信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("avatar")]
        public AvatarSuffix? Avatar { get; set; }

        /// <summary></summary>
        public record AvatarSuffix
        {
            /// <summary>
            /// <para>用户的头像图片 URL，72×72px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，240×240px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，640×640px。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>用户的头像图片 URL，原始大小。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>用户所在的部门 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户名。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>用户的 open_id。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>用户的 user_id，只有已申请 `获取用户UserID` 权限的企业自建应用返回此字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}
