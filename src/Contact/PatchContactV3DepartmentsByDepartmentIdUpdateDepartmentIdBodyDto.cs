// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3DepartmentsByDepartmentIdUpdateDepartmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新部门ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新部门ID 请求体
/// <para>此接口可用户更新部门ID(department_id)。新的部门ID(department_id)需要确认在企业内未被占用。</para>
/// <para>接口ID：7257363132833546242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/update_department_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate_department_id</para>
/// </summary>
public record PatchContactV3DepartmentsByDepartmentIdUpdateDepartmentIdBodyDto
{
    /// <summary>
    /// <para>新的部门自定义ID(department_id)</para>
    /// <para>必填：是</para>
    /// <para>示例值：NewDevDepartID</para>
    /// <para>最大长度：128</para>
    /// </summary>
    [JsonPropertyName("new_department_id")]
    public string NewDepartmentId { get; set; } = string.Empty;
}
