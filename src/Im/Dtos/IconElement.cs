// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-27
//
// Last Modified By : yxr
// Last Modified On : 2025-11-27
// ************************************************************************
// <copyright file="IconElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图标 元素</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos;

/// <summary>
/// 图标 元素
/// </summary>
/// <param name="Tag"><inheritdoc/></param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator.Tag,
   UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
   IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(StandardIconElement), typeDiscriminator: "standard_icon")]
[JsonDerivedType(typeof(CustomIconElement), typeDiscriminator: "custom_icon")]
public abstract record IconElement(string Tag) : Element(Tag)
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [JsonIgnore]
    public override string Tag => base.Tag;
}
