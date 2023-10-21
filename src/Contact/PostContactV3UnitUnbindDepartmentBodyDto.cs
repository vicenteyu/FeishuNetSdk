using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 解除部门与单位的绑定关系 请求体
/// <para>通过该接口解除部门与单位的绑定关系，需更新单位的权限，需对应部门的通讯录权限。由于单位是旗舰版付费功能，企业需开通相关功能，否则会解绑失败。</para>
/// <para>接口ID：7023995901275340803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/unbind_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2funbind_department</para>
/// </summary>
public record PostContactV3UnitUnbindDepartmentBodyDto
{
    /// <summary>
    /// <para>单位ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonProperty("unit_id")]
    public string UnitId { get; set; } = string.Empty;

    /// <summary>
    /// <para>预解除关联的部门ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonProperty("department_id")]
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
    [JsonProperty("department_id_type")]
    public string? DepartmentIdType { get; set; }
}
