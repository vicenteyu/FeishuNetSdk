// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="PostCorehrV2CompaniesActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用/停用公司 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启用/停用公司 请求体
/// <para>对公司进行启用或停用操作</para>
/// <para>接口ID：7408127338960781340</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2factive</para>
/// </summary>
public record PostCorehrV2CompaniesActiveBodyDto
{
    /// <summary>
    /// <para>公司 ID</para>
    /// <para>- 可从 [批量查询公司](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)的 id 字段中获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1616161616</para>
    /// </summary>
    [JsonPropertyName("company_id")]
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// <para>公司启用/停用生效时间</para>
    /// <para>- 填写格式： YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 ～ 9999-12-31</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>启用/停用状态。</para>
    /// <para>- active 传 true 代表启用</para>
    /// <para>- active 传 false 代表停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：业务操作</para>
    /// </summary>
    [JsonPropertyName("operation_reason")]
    public string OperationReason { get; set; } = string.Empty;
}
