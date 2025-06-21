// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockDiagram.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流程图/UML Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>流程图/UML Block</para>
/// </summary>
public record BlockDiagram
{
    /// <summary>
    /// <para>绘图类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：流程图</item>
    /// <item>2：UML 图</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("diagram_type")]
    public int? DiagramType { get; set; }
}
