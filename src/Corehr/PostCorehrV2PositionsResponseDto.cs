// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="PostCorehrV2PositionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建岗位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建岗位信息 响应体
/// <para>创建岗位，可定义岗位关联的职务、职级、序列，以及岗位描述等</para>
/// <para>接口ID：7384280065851113473</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fcreate</para>
/// </summary>
public record PostCorehrV2PositionsResponseDto
{
    /// <summary>
    /// <para>岗位ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345678</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }
}
