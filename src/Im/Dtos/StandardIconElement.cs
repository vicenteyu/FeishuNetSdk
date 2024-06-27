// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="StandardIconElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本前缀图标</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本前缀图标
    /// </summary>
    /// <param name="Token">图标库中图标的 token。</param>
    /// <param name="Color">图标的颜色。支持设置线性和面性图标（即 token 末尾为 outlined 或 filled 的图标）的颜色。枚举值参见颜色枚举值。
    /// <list type="bullet">
    /// <item>blue</item>
    /// <item>wathet</item>
    /// <item>turquoise</item>
    /// <item>green</item>
    /// <item>yellow</item>
    /// <item>orange</item>
    /// <item>red</item>
    /// <item>carmine</item>
    /// <item>violet</item>
    /// <item>purple</item>
    /// <item>indigo</item>
    /// <item>grey</item>
    /// <item>default</item>
    /// </list>
    /// </param>
    public record StandardIconElement([property: JsonPropertyName("token")] string? Token = null,
        [property: JsonPropertyName("color")] string? Color = null) : Element("standard_icon"), IAmDivIconElement, IAmNoteElement;
}
