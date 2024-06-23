// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="ImageContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图片消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    /// <param name="ImageKey">ImageKey需要先通过上传图片接口取得</param>
    public record ImageContent([property: JsonPropertyName("image_key")] string ImageKey = "") : MessageContent("image");
}
