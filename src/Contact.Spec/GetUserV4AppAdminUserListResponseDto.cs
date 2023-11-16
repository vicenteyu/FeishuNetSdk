namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 查询应用管理员列表 响应体
/// <para>查询审核应用的管理员列表，返回最新10个管理员账户id列表。</para>
/// <para>接口ID：6907569523177406465</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/query-app-administrator-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDOwYjL3gDM24yN4AjN</para>
/// </summary>
public record GetUserV4AppAdminUserListResponseDto
{
    /// <summary>
    /// <para>管理员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_list")]
    public User[]? UserList { get; set; }

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>某管理员的open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>某管理员的user_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>某管理员的union_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }
    }
}
