// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ImagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传图片 响应体
/// <para>上传图片接口，支持上传 JPEG、PNG、WEBP、GIF、TIFF、BMP、ICO格式图片。</para>
/// <para>接口ID：6946222931479445505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/image/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fimage%2fcreate</para>
/// </summary>
public record PostImV1ImagesResponseDto
{
    /// <summary>
    /// <para>图片的key</para>
    /// <para>必填：否</para>
    /// <para>示例值：img_8d5181ca-0aed-40f0-b0d1-b1452132afbg</para>
    /// </summary>
    [JsonPropertyName("image_key")]
    public string? ImageKey { get; set; }
}
