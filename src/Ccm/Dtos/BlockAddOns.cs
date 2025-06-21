// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockAddOns.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Add-ons</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>Add-ons</para>
/// </summary>
public record BlockAddOns
{
    /// <summary>
    /// <para>团队互动应用唯一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7056882725002051603</para>
    /// </summary>
    [JsonPropertyName("component_id")]
    public string? ComponentId { get; set; }

    /// <summary>
    /// <para>团队互动应用类型，比如问答互动"blk_636a0a6657db8001c8df5488"</para>
    /// <para>必填：是</para>
    /// <para>示例值：blk_636a0a6657db8001c8df5488</para>
    /// </summary>
    [JsonPropertyName("component_type_id")]
    public string ComponentTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档小组件内容数据，JSON 字符串</para>
    /// <para>必填：否</para>
    /// <para>示例值："{}"</para>
    /// </summary>
    [JsonPropertyName("record")]
    public string? Record { get; set; }
}

