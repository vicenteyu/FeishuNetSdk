namespace FeishuNetSdk.Contact;
/// <summary>
/// 搜索部门 请求体
/// <para>搜索部门，用户通过关键词查询可见的部门数据，部门可见性需要管理员在后台配置。</para>
/// <para>接口ID：6943913881476841499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fsearch</para>
/// </summary>
public record PostContactV3DepartmentsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词，匹配字段为部门名称（不支持匹配部门国际化名称）</para>
    /// <para>必填：是</para>
    /// <para>示例值：DemoName</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
}
