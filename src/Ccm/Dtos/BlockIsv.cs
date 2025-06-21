// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockIsv.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>三方 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>三方 Block</para>
/// </summary>
public record BlockIsv
{
    /// <summary>
    /// <para>团队互动应用唯一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7056882725002051603</para>
    /// </summary>
    [JsonPropertyName("component_id")]
    public string? ComponentId { get; set; }

    /// <summary>
    /// <para>团队互动应用类型，比如信息收集"blk_5f992038c64240015d280958"</para>
    /// <para>必填：否</para>
    /// <para>示例值：blk_5f992038c64240015d280958</para>
    /// </summary>
    [JsonPropertyName("component_type_id")]
    public string? ComponentTypeId { get; set; }
}
