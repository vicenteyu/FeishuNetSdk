// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="UrlVerificationDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件终结点验证结构体</summary>
// ************************************************************************
namespace FeishuNetSdk.Services;

/// <summary>
/// 事件终结点验证结构体
/// </summary>
/// <param name="Challenge"></param>
/// <param name="Type"></param>
public record UrlVerificationDto([property: JsonPropertyName("challenge")] string Challenge,
    [property: JsonPropertyName("type")] string Type) : EventDto("url_verification");
