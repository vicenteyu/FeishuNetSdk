namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取协作者列表（新版本） 响应体
/// <para>该接口用于根据 filetoken 查询协作者</para>
/// <para>接口ID：7121656165336367106</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2flist</para>
/// </summary>
public record GetDriveV1PermissionsByTokenMembersResponseDto
{
    /// <summary>
    /// <para>返回的列表数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Member[]? Items { get; set; }

    /// <summary>
    /// <para>返回的列表数据</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：openid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>email：飞书邮箱</item>
        /// <item>openid：[开放平台ID](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)</item>
        /// <item>openchat：[开放平台群组ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</item>
        /// <item>opendepartmentid：[开放平台部门ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</item>
        /// <item>userid：[用户自定义ID](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者对应的权限角色</para>
        /// <para>必填：是</para>
        /// <para>示例值：view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>view：可阅读角色</item>
        /// <item>edit：可编辑角色</item>
        /// <item>full_access：可管理角色</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("perm")]
        public string Perm { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者的类型</para>
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

        /// <summary>
        /// <para>协作者的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>协作者的头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://foo.icon.com/xxxx</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>协作者的外部标签</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("external_label")]
        public bool? ExternalLabel { get; set; }
    }
}
