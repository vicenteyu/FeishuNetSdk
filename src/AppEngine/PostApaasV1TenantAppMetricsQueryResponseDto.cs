// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="PostApaasV1TenantAppMetricsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用运营数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取应用运营数据 响应体
/// <para>获取 aPaaS 应用活跃数据、存储或运行资源用量数据。</para>
/// <para>接口ID：7600074707548146916</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/tenant_app_metrics/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2ftenant_app_metrics%2fquery</para>
/// </summary>
public record PostApaasV1TenantAppMetricsQueryResponseDto
{
    /// <summary>
    /// <para>查询应用的指标详情列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("metrics")]
    public TenantAppMetrics[]? Metrics { get; set; }

    /// <summary>
    /// <para>查询应用的指标详情列表</para>
    /// </summary>
    public record TenantAppMetrics
    {
        /// <summary>
        /// <para>aPaaS 应用 namespace</para>
        /// <para>必填：否</para>
        /// <para>示例值：package_a__c</para>
        /// </summary>
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// <para>指定应用的指标详情，对 []map[string]int64 数组进行序列化后得到的 json 字符串。数组每个元素包含名称（Name）、数值类型（ValueType）、数值（Value）三个字段。</para>
        /// <para>Name枚举值：</para>
        /// <para>active_user_1dcnt（近1日应用用户活跃数）、</para>
        /// <para>active_user_7dcnt（近7日应用用户活跃数）、</para>
        /// <para>active_user_30dcnt（近30日应用用户活跃数）、</para>
        /// <para>function_run_1dcnt（近1日函数运行次数，含线上环境与开发环境）。</para>
        /// <para>ValueType枚举值：amount（数量）。</para>
        /// <para>json格式：[{"Name":"active_user_1dcnt","ValueType":"amount","Value":100},</para>
        /// <para>{"Name":"active_user_7dcnt","ValueType":"amount","Value":200},</para>
        /// <para>...]</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{\"Name\":\"active_user_30dcnt\",\"ValueType\":\"amount\",\"Value\":6000},{\"Name\":\"active_user_7dcnt\",\"ValueType\":\"amount\",\"Value\":1400},{\"Name\":\"active_user_1dcnt\",\"ValueType\":\"amount\",\"Value\":200},{\"Name\":\"function_run_1dcnt\",\"ValueType\":\"amount\",\"Value\":400}]</para>
        /// </summary>
        [JsonPropertyName("data")]
        public string? Data { get; set; }
    }
}
