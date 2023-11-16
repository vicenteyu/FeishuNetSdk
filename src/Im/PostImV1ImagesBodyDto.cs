namespace FeishuNetSdk.Im;
/// <summary>
/// 上传图片 请求体
/// <para>上传图片接口，支持上传 JPEG、PNG、WEBP、GIF、TIFF、BMP、ICO格式图片。</para>
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
    [System.Text.Json.Serialization.JsonPropertyName("image_type")]
    public string ImageType { get; set; } = string.Empty;
}
