namespace FeishuNetSdk.Contact;
/// <summary>
/// 修改角色名称 请求体
/// <para>通过本接口可以修改角色名称</para>
/// <para>接口ID：7200215886841085980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role%2fupdate</para>
/// </summary>
public record PutContactV3FunctionalRolesByRoleIdBodyDto
{
    /// <summary>
    /// <para>修改的角色名称，在单租户下唯一</para>
    /// <para>必填：是</para>
    /// <para>示例值：考勤管理员</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("role_name")]
    public string RoleName { get; set; } = string.Empty;
}
