// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取员工信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 批量获取员工信息 请求体
/// <para>本接口用于批量根据员工的ID查询员工的详情，比如员工姓名，手机号，邮箱，部门等信息。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」</para>
/// <para>接口ID：7359428154233520132</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fmget</para>
/// </summary>
public record PostDirectoryV1EmployeesMgetBodyDto
{
    /// <summary>
    /// <para>员工ID，与employee_id_type类型保持一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("employee_ids")]
    public string[] EmployeeIds { get; set; } = [];

    /// <summary>
    /// <para>需要查询的字段列表。将按照传递的字段列表返回有权限的行、列数据。不传则不会返回任何字段。[了解更多：字段枚举说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/field-enumeration)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("required_fields")]
    public string[] RequiredFields { get; set; } = [];
}
