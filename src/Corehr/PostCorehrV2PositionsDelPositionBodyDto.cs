// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="PostCorehrV2PositionsDelPositionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除岗位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 删除岗位 请求体
/// <para>删除整条岗位记录</para>
/// <para>接口ID：7384280065851097089</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/del_position</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fdel_position</para>
/// </summary>
public record PostCorehrV2PositionsDelPositionBodyDto
{
    /// <summary>
    /// <para>岗位ID，详细信息可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string PositionId { get; set; } = string.Empty;
}
