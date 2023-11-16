namespace FeishuNetSdk.HumanAuthentication.Spec;
/// <summary>
/// 裁剪人脸图片 响应体
/// <para>无源人脸比对流程，开发者后台通过调用此接口对基准图片做规范校验及处理。</para>
/// <para>无源人脸比对接入需申请白名单，接入前请联系飞书开放平台工作人员，邮箱：open-platform@bytedance.com。</para>
/// <para>接口ID：6940461543747289116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/facial-image-cropping</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fface%2ffacial-image-cropping</para>
/// </summary>
public record PostFaceVerifyV1CropFaceImageResponseDto
{
    /// <summary>
    /// <para>BASE64(裁剪后的人脸基准图片)，code为0时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("face_image")]
    public string? FaceImage { get; set; }
}
