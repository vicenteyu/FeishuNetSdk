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
/// 更新部门 ID 请求体
/// <para>调用该接口可以更新部门的自定义 ID，即 department_id。</para>
/// <para>接口ID：7257363132833546242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/update_department_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate_department_id</para>
/// </summary>
public record PatchContactV3DepartmentsByDepartmentIdUpdateDepartmentIdBodyDto
{
    /// <summary>
    /// <para>新的自定义部门 ID，即部门的 department_id。</para>
    /// <para>**注意**：</para>
    /// <para>- 不能以 `od-` 开头。</para>
    /// <para>- 不能设置为 `0`。</para>
    /// <para>- 不能与其他未删除部门的 department_id 重复。</para>
    /// <para>必填：是</para>
    /// <para>示例值：NewDevDepartID</para>
    /// <para>最大长度：128</para>
    /// </summary>
    [JsonPropertyName("new_department_id")]
    public string NewDepartmentId { get; set; } = string.Empty;
}
