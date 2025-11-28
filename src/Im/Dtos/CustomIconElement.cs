// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="CustomIconElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本前缀图标</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos;

/// <summary>
/// 文本前缀图标
/// </summary>
/// <param name="ImgKey">自定义前缀图标的图片 key。图标 key 的获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator.Tag,
    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
    IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(CustomIconElement), typeDiscriminator: "custom_icon")]
public record CustomIconElement([property: JsonPropertyName("img_key")] string? ImgKey = null)
    : IconElement("custom_icon"), IAmNoteElement;
