// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersTreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定生效日期的成本中心架构树 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定生效日期的成本中心架构树 请求体
/// <para>支持传入成本中心ID，任意日期（不传默认当前日期）</para>
/// <para>接口ID：7637139455451139033</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2ftree</para>
/// </summary>
public record PostCorehrV2CostCentersTreeBodyDto
{
    /// <summary>
    /// <para>成本中心 ID，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// <para>是否包含失效成本中心，默认false：否</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_inactive")]
    public bool? NeedInactive { get; set; }

    /// <summary>
    /// <para>版本生效日期，格式yyyy-mm-dd，默认当前日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }
}
