// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgEditEmpCustomOrgResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新人员自定义组织变更记录 响应体
/// <para>更新指定员工的某一条自定义组织变更记录</para>
/// <para>接口ID：7425878850969452548</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/edit_emp_custom_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fedit_emp_custom_org</para>
/// </summary>
public record PostCorehrV2CustomOrgEditEmpCustomOrgResponseDto
{
    /// <summary>
    /// <para>添加成功</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}
