// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="MediaContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>视频消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 视频消息
    /// </summary>
    /// <param name="FileKey">视频文件Key，可通过上传文件接口获取文件的 file_key。</param>
    /// <param name="ImageKey">视频封面图片Key，可通过上传图片接口获取图片的image_key。</param>
    public record MediaContent([property: JsonPropertyName("file_key")] string FileKey = "",
        [property: JsonPropertyName("image_key")] string ImageKey = "") : MessageContent("media");

}
