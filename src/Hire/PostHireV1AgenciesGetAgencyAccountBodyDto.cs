// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1AgenciesGetAgencyAccountBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询猎头供应商下猎头列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询猎头供应商下猎头列表 请求体
/// <para>根据猎头供应商 ID 查询该猎头供应商下的猎头列表。</para>
/// <para>接口ID：7413697955198058500</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/get_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fget_agency_account</para>
/// </summary>
public record PostHireV1AgenciesGetAgencyAccountBodyDto
{
    /// <summary>
    /// <para>猎头供应商 ID，可通过[搜索猎头供应商列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/batch_query)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7398623155442682156</para>
    /// </summary>
    [JsonPropertyName("supplier_id")]
    public string SupplierId { get; set; } = string.Empty;

    /// <summary>
    /// <para>猎头状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：正常</item>
    /// <item>1：已禁用</item>
    /// <item>2：已被猎头供应商停用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>角色</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：管理员</item>
    /// <item>1：顾问</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("role")]
    public int? Role { get; set; }
}
