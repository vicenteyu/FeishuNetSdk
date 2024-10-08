// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteCorehrV2CostCentersByCostCenterIdVersionsByVersionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销成本中心版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销成本中心版本 请求体
/// <para>该接口支持通过成本中心的版本ID撤销成本中心版本信息</para>
/// <para>接口ID：7225452763517124611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/cost_center-version/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center-version%2fdelete</para>
/// </summary>
public record DeleteCorehrV2CostCentersByCostCenterIdVersionsByVersionIdBodyDto
{
    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：随着组织架构调整，该成本中心不再使用</para>
    /// </summary>
    [JsonPropertyName("operation_reason")]
    public string OperationReason { get; set; } = string.Empty;
}
