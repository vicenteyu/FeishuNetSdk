// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostFaceVerifyV1UploadFaceImageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传人脸基准图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.HumanAuthentication.Spec;
/// <summary>
/// 上传人脸基准图片 响应体
/// <para>无源人脸比对流程，开发者后台通过调用此接口将基准图片上传到飞书后台，做检测时的对比使用。</para>
/// <para>无源人脸比对接入需申请白名单，接入前请联系飞书开放平台工作人员，邮箱：open-platform@bytedance.com。</para>
/// <para>接口ID：6940461543747272732</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/upload-facial-reference-image</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fface%2fupload-facial-reference-image</para>
/// </summary>
public record PostFaceVerifyV1UploadFaceImageResponseDto
{
    /// <summary>
    /// <para>人脸图片用户Uid，需返回给应用小程序，作为小程序调起人脸识别接口的uid参数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("face_uid")]
    public string? FaceUid { get; set; }
}
