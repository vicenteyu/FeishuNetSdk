// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="MediaElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>媒体消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 媒体消息
    /// </summary>
    /// <param name="FileKey">视频文件的唯一标识，可通过 上传文件 接口获取file_key。</param>
    /// <param name="ImageKey">视频封面图片的唯一标识，可通过 上传图片 接口获取image_key。</param>
    public record MediaElement([property: JsonPropertyName("file_key")] string FileKey = "",
        [property: JsonPropertyName("image_key")] string ImageKey = "") : Element("media");
}
