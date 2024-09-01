// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件体
    /// </summary>
    /// <param name="Discriminator">事件体类型</param>
    public record EventBodyDto([property: JsonPropertyName("$type")] string Discriminator);
}
