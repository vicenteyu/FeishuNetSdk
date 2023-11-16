namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建用户组 响应体
/// <para>使用该接口创建用户组，请注意创建用户组时应用的通讯录权限范围需为“全部员工”，否则会创建失败，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fcreate</para>
/// </summary>
public record PostContactV3GroupResponseDto
{
    /// <summary>
    /// <para>用户组ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：g122817</para>
    /// </summary>
    [JsonPropertyName("group_id")]
    public string GroupId { get; set; } = string.Empty;
}
