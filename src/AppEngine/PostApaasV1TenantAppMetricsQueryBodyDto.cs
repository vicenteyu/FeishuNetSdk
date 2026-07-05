// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostApaasV1TenantAppMetricsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用运营数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取应用运营数据 请求体
/// <para>获取 aPaaS 应用活跃数据、存储或运行资源用量数据。</para>
/// <para>接口ID：7600074707548146916</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/tenant_app_metrics/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2ftenant_app_metrics%2fquery</para>
/// </summary>
public record PostApaasV1TenantAppMetricsQueryBodyDto
{
    /// <summary>
    /// <para>aPaaS 应用 namespace 列表，单次请求最多查询 20 个 namespace。namespace 可以通过 aPaaS 平台-开放中心-应用管理页面获取</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("namespaces")]
    public string[] Namespaces { get; set; } = [];

    /// <summary>
    /// <para>查询日期，支持查询最近一年至前一日数据。日期格式为 YYYY-MM-DD</para>
    /// <para>必填：是</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;
}
