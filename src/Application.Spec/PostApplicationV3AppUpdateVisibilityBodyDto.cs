namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 更新应用可用范围 请求体
/// <para>该接口用于更新当前企业内自建应用或已安装的商店应用的可见范围，包括可用人员与禁用人员。更新后对线上立即生效。</para>
/// <para>当通过接口新增用户或部门时，提前判断对应用户或部门是否已在禁用名单中，如果已在禁用名单中，则即便将用户或部门添加到可用名单，该用户或部门也无法看到该应用，即禁用名单优先级高于可用名单。</para>
/// <para>接口ID：6907569745298800642</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/update-the-availability-of-an-app</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDN3UjL3QzN14yN0cTN</para>
/// </summary>
public record PostApplicationV3AppUpdateVisibilityBodyDto
{
    /// <summary>
    /// <para>目标应用的 ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>删除的用户列表，元素个数不超过 500，**先增加后删除**</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("del_users")]
    public User[]? DelUsers { get; set; }

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>与 user_id 至少给其中之一，user_id 优先于 open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>否</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }

    /// <summary>
    /// <para>增加的用户列表，元素个数不超过500，**先增加后删除**</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_users")]
    public User[]? AddUsers { get; set; }

    /// <summary>
    /// <para>是否全员可见，0：否；1：是；不填：继续当前状态不改变</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_visiable_to_all")]
    public int? IsVisiableToAll { get; set; }

    /// <summary>
    /// <para>添加的部门列表，元素个数不超过 500，**先增加后删除**</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_departments")]
    public string[]? AddDepartments { get; set; }

    /// <summary>
    /// <para>删除的部门列表，元素个数不超过 500，**先增加后删除**</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("del_departments")]
    public string[]? DelDepartments { get; set; }
}
