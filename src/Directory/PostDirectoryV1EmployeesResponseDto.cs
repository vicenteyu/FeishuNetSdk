// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建员工 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 创建员工 响应体
/// <para>本接口用于在企业下创建员工，可以理解为员工入职。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」</para>
/// <para>接口ID：7359428154233651204</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fcreate</para>
/// </summary>
public record PostDirectoryV1EmployeesResponseDto
{
    /// <summary>
    /// <para>员工ID</para>
    /// <para>**当`employee_id_type`值为 `employee_id`，字段权限要求**：</para>
    /// <para>- directory:employee.base.external_id:read : 查看员工自定义 ID</para>
    /// <para>&lt;/md-dt-td&gt;</para>
    /// <para>&lt;/md-dt-tr&gt;</para>
    /// <para>必填：否</para>
    /// <para>示例值：sderdt</para>
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }
}
