// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2PathwaysResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建通道 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建通道 响应体
/// <para>创建通道，可以定义通道的名称、编码和描述信息</para>
/// <para>接口ID：7508634905586958339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fcreate</para>
/// </summary>
public record PostCorehrV2PathwaysResponseDto
{
    /// <summary>
    /// <para>通道ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345678</para>
    /// </summary>
    [JsonPropertyName("pathway_id")]
    public string? PathwayId { get; set; }
}
