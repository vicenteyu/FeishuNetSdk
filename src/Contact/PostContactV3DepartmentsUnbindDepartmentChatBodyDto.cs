// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3DepartmentsUnbindDepartmentChatBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>部门群转为普通群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 部门群转为普通群 请求体
/// <para>通过该接口将部门群转为普通群。</para>
/// <para>接口ID：7069758645957836801</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/unbind_department_chat</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2funbind_department_chat</para>
/// </summary>
public record PostContactV3DepartmentsUnbindDepartmentChatBodyDto
{
    /// <summary>
    /// <para>部门ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：D096</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;
}
