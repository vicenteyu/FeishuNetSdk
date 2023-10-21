using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单位绑定的部门列表 响应体
/// <para>通过该接口获取单位绑定的部门列表，需具有获取单位的权限。</para>
/// <para>接口ID：7023995901275357187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/list_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2flist_department</para>
/// </summary>
public record GetContactV3UnitListDepartmentResponseDto
{
    /// <summary>
    /// <para>单位绑定的部门列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("departmentlist")]
    public UnitDepartment[] Departmentlists { get; set; } = Array.Empty<UnitDepartment>();

    /// <summary>
    /// <para>单位绑定的部门列表</para>
    /// </summary>
    public record UnitDepartment
    {
        /// <summary>
        /// <para>单位ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：BU121</para>
        /// </summary>
        [JsonProperty("unit_id")]
        public string UnitId { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonProperty("department_id")]
        public string DepartmentId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JdtW=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string PageToken { get; set; } = string.Empty;
}
