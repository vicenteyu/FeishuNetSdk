// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ImagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传图片 请求体
/// <para>调用本接口将图片上传至飞书开放平台，支持上传 JPG、JPEG、PNG、WEBP、GIF、BMP、ICO、TIFF、HEIC 格式的图片，但需要注意 TIFF、HEIC 上传后会被转为 JPG 格式。</para>
/// <para>## 使用场景</para>
/// <para>如果需要发送图片消息，或者将图片作为头像，则需要先调用本接口将图片上传至开放平台，平台会返回一个图片标识（image_key），后续使用该 Key 值调用其他 API。例如：</para>
/// <para>- [发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)时，如果需要发送图片，则需要先调用本接口上传图片（上传时图片类型需要选择 **用于发送消息**），并使用返回结果中的 image_key 发送图片消息。</para>
/// <para>- [创建用户](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/create)时，如果需要设置用户头像，则需要先调用本接口将头像上传（上传时图片类型需要选择 **用于设置头像**），并使用返回结果中的 image_key 设置头像。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 上传的图片大小不能超过 10 MB，且不支持上传大小为 0 的图片。</para>
/// <para>- 上传图片的分辨率限制：</para>
/// <para>- GIF 图片分辨率不能超过 2000 x 2000，其他图片分辨率不能超过 12000 x 12000。</para>
/// <para>- 用于设置头像的图片分辨率不能超过 4096 x 4096。</para>
/// <para>如需上传高分辨率图片，可使用[上传文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/file/create)接口，将图片作为文件进行上传。注意该方式不支持将图片文件设置为头像。</para>
/// <para>接口ID：6946222931479445505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/image/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fimage%2fcreate</para>
/// </summary>
public record PostImV1ImagesBodyDto
{
    /// <summary>
    /// <para>图片类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：message</para>
    /// <para>可选值：<list type="bullet">
    /// <item>message：用于发送消息</item>
    /// <item>avatar：用于设置头像</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("image_type")]
    public string ImageType { get; set; } = string.Empty;
}
