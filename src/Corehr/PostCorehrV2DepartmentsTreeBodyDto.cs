// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsTreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定生效日期的部门架构树 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定生效日期的部门架构树 请求体
/// <para>支持传入部门ID（不传默认根部门），任意日期（不传默认当前日期）。从给定部门ID开始广度遍历，每页最多返回2000行数据</para>
/// <para>接口ID：7405851978397581314</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2ftree</para>
/// </summary>
public record PostCorehrV2DepartmentsTreeBodyDto
{
    /// <summary>
    /// <para>部门 ID，默认根部门</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893014062142064111</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>是否包含失效部门，默认false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_inactive")]
    public bool? NeedInactive { get; set; }

    /// <summary>
    /// <para>日期，格式yyyy-mm-dd，默认当前日期</para>
    /// <para>- 传2024-01-01，即为返回2024-01-01的组织架构</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }
}
