// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2CostAllocationsCreateVersionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建成本分摊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建成本分摊 响应体
/// <para>创建成本分摊</para>
/// <para>接口ID：7486406573931741187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/create_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fcreate_version</para>
/// </summary>
public record PostCorehrV2CostAllocationsCreateVersionResponseDto
{
    /// <summary>
    /// <para>成本分摊ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345678</para>
    /// </summary>
    [JsonPropertyName("cost_allocation_id")]
    public string? CostAllocationId { get; set; }
}
