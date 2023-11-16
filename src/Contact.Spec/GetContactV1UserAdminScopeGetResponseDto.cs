namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 获取应用管理员管理范围 响应体
/// <para>该接口用于获取应用管理员的管理范围，即该应用管理员能够管理哪些部门。 </para>
/// <para>接口ID：6907569742384971778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/obtain-an-app-admin’s-management-permissions</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzN3QjLzczN04yM3cDN</para>
/// </summary>
public record GetContactV1UserAdminScopeGetResponseDto
{
    /// <summary>
    /// <para>是否管理所有部门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_all")]
    public bool? IsAll { get; set; }

    /// <summary>
    /// <para>管理的部门列表，当 is_all 为 true 时，不返回该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_list")]
    public string[]? DepartmentList { get; set; }
}
