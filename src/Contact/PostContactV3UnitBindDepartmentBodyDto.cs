namespace FeishuNetSdk.Contact;
/// <summary>
/// 建立部门与单位的绑定关系 请求体
/// <para>通过该接口建立部门与单位的绑定关系。由于单位是旗舰版付费功能，企业需开通相关版本，否则会绑定失败，不同版本请参考[飞书版本对比](https://www.feishu.cn/service)。</para>
/// <para>接口ID：7023995901275324419</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/bind_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fbind_department</para>
/// </summary>
public record PostContactV3UnitBindDepartmentBodyDto
{
    /// <summary>
    /// <para>单位ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonPropertyName("unit_id")]
    public string UnitId { get; set; } = string.Empty;

    /// <summary>
    /// <para>单位关联的部门ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_department_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// </list></para>
    /// <para>默认值：open_department_id</para>
    /// </summary>
    [JsonPropertyName("department_id_type")]
    public string? DepartmentIdType { get; set; }
}
