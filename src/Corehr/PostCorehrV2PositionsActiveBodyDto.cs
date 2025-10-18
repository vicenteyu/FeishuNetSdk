// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="PostCorehrV2PositionsActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启停用岗位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启停用岗位 请求体
/// <para>对岗位进行启用或停用操作</para>
/// <para>接口ID：7384280065851129857</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2factive</para>
/// </summary>
public record PostCorehrV2PositionsActiveBodyDto
{
    /// <summary>
    /// <para>岗位ID，详细信息可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914823</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string PositionId { get; set; } = string.Empty;

    /// <summary>
    /// <para>可选值：true（启用）、false（停用）</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;
}
