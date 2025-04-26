// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2DefaultCostCentersCreateVersionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加默认成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 添加默认成本中心 响应体
/// <para>添加默认成本中心</para>
/// <para>接口ID：7486406573931675651</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/create_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fcreate_version</para>
/// </summary>
public record PostCorehrV2DefaultCostCentersCreateVersionResponseDto
{
    /// <summary>
    /// <para>默认成本中心id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("wk_id")]
    public string? WkId { get; set; }

    /// <summary>
    /// <para>默认成本中心版本id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914821</para>
    /// </summary>
    [JsonPropertyName("wk_tid")]
    public string? WkTid { get; set; }
}
