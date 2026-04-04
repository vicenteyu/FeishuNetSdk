// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgCreateEmpCustomOrgResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 新增人员自定义组织变更记录 响应体
/// <para>为指定员工添加某一自定义组织变更记录</para>
/// <para>接口ID：7425878850969403396</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/create_emp_custom_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fcreate_emp_custom_org</para>
/// </summary>
public record PostCorehrV2CustomOrgCreateEmpCustomOrgResponseDto
{
    /// <summary>
    /// <para>自定义组织ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7293841029445207596</para>
    /// </summary>
    [JsonPropertyName("job_data_custom_org_id")]
    public string JobDataCustomOrgId { get; set; } = string.Empty;

    /// <summary>
    /// <para>版本ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7293841029445207593</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string VersionId { get; set; } = string.Empty;
}
