// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdEnumsByEnumNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自定义枚举详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取自定义枚举详细信息 响应体
/// <para>获取应用下的自定义枚举详细信息，包括枚举名称、描述、枚举值列表等字段信息。</para>
/// <para>接口ID：7620858064161918159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-enum/get_enum_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-enum%2fget_enum_detail</para>
/// </summary>
public record GetSparkV1AppsByAppIdEnumsByEnumNameResponseDto
{
    /// <summary>
    /// <para>枚举名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：enum_name</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>枚举描述</para>
    /// <para>必填：是</para>
    /// <para>示例值：enum描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// <para>枚举值列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("options")]
    public string[] Options { get; set; } = [];

    /// <summary>
    /// <para>创建时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1765441837625</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; } = string.Empty;
}
