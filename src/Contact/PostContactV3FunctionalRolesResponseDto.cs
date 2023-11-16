namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建角色 响应体
/// <para>通过”创建角色“接口可批量完成角色创建，新增角色同步展示至租户的管理后台-角色管理模块。</para>
/// <para>接口ID：7200215886841135132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fcreate</para>
/// </summary>
public record PostContactV3FunctionalRolesResponseDto
{
    /// <summary>
    /// <para>角色ID，在单租户下唯一</para>
    /// <para>必填：是</para>
    /// <para>示例值：7vrj3vk70xk7v5r</para>
    /// </summary>
    [JsonPropertyName("role_id")]
    public string RoleId { get; set; } = string.Empty;
}
