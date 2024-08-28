// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteCorehrV2CostCentersByCostCenterIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 删除成本中心 请求体
/// <para>删除成本中心记录</para>
/// <para>接口ID：7225452763517157379</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fdelete</para>
/// </summary>
public record DeleteCorehrV2CostCentersByCostCenterIdBodyDto
{
    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：随着组织架构调整，该成本中心不再使用</para>
    /// </summary>
    [JsonPropertyName("operation_reason")]
    public string OperationReason { get; set; } = string.Empty;
}
